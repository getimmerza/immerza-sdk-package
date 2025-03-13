using Newtonsoft.Json;
using System;

namespace ImmerzaSDK.Types
{
    public enum ValueType
    {
        None,
        SingleValue,
        SingleReference,
        ArrayValue,
        ArrayReference,
        SingleAssetReference,
        ArrayAssetReference,
        UnityEvent,
        SingleStruct,
        ArrayOfStructs,
    }

    public class ValueField
    {
        public string value;
        public Type type;
        [JsonProperty("serialization_type")]
        public ValueType serializationType;
    }
}
