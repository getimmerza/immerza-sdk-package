#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineSplinesSplineAnimateWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Splines.SplineAnimate);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 14, 13);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", _m_Play);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Pause", _m_Pause);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Restart", _m_Restart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Updated", _e_Updated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Completed", _e_Completed);
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Container", _g_get_Container);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PlayOnAwake", _g_get_PlayOnAwake);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Loop", _g_get_Loop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AnimationMethod", _g_get_AnimationMethod);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Duration", _g_get_Duration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MaxSpeed", _g_get_MaxSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Easing", _g_get_Easing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Alignment", _g_get_Alignment);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ObjectForwardAxis", _g_get_ObjectForwardAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ObjectUpAxis", _g_get_ObjectUpAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "NormalizedTime", _g_get_NormalizedTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ElapsedTime", _g_get_ElapsedTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "StartOffset", _g_get_StartOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsPlaying", _g_get_IsPlaying);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Container", _s_set_Container);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "PlayOnAwake", _s_set_PlayOnAwake);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Loop", _s_set_Loop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AnimationMethod", _s_set_AnimationMethod);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Duration", _s_set_Duration);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MaxSpeed", _s_set_MaxSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Easing", _s_set_Easing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Alignment", _s_set_Alignment);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ObjectForwardAxis", _s_set_ObjectForwardAxis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ObjectUpAxis", _s_set_ObjectUpAxis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "NormalizedTime", _s_set_NormalizedTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ElapsedTime", _s_set_ElapsedTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "StartOffset", _s_set_StartOffset);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.Splines.SplineAnimate();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineAnimate constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Play(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Play(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Pause(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Pause(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Restart(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _autoplay = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.Restart( _autoplay );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Update(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Container(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Container);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PlayOnAwake(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.PlayOnAwake);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Loop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Loop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AnimationMethod(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AnimationMethod);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Duration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.Duration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.MaxSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Easing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Easing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Alignment(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Alignment);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ObjectForwardAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ObjectForwardAxis);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ObjectUpAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ObjectUpAxis);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NormalizedTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.NormalizedTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ElapsedTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.ElapsedTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_StartOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.StartOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsPlaying(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsPlaying);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Container(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Container = (UnityEngine.Splines.SplineContainer)translator.GetObject(L, 2, typeof(UnityEngine.Splines.SplineContainer));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_PlayOnAwake(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.PlayOnAwake = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Loop(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                UnityEngine.Splines.SplineAnimate.LoopMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.Loop = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AnimationMethod(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                UnityEngine.Splines.SplineAnimate.Method gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.AnimationMethod = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Duration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Duration = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MaxSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.MaxSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Easing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                UnityEngine.Splines.SplineAnimate.EasingMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.Easing = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Alignment(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                UnityEngine.Splines.SplineAnimate.AlignmentMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.Alignment = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ObjectForwardAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                UnityEngine.Splines.SplineComponent.AlignAxis gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.ObjectForwardAxis = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ObjectUpAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                UnityEngine.Splines.SplineComponent.AlignAxis gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.ObjectUpAxis = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_NormalizedTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.NormalizedTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ElapsedTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ElapsedTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_StartOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.StartOffset = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Updated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Updated += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Updated -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineAnimate.Updated!");
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Completed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
			UnityEngine.Splines.SplineAnimate gen_to_be_invoked = (UnityEngine.Splines.SplineAnimate)translator.FastGetCSObj(L, 1);
                System.Action gen_delegate = translator.GetDelegate<System.Action>(L, 3);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#3 need System.Action!");
                }
				
				if (gen_param_count == 3)
				{
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "+")) {
						gen_to_be_invoked.Completed += gen_delegate;
						return 0;
					} 
					
					
					if (LuaAPI.xlua_is_eq_str(L, 2, "-")) {
						gen_to_be_invoked.Completed -= gen_delegate;
						return 0;
					} 
					
				}
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineAnimate.Completed!");
            return 0;
        }
        
		
		
    }
}
