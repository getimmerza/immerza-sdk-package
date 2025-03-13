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
    public class UnityEngineSplinesSplineWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Splines.Spline);
			Utils.BeginObjectRegister(type, L, translator, 0, 54, 4, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetFloatData", _m_TryGetFloatData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetFloat4Data", _m_TryGetFloat4Data);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetIntData", _m_TryGetIntData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetObjectData", _m_TryGetObjectData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetOrCreateFloatData", _m_GetOrCreateFloatData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetOrCreateFloat4Data", _m_GetOrCreateFloat4Data);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetOrCreateIntData", _m_GetOrCreateIntData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetOrCreateObjectData", _m_GetOrCreateObjectData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveFloatData", _m_RemoveFloatData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveFloat4Data", _m_RemoveFloat4Data);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveIntData", _m_RemoveIntData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveObjectData", _m_RemoveObjectData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFloatDataKeys", _m_GetFloatDataKeys);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFloat4DataKeys", _m_GetFloat4DataKeys);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIntDataKeys", _m_GetIntDataKeys);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetObjectDataKeys", _m_GetObjectDataKeys);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSplineDataKeys", _m_GetSplineDataKeys);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFloatDataValues", _m_GetFloatDataValues);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFloat4DataValues", _m_GetFloat4DataValues);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIntDataValues", _m_GetIntDataValues);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetObjectDataValues", _m_GetObjectDataValues);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFloatData", _m_SetFloatData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFloat4Data", _m_SetFloat4Data);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIntData", _m_SetIntData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetObjectData", _m_SetObjectData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnforceTangentModeNoNotify", _m_EnforceTangentModeNoNotify);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTangentMode", _m_GetTangentMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTangentMode", _m_SetTangentMode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTangentModeNoNotify", _m_SetTangentModeNoNotify);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAutoSmoothTension", _m_GetAutoSmoothTension);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAutoSmoothTension", _m_SetAutoSmoothTension);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAutoSmoothTensionNoNotify", _m_SetAutoSmoothTensionNoNotify);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IndexOf", _m_IndexOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Insert", _m_Insert);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAt", _m_RemoveAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetKnot", _m_SetKnot);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetKnotNoNotify", _m_SetKnotNoNotify);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCurve", _m_GetCurve);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCurveLength", _m_GetCurveLength);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLength", _m_GetLength);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCurveInterpolation", _m_GetCurveInterpolation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCurveUpVector", _m_GetCurveUpVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Warmup", _m_Warmup);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Resize", _m_Resize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToArray", _m_ToArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Copy", _m_Copy);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", _m_GetEnumerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", _m_Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRange", _m_AddRange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InsertRange", _m_InsertRange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Contains", _m_Contains);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyTo", _m_CopyTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count", _g_get_Count);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsReadOnly", _g_get_IsReadOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Knots", _g_get_Knots);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Closed", _g_get_Closed);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Knots", _s_set_Knots);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Closed", _s_set_Closed);
            
			
			Utils.EndObjectRegister(type, L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Changed", _e_Changed);
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.Splines.Spline();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3))
				{
					int _knotCapacity = LuaAPI.xlua_tointeger(L, 2);
					bool _closed = LuaAPI.lua_toboolean(L, 3);
					
					var gen_ret = new UnityEngine.Splines.Spline(_knotCapacity, _closed);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int _knotCapacity = LuaAPI.xlua_tointeger(L, 2);
					
					var gen_ret = new UnityEngine.Splines.Spline(_knotCapacity);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>>(L, 2) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3))
				{
					System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot> _knots = (System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>));
					bool _closed = LuaAPI.lua_toboolean(L, 3);
					
					var gen_ret = new UnityEngine.Splines.Spline(_knots, _closed);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot> _knots = (System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>));
					
					var gen_ret = new UnityEngine.Splines.Spline(_knots);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>>(L, 2) && translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4))
				{
					System.Collections.Generic.IEnumerable<Unity.Mathematics.float3> _knotPositions = (System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>));
					UnityEngine.Splines.TangentMode _tangentMode;translator.Get(L, 3, out _tangentMode);
					bool _closed = LuaAPI.lua_toboolean(L, 4);
					
					var gen_ret = new UnityEngine.Splines.Spline(_knotPositions, _tangentMode, _closed);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>>(L, 2) && translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3))
				{
					System.Collections.Generic.IEnumerable<Unity.Mathematics.float3> _knotPositions = (System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>));
					UnityEngine.Splines.TangentMode _tangentMode;translator.Get(L, 3, out _tangentMode);
					
					var gen_ret = new UnityEngine.Splines.Spline(_knotPositions, _tangentMode);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<Unity.Mathematics.float3> _knotPositions = (System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>));
					
					var gen_ret = new UnityEngine.Splines.Spline(_knotPositions);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.Splines.Spline>(L, 2))
				{
					UnityEngine.Splines.Spline _spline = (UnityEngine.Splines.Spline)translator.GetObject(L, 2, typeof(UnityEngine.Splines.Spline));
					
					var gen_ret = new UnityEngine.Splines.Spline(_spline);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			try {
			    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (translator.Assignable<UnityEngine.Splines.Spline>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
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
        public static int __NewIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
			try {
				
				if (translator.Assignable<UnityEngine.Splines.Spline>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 3))
				{
					
					UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
					int key = LuaAPI.xlua_tointeger(L, 2);
					UnityEngine.Splines.BezierKnot gen_value;translator.Get(L, 3, out gen_value);
					gen_to_be_invoked[key] = gen_value;
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetFloatData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Splines.SplineData<float> _data;
                    
                        var gen_ret = gen_to_be_invoked.TryGetFloatData( _key, out _data );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _data);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetFloat4Data(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Splines.SplineData<Unity.Mathematics.float4> _data;
                    
                        var gen_ret = gen_to_be_invoked.TryGetFloat4Data( _key, out _data );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _data);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetIntData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Splines.SplineData<int> _data;
                    
                        var gen_ret = gen_to_be_invoked.TryGetIntData( _key, out _data );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _data);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetObjectData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Splines.SplineData<UnityEngine.Object> _data;
                    
                        var gen_ret = gen_to_be_invoked.TryGetObjectData( _key, out _data );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _data);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOrCreateFloatData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetOrCreateFloatData( _key );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOrCreateFloat4Data(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetOrCreateFloat4Data( _key );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOrCreateIntData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetOrCreateIntData( _key );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOrCreateObjectData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetOrCreateObjectData( _key );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveFloatData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.RemoveFloatData( _key );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveFloat4Data(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.RemoveFloat4Data( _key );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveIntData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.RemoveIntData( _key );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveObjectData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.RemoveObjectData( _key );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloatDataKeys(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetFloatDataKeys(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloat4DataKeys(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetFloat4DataKeys(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIntDataKeys(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetIntDataKeys(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObjectDataKeys(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetObjectDataKeys(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSplineDataKeys(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Splines.EmbeddedSplineDataType _type;translator.Get(L, 2, out _type);
                    
                        var gen_ret = gen_to_be_invoked.GetSplineDataKeys( _type );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloatDataValues(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetFloatDataValues(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloat4DataValues(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetFloat4DataValues(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIntDataValues(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetIntDataValues(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetObjectDataValues(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetObjectDataValues(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloatData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Splines.SplineData<float> _value = (UnityEngine.Splines.SplineData<float>)translator.GetObject(L, 3, typeof(UnityEngine.Splines.SplineData<float>));
                    
                    gen_to_be_invoked.SetFloatData( _key, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloat4Data(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Splines.SplineData<Unity.Mathematics.float4> _value = (UnityEngine.Splines.SplineData<Unity.Mathematics.float4>)translator.GetObject(L, 3, typeof(UnityEngine.Splines.SplineData<Unity.Mathematics.float4>));
                    
                    gen_to_be_invoked.SetFloat4Data( _key, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIntData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Splines.SplineData<int> _value = (UnityEngine.Splines.SplineData<int>)translator.GetObject(L, 3, typeof(UnityEngine.Splines.SplineData<int>));
                    
                    gen_to_be_invoked.SetIntData( _key, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetObjectData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Splines.SplineData<UnityEngine.Object> _value = (UnityEngine.Splines.SplineData<UnityEngine.Object>)translator.GetObject(L, 3, typeof(UnityEngine.Splines.SplineData<UnityEngine.Object>));
                    
                    gen_to_be_invoked.SetObjectData( _key, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnforceTangentModeNoNotify(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.EnforceTangentModeNoNotify( _index );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Splines.SplineRange>(L, 2)) 
                {
                    UnityEngine.Splines.SplineRange _range;translator.Get(L, 2, out _range);
                    
                    gen_to_be_invoked.EnforceTangentModeNoNotify( _range );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.EnforceTangentModeNoNotify!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTangentMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetTangentMode( _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTangentMode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 2)) 
                {
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 2, out _mode);
                    
                    gen_to_be_invoked.SetTangentMode( _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3)&& translator.Assignable<UnityEngine.Splines.BezierTangent>(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 3, out _mode);
                    UnityEngine.Splines.BezierTangent _main;translator.Get(L, 4, out _main);
                    
                    gen_to_be_invoked.SetTangentMode( _index, _mode, _main );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.SetTangentMode( _index, _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Splines.SplineRange>(L, 2)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3)&& translator.Assignable<UnityEngine.Splines.BezierTangent>(L, 4)) 
                {
                    UnityEngine.Splines.SplineRange _range;translator.Get(L, 2, out _range);
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 3, out _mode);
                    UnityEngine.Splines.BezierTangent _main;translator.Get(L, 4, out _main);
                    
                    gen_to_be_invoked.SetTangentMode( _range, _mode, _main );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Splines.SplineRange>(L, 2)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3)) 
                {
                    UnityEngine.Splines.SplineRange _range;translator.Get(L, 2, out _range);
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.SetTangentMode( _range, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.SetTangentMode!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTangentModeNoNotify(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3)&& translator.Assignable<UnityEngine.Splines.BezierTangent>(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 3, out _mode);
                    UnityEngine.Splines.BezierTangent _main;translator.Get(L, 4, out _main);
                    
                    gen_to_be_invoked.SetTangentModeNoNotify( _index, _mode, _main );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.SetTangentModeNoNotify( _index, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.SetTangentModeNoNotify!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAutoSmoothTension(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetAutoSmoothTension( _index );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAutoSmoothTension(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    float _tension = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetAutoSmoothTension( _index, _tension );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Splines.SplineRange>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Splines.SplineRange _range;translator.Get(L, 2, out _range);
                    float _tension = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetAutoSmoothTension( _range, _tension );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.SetAutoSmoothTension!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAutoSmoothTensionNoNotify(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    float _tension = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetAutoSmoothTensionNoNotify( _index, _tension );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Splines.SplineRange>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Splines.SplineRange _range;translator.Get(L, 2, out _range);
                    float _tension = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetAutoSmoothTensionNoNotify( _range, _tension );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.SetAutoSmoothTensionNoNotify!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IndexOf(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Splines.BezierKnot _item;translator.Get(L, 2, out _item);
                    
                        var gen_ret = gen_to_be_invoked.IndexOf( _item );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Insert(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.BezierKnot _knot;translator.Get(L, 3, out _knot);
                    
                    gen_to_be_invoked.Insert( _index, _knot );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 3)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.BezierKnot _knot;translator.Get(L, 3, out _knot);
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 4, out _mode);
                    
                    gen_to_be_invoked.Insert( _index, _knot, _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<Unity.Mathematics.float3>(L, 3)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    Unity.Mathematics.float3 _knotPosition;translator.Get(L, 3, out _knotPosition);
                    UnityEngine.Splines.TangentMode _tangentMode;translator.Get(L, 4, out _tangentMode);
                    
                    gen_to_be_invoked.Insert( _index, _knotPosition, _tangentMode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<Unity.Mathematics.float3>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    Unity.Mathematics.float3 _knotPosition;translator.Get(L, 3, out _knotPosition);
                    
                    gen_to_be_invoked.Insert( _index, _knotPosition );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 3)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.BezierKnot _knot;translator.Get(L, 3, out _knot);
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 4, out _mode);
                    float _tension = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    gen_to_be_invoked.Insert( _index, _knot, _mode, _tension );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.Insert!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveAt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.RemoveAt( _index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetKnot(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 3)&& translator.Assignable<UnityEngine.Splines.BezierTangent>(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.BezierKnot _value;translator.Get(L, 3, out _value);
                    UnityEngine.Splines.BezierTangent _main;translator.Get(L, 4, out _main);
                    
                    gen_to_be_invoked.SetKnot( _index, _value, _main );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.BezierKnot _value;translator.Get(L, 3, out _value);
                    
                    gen_to_be_invoked.SetKnot( _index, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.SetKnot!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetKnotNoNotify(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 3)&& translator.Assignable<UnityEngine.Splines.BezierTangent>(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.BezierKnot _value;translator.Get(L, 3, out _value);
                    UnityEngine.Splines.BezierTangent _main;translator.Get(L, 4, out _main);
                    
                    gen_to_be_invoked.SetKnotNoNotify( _index, _value, _main );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Splines.BezierKnot _value;translator.Get(L, 3, out _value);
                    
                    gen_to_be_invoked.SetKnotNoNotify( _index, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.SetKnotNoNotify!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCurve(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetCurve( _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCurveLength(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetCurveLength( _index );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLength(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetLength(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCurveInterpolation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _curveIndex = LuaAPI.xlua_tointeger(L, 2);
                    float _curveDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetCurveInterpolation( _curveIndex, _curveDistance );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCurveUpVector(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    float _t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetCurveUpVector( _index, _t );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Warmup(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Warmup(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Resize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _newSize = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Resize( _newSize );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.ToArray(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Copy(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Splines.Spline _copyFrom = (UnityEngine.Splines.Spline)translator.GetObject(L, 2, typeof(UnityEngine.Splines.Spline));
                    
                    gen_to_be_invoked.Copy( _copyFrom );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetEnumerator(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetEnumerator(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 2)) 
                {
                    UnityEngine.Splines.BezierKnot _item;translator.Get(L, 2, out _item);
                    
                    gen_to_be_invoked.Add( _item );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Splines.Spline>(L, 2)) 
                {
                    UnityEngine.Splines.Spline _spline = (UnityEngine.Splines.Spline)translator.GetObject(L, 2, typeof(UnityEngine.Splines.Spline));
                    
                    gen_to_be_invoked.Add( _spline );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<Unity.Mathematics.float3>(L, 2)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3)) 
                {
                    Unity.Mathematics.float3 _knotPosition;translator.Get(L, 2, out _knotPosition);
                    UnityEngine.Splines.TangentMode _tangentMode;translator.Get(L, 3, out _tangentMode);
                    
                    gen_to_be_invoked.Add( _knotPosition, _tangentMode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<Unity.Mathematics.float3>(L, 2)) 
                {
                    Unity.Mathematics.float3 _knotPosition;translator.Get(L, 2, out _knotPosition);
                    
                    gen_to_be_invoked.Add( _knotPosition );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 2)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3)) 
                {
                    UnityEngine.Splines.BezierKnot _item;translator.Get(L, 2, out _item);
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.Add( _item, _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Splines.BezierKnot>(L, 2)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Splines.BezierKnot _item;translator.Get(L, 2, out _item);
                    UnityEngine.Splines.TangentMode _mode;translator.Get(L, 3, out _mode);
                    float _tension = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.Add( _item, _mode, _tension );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.Add!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRange(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>>(L, 2)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 3)) 
                {
                    System.Collections.Generic.IEnumerable<Unity.Mathematics.float3> _knotPositions = (System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>));
                    UnityEngine.Splines.TangentMode _tangentMode;translator.Get(L, 3, out _tangentMode);
                    
                    gen_to_be_invoked.AddRange( _knotPositions, _tangentMode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>>(L, 2)) 
                {
                    System.Collections.Generic.IEnumerable<Unity.Mathematics.float3> _knotPositions = (System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>));
                    
                    gen_to_be_invoked.AddRange( _knotPositions );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.AddRange!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InsertRange(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>>(L, 3)&& translator.Assignable<UnityEngine.Splines.TangentMode>(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.IEnumerable<Unity.Mathematics.float3> _knotPositions = (System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>));
                    UnityEngine.Splines.TangentMode _tangentMode;translator.Get(L, 4, out _tangentMode);
                    
                    gen_to_be_invoked.InsertRange( _index, _knotPositions, _tangentMode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.IEnumerable<Unity.Mathematics.float3> _knotPositions = (System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IEnumerable<Unity.Mathematics.float3>));
                    
                    gen_to_be_invoked.InsertRange( _index, _knotPositions );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.InsertRange!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Contains(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Splines.BezierKnot _item;translator.Get(L, 2, out _item);
                    
                        var gen_ret = gen_to_be_invoked.Contains( _item );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Splines.BezierKnot[] _array = (UnityEngine.Splines.BezierKnot[])translator.GetObject(L, 2, typeof(UnityEngine.Splines.BezierKnot[]));
                    int _arrayIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.CopyTo( _array, _arrayIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Splines.BezierKnot _item;translator.Get(L, 2, out _item);
                    
                        var gen_ret = gen_to_be_invoked.Remove( _item );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Count);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsReadOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsReadOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Knots(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.Knots);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Closed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Closed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Knots(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Knots = (System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<UnityEngine.Splines.BezierKnot>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Closed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Splines.Spline gen_to_be_invoked = (UnityEngine.Splines.Spline)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Closed = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_Changed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action<UnityEngine.Splines.Spline, int, UnityEngine.Splines.SplineModification> gen_delegate = translator.GetDelegate<System.Action<UnityEngine.Splines.Spline, int, UnityEngine.Splines.SplineModification>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action<UnityEngine.Splines.Spline, int, UnityEngine.Splines.SplineModification>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.Splines.Spline.Changed += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.Splines.Spline.Changed -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Splines.Spline.Changed!");
        }
        
    }
}
