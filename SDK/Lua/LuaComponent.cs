using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using XLua;

namespace ImmerzaSDK.Lua
{
    [Serializable]
    public class Reference
    {
        public string variableName;
        public UnityEngine.Object value;
    }

    public class LuaComponent : MonoBehaviour
    {
        //private static Dictionary<string, Action<LuaTable>> eventListeners = new();

        [SerializeField] private LuaAsset luaFile;
        [SerializeField] private List<Reference> references;

        [HideInInspector] public LuaTable scriptEnv;

        // Standard engine functions to forward
        private Action luaAwake;
        private Action luaStart;
        private Action luaOnEnable;
        private Action luaOnDisable;
        private Action luaUpdate;
        private Action luaOnDestroy;

        //private readonly Func<GameObject, LuaTable> luaGetLuaComponent = GetLuaComponent;

        // Physics
        private Action<Collision> luaOnCollisionEnter;
        private Action<Collision> luaOnCollisionStay;
        private Action<Collision> luaOnCollisionExit;

        private Action<Collider> luaOnTriggerEnter;
        private Action<Collider> luaOnTriggerStay;
        private Action<Collider> luaOnTriggerExit;

        private void Awake()
        {
            LuaEnv crtGlobalEnv = ImmerzaLuaManager.Instance.GlobalEnv;

            scriptEnv = crtGlobalEnv.NewTable();

            using (LuaTable meta = crtGlobalEnv.NewTable())
            {
                meta.Set("__index", crtGlobalEnv.Global);
                scriptEnv.SetMetaTable(meta);
            }

            scriptEnv.Set("self", this);

            scriptEnv.Set("gameObject", gameObject);

            foreach (Reference refin in references)
            {
                scriptEnv.Set(refin.variableName, refin.value);
            }

            try
            {
                crtGlobalEnv.DoString(luaFile.content, luaFile.name, scriptEnv);
            }
            catch (Exception ex)
            {
                Debug.LogError("Lua execution error: " + ex.Message);
            }

            scriptEnv.Get("awake", out luaAwake);
            scriptEnv.Get("start", out luaStart);
            scriptEnv.Get("on_enable", out luaOnEnable);
            scriptEnv.Get("on_disable", out luaOnDisable);
            scriptEnv.Get("update", out luaUpdate);
            scriptEnv.Get("on_destroy", out luaOnDestroy);

            scriptEnv.Get("on_collision_enter", out luaOnCollisionEnter);
            scriptEnv.Get("on_collision_stay", out luaOnCollisionStay);
            scriptEnv.Get("on_collision_exit", out luaOnCollisionExit);

            scriptEnv.Get("on_trigger_enter", out luaOnTriggerEnter);
            scriptEnv.Get("on_trigger_stay", out luaOnTriggerStay);
            scriptEnv.Get("on_trigger_exit", out luaOnTriggerExit);

            luaAwake?.Invoke();
        }

        private void Start()
        {
            luaStart?.Invoke();
        }

        private void OnEnable()
        {
            luaOnEnable?.Invoke();
        }

        private void OnDisable()
        {
            luaOnDisable?.Invoke();
        }

        private void Update()
        {
            luaUpdate?.Invoke();
        }

        private void OnDestroy()
        {
            luaOnDestroy?.Invoke();
            luaUpdate = null;
        }

        private void OnCollisionEnter(Collision collision)
        {
            luaOnCollisionEnter?.Invoke(collision);
        }

        private void OnCollisionStay(Collision collision)
        {
            luaOnCollisionStay?.Invoke(collision);
        }

        private void OnCollisionExit(Collision collision)
        {
            luaOnCollisionExit.Invoke(collision);
        }

        private void OnTriggerEnter(Collider other)
        {
            luaOnTriggerEnter?.Invoke(other);
        }

        private void OnTriggerStay(Collider other)
        {
            luaOnTriggerStay?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            luaOnTriggerExit?.Invoke(other);
        }

        /*public static LuaTable GetLuaComponent(GameObject target)
        {
            if (target.TryGetComponent<LuaComponent>(out var comp))
            {
                return comp.scriptEnv;
            }
            return null;
        }*/
    }
}