using UnityEngine;

namespace ImmerzaSDK.Lua
{
    public class LuaAsset : ScriptableObject
    {
        [TextArea(50, 999)]
        public string content;
    }
}
