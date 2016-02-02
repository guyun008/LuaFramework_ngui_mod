using System;
using LuaInterface;

public class UIWidgetWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIWidget), typeof(UIRect));
		L.RegFunction("SetDimensions", SetDimensions);
		L.RegFunction("GetSides", GetSides);
		L.RegFunction("CalculateFinalAlpha", CalculateFinalAlpha);
		L.RegFunction("Invalidate", Invalidate);
		L.RegFunction("CalculateCumulativeAlpha", CalculateCumulativeAlpha);
		L.RegFunction("SetRect", SetRect);
		L.RegFunction("ResizeCollider", ResizeCollider);
		L.RegFunction("FullCompareFunc", FullCompareFunc);
		L.RegFunction("PanelCompareFunc", PanelCompareFunc);
		L.RegFunction("CalculateBounds", CalculateBounds);
		L.RegFunction("SetDirty", SetDirty);
		L.RegFunction("RemoveFromPanel", RemoveFromPanel);
		L.RegFunction("MarkAsChanged", MarkAsChanged);
		L.RegFunction("CreatePanel", CreatePanel);
		L.RegFunction("CheckLayer", CheckLayer);
		L.RegFunction("ParentHasChanged", ParentHasChanged);
		L.RegFunction("UpdateVisibility", UpdateVisibility);
		L.RegFunction("UpdateTransform", UpdateTransform);
		L.RegFunction("UpdateGeometry", UpdateGeometry);
		L.RegFunction("WriteToBuffers", WriteToBuffers);
		L.RegFunction("MakePixelPerfect", MakePixelPerfect);
		L.RegFunction("OnFill", OnFill);
		L.RegFunction("New", _CreateUIWidget);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("onChange", get_onChange, set_onChange);
		L.RegVar("onPostFill", get_onPostFill, set_onPostFill);
		L.RegVar("mOnRender", get_mOnRender, set_mOnRender);
		L.RegVar("autoResizeBoxCollider", get_autoResizeBoxCollider, set_autoResizeBoxCollider);
		L.RegVar("hideIfOffScreen", get_hideIfOffScreen, set_hideIfOffScreen);
		L.RegVar("keepAspectRatio", get_keepAspectRatio, set_keepAspectRatio);
		L.RegVar("aspectRatio", get_aspectRatio, set_aspectRatio);
		L.RegVar("hitCheck", get_hitCheck, set_hitCheck);
		L.RegVar("panel", get_panel, set_panel);
		L.RegVar("geometry", get_geometry, set_geometry);
		L.RegVar("fillGeometry", get_fillGeometry, set_fillGeometry);
		L.RegVar("drawCall", get_drawCall, set_drawCall);
		L.RegVar("onRender", get_onRender, set_onRender);
		L.RegVar("drawRegion", get_drawRegion, set_drawRegion);
		L.RegVar("pivotOffset", get_pivotOffset, null);
		L.RegVar("width", get_width, set_width);
		L.RegVar("height", get_height, set_height);
		L.RegVar("color", get_color, set_color);
		L.RegVar("alpha", get_alpha, set_alpha);
		L.RegVar("isVisible", get_isVisible, null);
		L.RegVar("hasVertices", get_hasVertices, null);
		L.RegVar("rawPivot", get_rawPivot, set_rawPivot);
		L.RegVar("pivot", get_pivot, set_pivot);
		L.RegVar("depth", get_depth, set_depth);
		L.RegVar("raycastDepth", get_raycastDepth, null);
		L.RegVar("localCorners", get_localCorners, null);
		L.RegVar("localSize", get_localSize, null);
		L.RegVar("localCenter", get_localCenter, null);
		L.RegVar("worldCorners", get_worldCorners, null);
		L.RegVar("worldCenter", get_worldCenter, null);
		L.RegVar("drawingDimensions", get_drawingDimensions, null);
		L.RegVar("material", get_material, set_material);
		L.RegVar("mainTexture", get_mainTexture, set_mainTexture);
		L.RegVar("shader", get_shader, set_shader);
		L.RegVar("hasBoxCollider", get_hasBoxCollider, null);
		L.RegVar("minWidth", get_minWidth, null);
		L.RegVar("minHeight", get_minHeight, null);
		L.RegVar("border", get_border, set_border);
		L.RegFunction("HitCheck", HitCheck);
		L.RegFunction("OnPostFillCallback", OnPostFillCallback);
		L.RegFunction("OnDimensionsChanged", OnDimensionsChanged);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUIWidget(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "UIWidget class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDimensions(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);

		try
		{
			obj.SetDimensions(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSides(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
		UnityEngine.Vector3[] o = null;

		try
		{
			o = obj.GetSides(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateFinalAlpha(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		float o;

		try
		{
			o = obj.CalculateFinalAlpha(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushnumber(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Invalidate(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.Invalidate(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateCumulativeAlpha(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		float o;

		try
		{
			o = obj.CalculateCumulativeAlpha(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushnumber(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRect(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 5);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
		float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
		float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
		float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);

		try
		{
			obj.SetRect(arg0, arg1, arg2, arg3);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResizeCollider(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));

		try
		{
			obj.ResizeCollider();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FullCompareFunc(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIWidget arg0 = (UIWidget)ToLua.CheckUnityObject(L, 1, typeof(UIWidget));
		UIWidget arg1 = (UIWidget)ToLua.CheckUnityObject(L, 2, typeof(UIWidget));
		int o;

		try
		{
			o = UIWidget.FullCompareFunc(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PanelCompareFunc(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIWidget arg0 = (UIWidget)ToLua.CheckUnityObject(L, 1, typeof(UIWidget));
		UIWidget arg1 = (UIWidget)ToLua.CheckUnityObject(L, 2, typeof(UIWidget));
		int o;

		try
		{
			o = UIWidget.PanelCompareFunc(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateBounds(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && ToLua.CheckTypes(L, 1, typeof(UIWidget)))
		{
			UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
			UnityEngine.Bounds o;

			try
			{
				o = obj.CalculateBounds();
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			ToLua.Push(L, o);
			return 1;
		}
		else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UIWidget), typeof(UnityEngine.Transform)))
		{
			UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
			UnityEngine.Bounds o;

			try
			{
				o = obj.CalculateBounds(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			ToLua.Push(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIWidget.CalculateBounds");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDirty(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));

		try
		{
			obj.SetDirty();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveFromPanel(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));

		try
		{
			obj.RemoveFromPanel();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MarkAsChanged(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));

		try
		{
			obj.MarkAsChanged();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreatePanel(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		UIPanel o = null;

		try
		{
			o = obj.CreatePanel();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckLayer(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));

		try
		{
			obj.CheckLayer();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ParentHasChanged(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));

		try
		{
			obj.ParentHasChanged();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateVisibility(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
		bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
		bool o;

		try
		{
			o = obj.UpdateVisibility(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateTransform(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		bool o;

		try
		{
			o = obj.UpdateTransform(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateGeometry(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		bool o;

		try
		{
			o = obj.UpdateGeometry(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WriteToBuffers(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 6);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		BetterList<UnityEngine.Vector3> arg0 = (BetterList<UnityEngine.Vector3>)ToLua.CheckObject(L, 2, typeof(BetterList<UnityEngine.Vector3>));
		BetterList<UnityEngine.Vector2> arg1 = (BetterList<UnityEngine.Vector2>)ToLua.CheckObject(L, 3, typeof(BetterList<UnityEngine.Vector2>));
		BetterList<UnityEngine.Color32> arg2 = (BetterList<UnityEngine.Color32>)ToLua.CheckObject(L, 4, typeof(BetterList<UnityEngine.Color32>));
		BetterList<UnityEngine.Vector3> arg3 = (BetterList<UnityEngine.Vector3>)ToLua.CheckObject(L, 5, typeof(BetterList<UnityEngine.Vector3>));
		BetterList<UnityEngine.Vector4> arg4 = (BetterList<UnityEngine.Vector4>)ToLua.CheckObject(L, 6, typeof(BetterList<UnityEngine.Vector4>));

		try
		{
			obj.WriteToBuffers(arg0, arg1, arg2, arg3, arg4);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MakePixelPerfect(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));

		try
		{
			obj.MakePixelPerfect();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnFill(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 4);
		UIWidget obj = (UIWidget)ToLua.CheckObject(L, 1, typeof(UIWidget));
		BetterList<UnityEngine.Vector3> arg0 = (BetterList<UnityEngine.Vector3>)ToLua.CheckObject(L, 2, typeof(BetterList<UnityEngine.Vector3>));
		BetterList<UnityEngine.Vector2> arg1 = (BetterList<UnityEngine.Vector2>)ToLua.CheckObject(L, 3, typeof(BetterList<UnityEngine.Vector2>));
		BetterList<UnityEngine.Color32> arg2 = (BetterList<UnityEngine.Color32>)ToLua.CheckObject(L, 4, typeof(BetterList<UnityEngine.Color32>));

		try
		{
			obj.OnFill(arg0, arg1, arg2);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
		UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
		bool o;

		try
		{
			o = arg0 == arg1;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onChange(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.OnDimensionsChanged ret = null;

		try
		{
			ret = obj.onChange;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index onChange on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPostFill(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.OnPostFillCallback ret = null;

		try
		{
			ret = obj.onPostFill;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index onPostFill on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mOnRender(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIDrawCall.OnRenderCallback ret = null;

		try
		{
			ret = obj.mOnRender;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index mOnRender on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_autoResizeBoxCollider(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.autoResizeBoxCollider;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index autoResizeBoxCollider on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hideIfOffScreen(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.hideIfOffScreen;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index hideIfOffScreen on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_keepAspectRatio(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.AspectRatioSource ret;

		try
		{
			ret = obj.keepAspectRatio;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index keepAspectRatio on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_aspectRatio(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.aspectRatio;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index aspectRatio on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hitCheck(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.HitCheck ret = null;

		try
		{
			ret = obj.hitCheck;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index hitCheck on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_panel(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIPanel ret = null;

		try
		{
			ret = obj.panel;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index panel on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_geometry(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIGeometry ret = null;

		try
		{
			ret = obj.geometry;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index geometry on a nil value" : e.Message);
		}

		ToLua.PushObject(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fillGeometry(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.fillGeometry;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index fillGeometry on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawCall(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIDrawCall ret = null;

		try
		{
			ret = obj.drawCall;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index drawCall on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onRender(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIDrawCall.OnRenderCallback ret = null;

		try
		{
			ret = obj.onRender;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index onRender on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawRegion(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 ret;

		try
		{
			ret = obj.drawRegion;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index drawRegion on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pivotOffset(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector2 ret;

		try
		{
			ret = obj.pivotOffset;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index pivotOffset on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.width;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index width on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.height;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index height on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_color(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Color ret;

		try
		{
			ret = obj.color;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index color on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alpha(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.alpha;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index alpha on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isVisible(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.isVisible;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index isVisible on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasVertices(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.hasVertices;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index hasVertices on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rawPivot(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.Pivot ret;

		try
		{
			ret = obj.rawPivot;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index rawPivot on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pivot(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.Pivot ret;

		try
		{
			ret = obj.pivot;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index pivot on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depth(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.depth;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index depth on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_raycastDepth(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.raycastDepth;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index raycastDepth on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localCorners(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector3[] ret = null;

		try
		{
			ret = obj.localCorners;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index localCorners on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localSize(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector2 ret;

		try
		{
			ret = obj.localSize;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index localSize on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localCenter(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector3 ret;

		try
		{
			ret = obj.localCenter;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index localCenter on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldCorners(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector3[] ret = null;

		try
		{
			ret = obj.worldCorners;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index worldCorners on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldCenter(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector3 ret;

		try
		{
			ret = obj.worldCenter;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index worldCenter on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawingDimensions(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 ret;

		try
		{
			ret = obj.drawingDimensions;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index drawingDimensions on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_material(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Material ret = null;

		try
		{
			ret = obj.material;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index material on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mainTexture(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Texture ret = null;

		try
		{
			ret = obj.mainTexture;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index mainTexture on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shader(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Shader ret = null;

		try
		{
			ret = obj.shader;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index shader on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasBoxCollider(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.hasBoxCollider;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index hasBoxCollider on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minWidth(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.minWidth;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index minWidth on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minHeight(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.minHeight;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index minHeight on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_border(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 ret;

		try
		{
			ret = obj.border;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index border on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onChange(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.OnDimensionsChanged arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UIWidget.OnDimensionsChanged)ToLua.CheckObject(L, 2, typeof(UIWidget.OnDimensionsChanged));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 2);
			arg0 = DelegateFactory.CreateDelegate(L, typeof(UIWidget.OnDimensionsChanged), func) as UIWidget.OnDimensionsChanged;
		}

		try
		{
			obj.onChange = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index onChange on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPostFill(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.OnPostFillCallback arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UIWidget.OnPostFillCallback)ToLua.CheckObject(L, 2, typeof(UIWidget.OnPostFillCallback));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 2);
			arg0 = DelegateFactory.CreateDelegate(L, typeof(UIWidget.OnPostFillCallback), func) as UIWidget.OnPostFillCallback;
		}

		try
		{
			obj.onPostFill = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index onPostFill on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mOnRender(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIDrawCall.OnRenderCallback arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UIDrawCall.OnRenderCallback)ToLua.CheckObject(L, 2, typeof(UIDrawCall.OnRenderCallback));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 2);
			arg0 = DelegateFactory.CreateDelegate(L, typeof(UIDrawCall.OnRenderCallback), func) as UIDrawCall.OnRenderCallback;
		}

		try
		{
			obj.mOnRender = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index mOnRender on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_autoResizeBoxCollider(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.autoResizeBoxCollider = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index autoResizeBoxCollider on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hideIfOffScreen(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.hideIfOffScreen = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index hideIfOffScreen on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_keepAspectRatio(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.AspectRatioSource arg0 = (UIWidget.AspectRatioSource)ToLua.CheckObject(L, 2, typeof(UIWidget.AspectRatioSource));

		try
		{
			obj.keepAspectRatio = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index keepAspectRatio on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_aspectRatio(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.aspectRatio = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index aspectRatio on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hitCheck(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.HitCheck arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UIWidget.HitCheck)ToLua.CheckObject(L, 2, typeof(UIWidget.HitCheck));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 2);
			arg0 = DelegateFactory.CreateDelegate(L, typeof(UIWidget.HitCheck), func) as UIWidget.HitCheck;
		}

		try
		{
			obj.hitCheck = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index hitCheck on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_panel(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIPanel arg0 = (UIPanel)ToLua.CheckUnityObject(L, 2, typeof(UIPanel));

		try
		{
			obj.panel = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index panel on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_geometry(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIGeometry arg0 = (UIGeometry)ToLua.CheckObject(L, 2, typeof(UIGeometry));

		try
		{
			obj.geometry = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index geometry on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fillGeometry(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.fillGeometry = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index fillGeometry on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_drawCall(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIDrawCall arg0 = (UIDrawCall)ToLua.CheckUnityObject(L, 2, typeof(UIDrawCall));

		try
		{
			obj.drawCall = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index drawCall on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onRender(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIDrawCall.OnRenderCallback arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UIDrawCall.OnRenderCallback)ToLua.CheckObject(L, 2, typeof(UIDrawCall.OnRenderCallback));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 2);
			arg0 = DelegateFactory.CreateDelegate(L, typeof(UIDrawCall.OnRenderCallback), func) as UIDrawCall.OnRenderCallback;
		}

		try
		{
			obj.onRender = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index onRender on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_drawRegion(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 arg0 = ToLua.ToVector4(L, 2);

		try
		{
			obj.drawRegion = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index drawRegion on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_width(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.width = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index width on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_height(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.height = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index height on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_color(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Color arg0 = ToLua.ToColor(L, 2);

		try
		{
			obj.color = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index color on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alpha(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.alpha = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index alpha on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rawPivot(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.Pivot arg0 = (UIWidget.Pivot)ToLua.CheckObject(L, 2, typeof(UIWidget.Pivot));

		try
		{
			obj.rawPivot = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index rawPivot on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pivot(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UIWidget.Pivot arg0 = (UIWidget.Pivot)ToLua.CheckObject(L, 2, typeof(UIWidget.Pivot));

		try
		{
			obj.pivot = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index pivot on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_depth(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.depth = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index depth on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_material(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Material arg0 = (UnityEngine.Material)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Material));

		try
		{
			obj.material = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index material on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mainTexture(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Texture arg0 = (UnityEngine.Texture)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Texture));

		try
		{
			obj.mainTexture = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index mainTexture on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_shader(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Shader arg0 = (UnityEngine.Shader)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Shader));

		try
		{
			obj.shader = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index shader on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_border(IntPtr L)
	{
		UIWidget obj = (UIWidget)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 arg0 = ToLua.ToVector4(L, 2);

		try
		{
			obj.border = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index border on a nil value");
			}
			else
			{
				LuaDLL.luaL_error(L, e.Message);
			}
			return 0;
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_out(IntPtr L)
	{
		ToLua.PushOut<UIWidget>(L, new LuaOut<UIWidget>());
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HitCheck(IntPtr L)
	{
		LuaFunction func = ToLua.CheckLuaFunction(L, 1);
		Delegate arg1 = DelegateFactory.CreateDelegate(L, typeof(UIWidget.HitCheck), func);
		ToLua.Push(L, arg1);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPostFillCallback(IntPtr L)
	{
		LuaFunction func = ToLua.CheckLuaFunction(L, 1);
		Delegate arg1 = DelegateFactory.CreateDelegate(L, typeof(UIWidget.OnPostFillCallback), func);
		ToLua.Push(L, arg1);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDimensionsChanged(IntPtr L)
	{
		LuaFunction func = ToLua.CheckLuaFunction(L, 1);
		Delegate arg1 = DelegateFactory.CreateDelegate(L, typeof(UIWidget.OnDimensionsChanged), func);
		ToLua.Push(L, arg1);
		return 1;
	}
}

