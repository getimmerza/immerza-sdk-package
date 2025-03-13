using Newtonsoft.Json;
using System.Collections.Generic;

namespace ImmerzaSDK.Types
{
    public class ComponentData
    {
        [JsonProperty("class_name")]
        public string className;
        public Dictionary<string, ValueField> fields;
    }
}
