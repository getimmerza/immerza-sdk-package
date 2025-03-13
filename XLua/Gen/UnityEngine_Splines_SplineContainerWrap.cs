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
    public class UnityEngineSplinesSplineContainerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Splines.SplineContainer);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 3, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Warmup", _m_Warmup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Evaluate", _m_Evaluate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EvaluatePosition", _m_EvaluatePosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EvaluateTangent", _m_EvaluateTangent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EvaluateUpVector", _m_EvaluateUpVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EvaluateAcceleration", _m_EvaluateAcceleration);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLength", _m_CalculateLength);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnBeforeSerialize", _m_OnBeforeSerialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnAfterDeserialize", _m_OnAfterDeserialize);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Splines", _g_get_Splines);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "KnotLinkCollection", _g_get_KnotLinkCollection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Spline", _g_get_Spline);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Splines", _s_set_Splines);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Spline", _s_set_Spline);
            
			
			Utils.EndObjectRegister(type, L, translator, __CSIndexer, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SplineAdded", _e_SplineAdded);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SplineRemoved", _e_SplineRemoved);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SplineReordered", _e_SplineReordered);
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.Splines.SplineContainer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineContainer constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			try {
			    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (translator.Assignable<UnityEngine.Splines.SplineContainer>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
					int index = LuaAPI.xlua_tointeger(L, 2);
					LuaAPI.lua_pushboolean(L, true);
					translator.Push(L, gen_to_be_invoked[index]);
					return 2;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Warmup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Warmup(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Evaluate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _t = (float)LuaAPI.lua_tonumber(L, 2);
                    Unity.Mathematics.float3 _position;
                    Unity.Mathematics.float3 _tangent;
                    Unity.Mathematics.float3 _upVector;
                    
                        var gen_ret = gen_to_be_invoked.Evaluate( _t, out _position, out _tangent, out _upVector );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _position);
                        
                    translator.Push(L, _tangent);
                        
                    translator.Push(L, _upVector);
                        
                    
                    
                    
                    return 4;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _splineIndex = LuaAPI.xlua_tointeger(L, 2);
                    float _t = (float)LuaAPI.lua_tonumber(L, 3);
                    Unity.Mathematics.float3 _position;
                    Unity.Mathematics.float3 _tangent;
                    Unity.Mathematics.float3 _upVector;
                    
                        var gen_ret = gen_to_be_invoked.Evaluate( _splineIndex, _t, out _position, out _tangent, out _upVector );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _position);
                        
                    translator.Push(L, _tangent);
                        
                    translator.Push(L, _upVector);
                        
                    
                    
                    
                    return 4;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineContainer.Evaluate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EvaluatePosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _t = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.EvaluatePosition( _t );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _splineIndex = LuaAPI.xlua_tointeger(L, 2);
                    float _t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.EvaluatePosition( _splineIndex, _t );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineContainer.EvaluatePosition!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EvaluateTangent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _t = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.EvaluateTangent( _t );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _splineIndex = LuaAPI.xlua_tointeger(L, 2);
                    float _t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.EvaluateTangent( _splineIndex, _t );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineContainer.EvaluateTangent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EvaluateUpVector(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _t = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.EvaluateUpVector( _t );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _splineIndex = LuaAPI.xlua_tointeger(L, 2);
                    float _t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.EvaluateUpVector( _splineIndex, _t );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineContainer.EvaluateUpVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EvaluateAcceleration(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _t = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.EvaluateAcceleration( _t );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _splineIndex = LuaAPI.xlua_tointeger(L, 2);
                    float _t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.EvaluateAcceleration( _splineIndex, _t );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineContainer.EvaluateAcceleration!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateLength(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        var gen_ret = gen_to_be_invoked.CalculateLength(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _splineIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.CalculateLength( _splineIndex );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineContainer.CalculateLength!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnBeforeSerialize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnBeforeSerialize(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnAfterDeserialize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnAfterDeserialize(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Splines(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Splines);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_KnotLinkCollection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.KnotLinkCollection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Spline(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Spline);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Splines(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Splines = (System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.Spline>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Spline(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.SplineContainer gen_to_be_invoked = (UnityEngine.Splines.SplineContainer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Spline = (UnityEngine.Splines.Spline)translator.GetObject(L, 2, typeof(UnityEngine.Splines.Spline));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_SplineAdded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action<UnityEngine.Splines.SplineContainer, int> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.Splines.SplineContainer, int>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action<UnityEngine.Splines.SplineContainer, int>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.Splines.SplineContainer.SplineAdded += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.Splines.SplineContainer.SplineAdded -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineContainer.SplineAdded!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_SplineRemoved(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action<UnityEngine.Splines.SplineContainer, int> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.Splines.SplineContainer, int>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action<UnityEngine.Splines.SplineContainer, int>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.Splines.SplineContainer.SplineRemoved += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.Splines.SplineContainer.SplineRemoved -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineContainer.SplineRemoved!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_SplineReordered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action<UnityEngine.Splines.SplineContainer, int, int> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.Splines.SplineContainer, int, int>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action<UnityEngine.Splines.SplineContainer, int, int>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.Splines.SplineContainer.SplineReordered += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.Splines.SplineContainer.SplineReordered -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.SplineContainer.SplineReordered!");
        }
        
    }
}
