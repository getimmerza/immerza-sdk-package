using Newtonsoft.Json;
using System.Collections.Generic;

namespace ImmerzaSDK.Types
{
    public class AssetMetadata
    {
        [JsonProperty("asset_table")]
        public Dictionary<string, List<string>> assetTable = new Dictionary<string, List<string>>();
        [JsonProperty("component_table")]
        public Dictionary<string, List<ComponentData>> componentTable = new Dictionary<string, List<ComponentData>>();

        public void AddAsset(string label, string assetPath)
        {
            if (!assetTable.ContainsKey(label))
            {
                assetTable[label] = new List<string>();
            }
            assetTable[label].Add(assetPath);
        }

        public void AddComponent(string path, string className, Dictionary<string, ValueField> values)
        {
            ComponentData data = new ComponentData()
            {
                className = className,
                fields = values
            };

            if (!componentTable.ContainsKey(path))
            {
                componentTable.Add(path, new List<ComponentData>());
            }

            componentTable[path].Add(data);
        }
    }
}
