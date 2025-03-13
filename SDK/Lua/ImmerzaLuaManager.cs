using UnityEngine;
using XLua;

namespace ImmerzaSDK.Lua
{
    [DefaultExecutionOrder(-500)]
    public class ImmerzaLuaManager : MonoBehaviour
    {
        public static ImmerzaLuaManager Instance { get; private set; }
        public LuaEnv GlobalEnv { get; private set; } = new LuaEnv();

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }

        private void Update()
        {
            GlobalEnv.Tick();
        }

        private void OnDestroy()
        {
            //GlobalEnv.Dispose();
        }
    }
}
