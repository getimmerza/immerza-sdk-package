using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace ImmerzaSDK.Serialize
{
    public class GenericStructConverter<T> : JsonConverter<T> where T : struct
    {
        private static List<MemberInfo> _fieldInfos = new List<MemberInfo>();

        public GenericStructConverter(params string[] fields)
        {
            if (_fieldInfos.Count == 0)
            {
                Type type = typeof(T);
                foreach (string name in fields)
                {
                    MemberInfo fieldInfo = type.GetField(name);
                    if (fieldInfo == null)
                    {
                        fieldInfo = type.GetProperty(name);
                    }

                    if (fieldInfo != null)
                    {
                        _fieldInfos.Add(fieldInfo);
                    }
                }
            }
        }

        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return default(T);
            }

            object value = new T();

            AssertTokenType(reader, JsonToken.StartObject);

            reader.Read();

            while (reader.TokenType == JsonToken.PropertyName)
            {
                string properytName = reader.Value as string;

                // we ignore property names that are not stored as string
                if (string.IsNullOrEmpty(properytName))
                {
                    reader.Skip();
                }
                else
                {
                    MemberInfo memberInfo = _fieldInfos.Where(info => info.Name == properytName).FirstOrDefault();
                    if (memberInfo != null)
                    {
                        reader.Read();
                        if (memberInfo is FieldInfo fieldInfo)
                            fieldInfo.SetValue(value, ConvertType(fieldInfo.FieldType, reader.Value));
                        else if (memberInfo is PropertyInfo propertyInfo)
                            propertyInfo.SetValue(value, ConvertType(propertyInfo.PropertyType, reader.Value));
                    }
                }

                reader.Read();
            }

            AssertTokenType(reader, JsonToken.EndObject);

            return (T)value;
        }

        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            {
                foreach (MemberInfo memberInfo in _fieldInfos)
                {
                    writer.WritePropertyName(memberInfo.Name);
                    if (memberInfo is FieldInfo fieldInfo)
                        writer.WriteValue(fieldInfo.GetValue(value));
                    else if (memberInfo is PropertyInfo propertyInfo)
                        writer.WriteValue(propertyInfo.GetValue(value));
                }
            }
            writer.WriteEndObject();
        }

        private static void AssertTokenType(JsonReader reader, JsonToken expected)
        {
            if (reader.TokenType != expected)
                throw new JsonSerializationException();
        }

        private static object ConvertType(Type targetType, object value)
        {
            return Convert.ChangeType(value, targetType);
        }
    }

    #region Converters Math
    public class ConverterColor : GenericStructConverter<Color> {public ConverterColor(): base("r", "g", "b", "a") { }}
    public class ConverterColor32 : GenericStructConverter<Color32> { public ConverterColor32() : base("r", "g", "b", "a") { }}
    public class ConverterVector2 : GenericStructConverter<Vector2> { public ConverterVector2() : base("x", "y") { }}
    public class ConverterVector2Int: GenericStructConverter<Vector2Int> { public ConverterVector2Int() : base("x", "y") { } }
    public class ConverterVector3 : GenericStructConverter<Vector3> { public ConverterVector3() : base("x", "y", "z") { } }
    public class ConverterVector3Int : GenericStructConverter<Vector3Int> { public ConverterVector3Int() : base("x", "y", "z") { } }
    public class ConverterVector4 : GenericStructConverter<Vector4> { public ConverterVector4() : base("x", "y", "z", "w") { } }
    public class ConverterQuaternion : GenericStructConverter<Quaternion> { public ConverterQuaternion() : base("x", "y", "z", "w") { } }
    public class ConverterMatrix4x4 : GenericStructConverter<Matrix4x4> { public ConverterMatrix4x4() : base("m00", "m10", "m20", "m30", "m01", "m11", "m21", "m31", "m02", "m12", "m22", "m23", "m03", "m13", "m23", "m33") { } }
    #endregion

    public static class JsonSettings
    {
        public static readonly JsonSerializerSettings Settings = new();
        static JsonSettings()
        {
            Settings.Converters = new List<JsonConverter>
            {
                new ConverterColor(), new ConverterColor32(), new ConverterVector2(), new ConverterVector2Int(), new ConverterVector3(), new ConverterVector3Int(),
                new ConverterVector4(), new ConverterQuaternion(), new ConverterMatrix4x4()
            };
        }
    }
}