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
    public class ImmerzaSDKBreathingDetectionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ImmerzaSDK.BreathingDetection);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 28, 28);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "inhaleTime", _g_get_inhaleTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "exhaleTime", _g_get_exhaleTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "holdTime", _g_get_holdTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "breathCount", _g_get_breathCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "breathCount2", _g_get_breathCount2);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "totalTime", _g_get_totalTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "postTime", _g_get_postTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isBreathCompleted", _g_get_isBreathCompleted);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isStart", _g_get_isStart);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFinish", _g_get_isFinish);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isStaticScene", _g_get_isStaticScene);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isFirstTimeRespiratory", _g_get_isFirstTimeRespiratory);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "breathDirection", _g_get_breathDirection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "totalInhaleTime", _g_get_totalInhaleTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "totalExhaleTime", _g_get_totalExhaleTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "totalHoldTime", _g_get_totalHoldTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastInhaleTime", _g_get_lastInhaleTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastExhaleTime", _g_get_lastExhaleTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lastHoldTime", _g_get_lastHoldTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "calculatedLastInhaleTime", _g_get_calculatedLastInhaleTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "calculatedLastExhaleTime", _g_get_calculatedLastExhaleTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "calculatedLastHoldTime", _g_get_calculatedLastHoldTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "breathAPI", _g_get_breathAPI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "breathLastAPIHold", _g_get_breathLastAPIHold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "breathLastAPIInhale", _g_get_breathLastAPIInhale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "breathLastAPIExhale", _g_get_breathLastAPIExhale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "countOfGoodInhale", _g_get_countOfGoodInhale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "countOfGoodExhale", _g_get_countOfGoodExhale);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "inhaleTime", _s_set_inhaleTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "exhaleTime", _s_set_exhaleTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "holdTime", _s_set_holdTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "breathCount", _s_set_breathCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "breathCount2", _s_set_breathCount2);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "totalTime", _s_set_totalTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "postTime", _s_set_postTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isBreathCompleted", _s_set_isBreathCompleted);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isStart", _s_set_isStart);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isFinish", _s_set_isFinish);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isStaticScene", _s_set_isStaticScene);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isFirstTimeRespiratory", _s_set_isFirstTimeRespiratory);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "breathDirection", _s_set_breathDirection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "totalInhaleTime", _s_set_totalInhaleTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "totalExhaleTime", _s_set_totalExhaleTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "totalHoldTime", _s_set_totalHoldTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lastInhaleTime", _s_set_lastInhaleTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lastExhaleTime", _s_set_lastExhaleTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lastHoldTime", _s_set_lastHoldTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "calculatedLastInhaleTime", _s_set_calculatedLastInhaleTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "calculatedLastExhaleTime", _s_set_calculatedLastExhaleTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "calculatedLastHoldTime", _s_set_calculatedLastHoldTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "breathAPI", _s_set_breathAPI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "breathLastAPIHold", _s_set_breathLastAPIHold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "breathLastAPIInhale", _s_set_breathLastAPIInhale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "breathLastAPIExhale", _s_set_breathLastAPIExhale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "countOfGoodInhale", _s_set_countOfGoodInhale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "countOfGoodExhale", _s_set_countOfGoodExhale);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 1, 0);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ExhaleStarted", _e_ExhaleStarted);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ExhaleFinished", _e_ExhaleFinished);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "RespiratoryRatePost", _e_RespiratoryRatePost);
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new ImmerzaSDK.BreathingDetection();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ImmerzaSDK.BreathingDetection constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, ImmerzaSDK.BreathingDetection.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.inhaleTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_exhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.exhaleTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_holdTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.holdTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_breathCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.breathCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_breathCount2(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.breathCount2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_totalTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.totalTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_postTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.postTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isBreathCompleted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isBreathCompleted);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isStart(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isStart);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFinish(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isFinish);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isStaticScene(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isStaticScene);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFirstTimeRespiratory(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isFirstTimeRespiratory);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_breathDirection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.breathDirection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_totalInhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.totalInhaleTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_totalExhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.totalExhaleTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_totalHoldTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.totalHoldTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastInhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lastInhaleTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastExhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lastExhaleTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lastHoldTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lastHoldTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_calculatedLastInhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.calculatedLastInhaleTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_calculatedLastExhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.calculatedLastExhaleTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_calculatedLastHoldTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.calculatedLastHoldTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_breathAPI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.breathAPI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_breathLastAPIHold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.breathLastAPIHold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_breathLastAPIInhale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.breathLastAPIInhale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_breathLastAPIExhale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.breathLastAPIExhale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_countOfGoodInhale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.countOfGoodInhale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_countOfGoodExhale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.countOfGoodExhale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inhaleTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_exhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.exhaleTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_holdTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.holdTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_breathCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.breathCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_breathCount2(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.breathCount2 = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_totalTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.totalTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_postTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.postTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isBreathCompleted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isBreathCompleted = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isStart(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isStart = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isFinish(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isFinish = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isStaticScene(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isStaticScene = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isFirstTimeRespiratory(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isFirstTimeRespiratory = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_breathDirection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.breathDirection = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_totalInhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.totalInhaleTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_totalExhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.totalExhaleTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_totalHoldTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.totalHoldTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lastInhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lastInhaleTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lastExhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lastExhaleTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lastHoldTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lastHoldTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_calculatedLastInhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.calculatedLastInhaleTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_calculatedLastExhaleTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.calculatedLastExhaleTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_calculatedLastHoldTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.calculatedLastHoldTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_breathAPI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.breathAPI = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_breathLastAPIHold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.breathLastAPIHold = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_breathLastAPIInhale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.breathLastAPIInhale = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_breathLastAPIExhale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.breathLastAPIExhale = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_countOfGoodInhale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.countOfGoodInhale = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_countOfGoodExhale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ImmerzaSDK.BreathingDetection gen_to_be_invoked = (ImmerzaSDK.BreathingDetection)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.countOfGoodExhale = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ExhaleStarted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action gen_delegate = translator.GetDelegate<System.Action>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					ImmerzaSDK.BreathingDetection.ExhaleStarted += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					ImmerzaSDK.BreathingDetection.ExhaleStarted -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to ImmerzaSDK.BreathingDetection.ExhaleStarted!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_ExhaleFinished(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action gen_delegate = translator.GetDelegate<System.Action>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					ImmerzaSDK.BreathingDetection.ExhaleFinished += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					ImmerzaSDK.BreathingDetection.ExhaleFinished -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to ImmerzaSDK.BreathingDetection.ExhaleFinished!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_RespiratoryRatePost(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action<string, float, float, float> gen_delegate = translator.GetDelegate<System.Action<string, float, float, float>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action<string, float, float, float>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					ImmerzaSDK.BreathingDetection.RespiratoryRatePost += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					ImmerzaSDK.BreathingDetection.RespiratoryRatePost -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to ImmerzaSDK.BreathingDetection.RespiratoryRatePost!");
        }
        
    }
}
