#define TEST_SUPPORT

#if TEST_SUPPORT && UNITY_EDITOR_WIN
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace ImmerzaSDK.Serialize.Test
{
    internal class ConverterTestAttribute : Attribute
    {}
    internal class ConverterTestContainer : Attribute
    { }

    [ConverterTestContainer]
    internal static class ConvertersTest
    {
        [MenuItem("Tools/Test Converters")]
        public static void RunTests()
        {
            var testContainers = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.GetCustomAttribute<ConverterTestContainer>() != null);
            foreach (Type type in testContainers)
            {
                var testMethods = type.GetMethods().Where(method => method.GetCustomAttributes(typeof(ConverterTestAttribute), false).Length != 0).ToArray();
                Debug.Log($"Running {testMethods.Length} test groups...");
                for (int i = 0; i < testMethods.Length; i++)
                {
                        Debug.Log($"Running tests for group {i+1}: {testMethods[i].Name}");
                        if (testMethods[i].IsStatic)
                            testMethods[i].Invoke(null, new object[] { });
                }
            }
        }

        [ConverterTest]
        public static void RunTestsColor()
        {
            Check(RunTests<Color>(Color.red));
            Check(RunTests<Color>(Color.green));
            Check(RunTests<Color>(Color.blue));
            Check(RunTests<Color>(Color.white));
            Check(RunTests<Color>(new Color(0.1f, 0.2f, 0.3f, 0.8f)));
        }

        [ConverterTest]
        public static void RunTestsColor32()
        {
            Check(RunTests<Color32>(new Color32(255, 0, 0, 255)));
            Check(RunTests<Color32>(new Color32(0, 255, 0, 255)));
            Check(RunTests<Color32>(new Color32(0, 0, 255, 255)));
            Check(RunTests<Color32>(new Color32(255, 255, 255, 255)));
            Check(RunTests<Color32>(new Color32(25, 50, 75, 204)));
        }

        [ConverterTest]
        public static void RunTestsVector()
        {
            Check(RunTests<Vector2>(Vector2.up));
            Check(RunTests<Vector2>(Vector2.down));
            Check(RunTests<Vector2>(Vector2.zero));
            Check(RunTests<Vector2>(Vector2.one * 0.3f));

            Check(RunTests<Vector2Int>(Vector2Int.up));
            Check(RunTests<Vector2Int>(Vector2Int.down));
            Check(RunTests<Vector2Int>(Vector2Int.zero));
            Check(RunTests<Vector2Int>(Vector2Int.one * 42));

            Check(RunTests<Vector3>(Vector3.up));
            Check(RunTests<Vector3>(Vector3.down));
            Check(RunTests<Vector3>(Vector3.forward));
            Check(RunTests<Vector3>(Vector3.back));
            Check(RunTests<Vector3>(Vector3.up + Vector3.forward));
            Check(RunTests<Vector3>(Vector3.zero));
            Check(RunTests<Vector3>(Vector3.one * 0.3f));

            Check(RunTests<Vector3Int>(Vector3Int.up));
            Check(RunTests<Vector3Int>(Vector3Int.down));
            Check(RunTests<Vector3Int>(Vector3Int.forward));
            Check(RunTests<Vector3Int>(Vector3Int.back));
            Check(RunTests<Vector3Int>(Vector3Int.zero));
            Check(RunTests<Vector3Int>(Vector3Int.one * 42));

            Check(RunTests<Vector4>(new Vector4(1, 0, 0, 0)));
            Check(RunTests<Vector4>(new Vector4(1, 1, 0, 0)));
            Check(RunTests<Vector4>(new Vector4(1, 1, 1, 0)));
            Check(RunTests<Vector4>(new Vector4(1, 1, 1, 1)));
            Check(RunTests<Vector4>(new Vector4(1, 0.5f, 0.4f, 0.1f)));
        }

        [ConverterTest]
        public static void RunTestsQuaternion()
        {
            Check(RunTests<Quaternion>(Quaternion.identity));
            Check(RunTests<Quaternion>(Quaternion.Euler(90.0f, 0.0f, 0.0f)));
            Check(RunTests<Quaternion>(Quaternion.Euler(90.0f, 180.0f, 0.0f)));
        }

        [ConverterTest]
        public static void RunTestsMatrix()
        {
            Check(RunTests<Matrix4x4>(Matrix4x4.zero));
            Check(RunTests<Matrix4x4>(Matrix4x4.identity));
            Check(RunTests<Matrix4x4>(Matrix4x4.identity));
            Check(RunTests<Matrix4x4>(Matrix4x4.Rotate(Quaternion.AngleAxis(33.0f, Vector2.up))));
        }

        private static bool RunTests<T>(T value) where T : struct
        {
            string serializedValue = JsonConvert.SerializeObject(value, JsonSettings.Settings);
            return JsonConvert.DeserializeObject<T>(serializedValue, JsonSettings.Settings).Equals(value);
        }

        private static void Check(bool result, [CallerMemberName] string methodName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
        {
            if (!result)
            {
                Debug.LogError($"Test failed @{methodName}:{lineNumber} in {filePath}");
            }
        }
    }
}
#endif