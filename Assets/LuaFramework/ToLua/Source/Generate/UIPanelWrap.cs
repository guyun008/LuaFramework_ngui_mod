using System;
using LuaInterface;

public class UIPanelWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIPanel), typeof(UIRect));
		L.RegFunction("CompareFunc", CompareFunc);
		L.RegFunction("GetSides", GetSides);
		L.RegFunction("Invalidate", Invalidate);
		L.RegFunction("CalculateFinalAlpha", CalculateFinalAlpha);
		L.RegFunction("SetRect", SetRect);
		L.RegFunction("IsVisible", IsVisible);
		L.RegFunction("Affects", Affects);
		L.RegFunction("RebuildAllDrawCalls", RebuildAllDrawCalls);
		L.RegFunction("SetDirty", SetDirty);
		L.RegFunction("ParentHasChanged", ParentHasChanged);
		L.RegFunction("SortWidgets", SortWidgets);
		L.RegFunction("FindDrawCall", FindDrawCall);
		L.RegFunction("AddWidget", AddWidget);
		L.RegFunction("RemoveWidget", RemoveWidget);
		L.RegFunction("Refresh", Refresh);
		L.RegFunction("CalculateConstrainOffset", CalculateConstrainOffset);
		L.RegFunction("ConstrainTargetToBounds", ConstrainTargetToBounds);
		L.RegFunction("Find", Find);
		L.RegFunction("GetWindowSize", GetWindowSize);
		L.RegFunction("GetViewSize", GetViewSize);
		L.RegFunction("New", _CreateUIPanel);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("list", get_list, set_list);
		L.RegVar("onGeometryUpdated", get_onGeometryUpdated, set_onGeometryUpdated);
		L.RegVar("showInPanelTool", get_showInPanelTool, set_showInPanelTool);
		L.RegVar("generateNormals", get_generateNormals, set_generateNormals);
		L.RegVar("widgetsAreStatic", get_widgetsAreStatic, set_widgetsAreStatic);
		L.RegVar("cullWhileDragging", get_cullWhileDragging, set_cullWhileDragging);
		L.RegVar("alwaysOnScreen", get_alwaysOnScreen, set_alwaysOnScreen);
		L.RegVar("anchorOffset", get_anchorOffset, set_anchorOffset);
		L.RegVar("softBorderPadding", get_softBorderPadding, set_softBorderPadding);
		L.RegVar("renderQueue", get_renderQueue, set_renderQueue);
		L.RegVar("startingRenderQueue", get_startingRenderQueue, set_startingRenderQueue);
		L.RegVar("widgets", get_widgets, set_widgets);
		L.RegVar("drawCalls", get_drawCalls, set_drawCalls);
		L.RegVar("worldToLocal", get_worldToLocal, set_worldToLocal);
		L.RegVar("drawCallClipRange", get_drawCallClipRange, set_drawCallClipRange);
		L.RegVar("onClipMove", get_onClipMove, set_onClipMove);
		L.RegVar("nextUnusedDepth", get_nextUnusedDepth, null);
		L.RegVar("canBeAnchored", get_canBeAnchored, null);
		L.RegVar("alpha", get_alpha, set_alpha);
		L.RegVar("depth", get_depth, set_depth);
		L.RegVar("sortingOrder", get_sortingOrder, set_sortingOrder);
		L.RegVar("width", get_width, null);
		L.RegVar("height", get_height, null);
		L.RegVar("halfPixelOffset", get_halfPixelOffset, null);
		L.RegVar("usedForUI", get_usedForUI, null);
		L.RegVar("drawCallOffset", get_drawCallOffset, null);
		L.RegVar("clipping", get_clipping, set_clipping);
		L.RegVar("parentPanel", get_parentPanel, null);
		L.RegVar("clipCount", get_clipCount, null);
		L.RegVar("hasClipping", get_hasClipping, null);
		L.RegVar("hasCumulativeClipping", get_hasCumulativeClipping, null);
		L.RegVar("clipOffset", get_clipOffset, set_clipOffset);
		L.RegVar("clipTexture", get_clipTexture, set_clipTexture);
		L.RegVar("baseClipRegion", get_baseClipRegion, set_baseClipRegion);
		L.RegVar("finalClipRegion", get_finalClipRegion, null);
		L.RegVar("clipSoftness", get_clipSoftness, set_clipSoftness);
		L.RegVar("localCorners", get_localCorners, null);
		L.RegVar("worldCorners", get_worldCorners, null);
		L.RegFunction("OnClippingMoved", OnClippingMoved);
		L.RegFunction("OnGeometryUpdated", OnGeometryUpdated);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUIPanel(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "UIPanel class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CompareFunc(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIPanel arg0 = (UIPanel)ToLua.CheckUnityObject(L, 1, typeof(UIPanel));
		UIPanel arg1 = (UIPanel)ToLua.CheckUnityObject(L, 2, typeof(UIPanel));
		int o;

		try
		{
			o = UIPanel.CompareFunc(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSides(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
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
	static int Invalidate(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
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
	static int CalculateFinalAlpha(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
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
	static int SetRect(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 5);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
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
	static int IsVisible(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UIPanel), typeof(UIWidget)))
		{
			UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
			UIWidget arg0 = (UIWidget)ToLua.ToObject(L, 2);
			bool o;

			try
			{
				o = obj.IsVisible(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UIPanel), typeof(UnityEngine.Vector3)))
		{
			UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			bool o;

			try
			{
				o = obj.IsVisible(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		else if (count == 5 && ToLua.CheckTypes(L, 1, typeof(UIPanel), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3)))
		{
			UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
			UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 4);
			UnityEngine.Vector3 arg3 = ToLua.ToVector3(L, 5);
			bool o;

			try
			{
				o = obj.IsVisible(arg0, arg1, arg2, arg3);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIPanel.IsVisible");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Affects(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
		UIWidget arg0 = (UIWidget)ToLua.CheckUnityObject(L, 2, typeof(UIWidget));
		bool o;

		try
		{
			o = obj.Affects(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RebuildAllDrawCalls(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));

		try
		{
			obj.RebuildAllDrawCalls();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDirty(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));

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
	static int ParentHasChanged(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));

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
	static int SortWidgets(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));

		try
		{
			obj.SortWidgets();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindDrawCall(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
		UIWidget arg0 = (UIWidget)ToLua.CheckUnityObject(L, 2, typeof(UIWidget));
		UIDrawCall o = null;

		try
		{
			o = obj.FindDrawCall(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddWidget(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
		UIWidget arg0 = (UIWidget)ToLua.CheckUnityObject(L, 2, typeof(UIWidget));

		try
		{
			obj.AddWidget(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveWidget(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
		UIWidget arg0 = (UIWidget)ToLua.CheckUnityObject(L, 2, typeof(UIWidget));

		try
		{
			obj.RemoveWidget(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Refresh(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));

		try
		{
			obj.Refresh();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateConstrainOffset(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 3);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
		UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
		UnityEngine.Vector2 arg1 = ToLua.ToVector2(L, 3);
		UnityEngine.Vector3 o;

		try
		{
			o = obj.CalculateConstrainOffset(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConstrainTargetToBounds(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 3 && ToLua.CheckTypes(L, 1, typeof(UIPanel), typeof(UnityEngine.Transform), typeof(bool)))
		{
			UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
			bool arg1 = LuaDLL.lua_toboolean(L, 3);
			bool o;

			try
			{
				o = obj.ConstrainTargetToBounds(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		else if (count == 4 && ToLua.CheckTypes(L, 1, typeof(UIPanel), typeof(UnityEngine.Transform), typeof(UnityEngine.Bounds), typeof(bool)))
		{
			UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
			UnityEngine.Bounds arg1 = ToLua.ToBounds(L, 3);
			bool arg2 = LuaDLL.lua_toboolean(L, 4);
			bool o;

			try
			{
				o = obj.ConstrainTargetToBounds(arg0, ref arg1, arg2);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			LuaDLL.lua_pushboolean(L, o);
			ToLua.Push(L, arg1);
			return 2;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIPanel.ConstrainTargetToBounds");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Find(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.Transform)))
		{
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			UIPanel o = null;

			try
			{
				o = UIPanel.Find(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			ToLua.Push(L, o);
			return 1;
		}
		else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(bool)))
		{
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			bool arg1 = LuaDLL.lua_toboolean(L, 2);
			UIPanel o = null;

			try
			{
				o = UIPanel.Find(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			ToLua.Push(L, o);
			return 1;
		}
		else if (count == 3 && ToLua.CheckTypes(L, 1, typeof(UnityEngine.Transform), typeof(bool), typeof(int)))
		{
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 1);
			bool arg1 = LuaDLL.lua_toboolean(L, 2);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 3);
			UIPanel o = null;

			try
			{
				o = UIPanel.Find(arg0, arg1, arg2);
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
			LuaDLL.luaL_error(L, "invalid arguments to method: UIPanel.Find");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetWindowSize(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
		UnityEngine.Vector2 o;

		try
		{
			o = obj.GetWindowSize();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetViewSize(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIPanel obj = (UIPanel)ToLua.CheckObject(L, 1, typeof(UIPanel));
		UnityEngine.Vector2 o;

		try
		{
			o = obj.GetViewSize();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
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
	static int get_list(IntPtr L)
	{
		ToLua.PushObject(L, UIPanel.list);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onGeometryUpdated(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UIPanel.OnGeometryUpdated ret = null;

		try
		{
			ret = obj.onGeometryUpdated;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index onGeometryUpdated on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_showInPanelTool(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.showInPanelTool;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index showInPanelTool on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_generateNormals(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.generateNormals;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index generateNormals on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_widgetsAreStatic(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.widgetsAreStatic;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index widgetsAreStatic on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cullWhileDragging(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.cullWhileDragging;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index cullWhileDragging on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alwaysOnScreen(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.alwaysOnScreen;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index alwaysOnScreen on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anchorOffset(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.anchorOffset;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index anchorOffset on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_softBorderPadding(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.softBorderPadding;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index softBorderPadding on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderQueue(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UIPanel.RenderQueue ret;

		try
		{
			ret = obj.renderQueue;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index renderQueue on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_startingRenderQueue(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.startingRenderQueue;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index startingRenderQueue on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_widgets(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		System.Collections.Generic.List<UIWidget> ret = null;

		try
		{
			ret = obj.widgets;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index widgets on a nil value" : e.Message);
		}

		ToLua.PushObject(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawCalls(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		System.Collections.Generic.List<UIDrawCall> ret = null;

		try
		{
			ret = obj.drawCalls;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index drawCalls on a nil value" : e.Message);
		}

		ToLua.PushObject(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldToLocal(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Matrix4x4 ret;

		try
		{
			ret = obj.worldToLocal;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index worldToLocal on a nil value" : e.Message);
		}

		ToLua.PushValue(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawCallClipRange(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 ret;

		try
		{
			ret = obj.drawCallClipRange;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index drawCallClipRange on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClipMove(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UIPanel.OnClippingMoved ret = null;

		try
		{
			ret = obj.onClipMove;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index onClipMove on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_nextUnusedDepth(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UIPanel.nextUnusedDepth);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canBeAnchored(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.canBeAnchored;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index canBeAnchored on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alpha(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
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
	static int get_depth(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
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
	static int get_sortingOrder(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.sortingOrder;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index sortingOrder on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.width;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index width on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.height;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index height on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_halfPixelOffset(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.halfPixelOffset;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index halfPixelOffset on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_usedForUI(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.usedForUI;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index usedForUI on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_drawCallOffset(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Vector3 ret;

		try
		{
			ret = obj.drawCallOffset;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index drawCallOffset on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipping(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UIDrawCall.Clipping ret;

		try
		{
			ret = obj.clipping;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index clipping on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_parentPanel(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UIPanel ret = null;

		try
		{
			ret = obj.parentPanel;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index parentPanel on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipCount(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.clipCount;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index clipCount on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasClipping(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.hasClipping;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index hasClipping on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hasCumulativeClipping(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.hasCumulativeClipping;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index hasCumulativeClipping on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipOffset(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Vector2 ret;

		try
		{
			ret = obj.clipOffset;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index clipOffset on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipTexture(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Texture2D ret = null;

		try
		{
			ret = obj.clipTexture;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index clipTexture on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_baseClipRegion(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 ret;

		try
		{
			ret = obj.baseClipRegion;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index baseClipRegion on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_finalClipRegion(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 ret;

		try
		{
			ret = obj.finalClipRegion;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index finalClipRegion on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipSoftness(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Vector2 ret;

		try
		{
			ret = obj.clipSoftness;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index clipSoftness on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_localCorners(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
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
	static int get_worldCorners(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
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
	static int set_list(IntPtr L)
	{
		System.Collections.Generic.List<UIPanel> arg0 = (System.Collections.Generic.List<UIPanel>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<UIPanel>));
		UIPanel.list = arg0;
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onGeometryUpdated(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UIPanel.OnGeometryUpdated arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UIPanel.OnGeometryUpdated)ToLua.CheckObject(L, 2, typeof(UIPanel.OnGeometryUpdated));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 2);
			arg0 = DelegateFactory.CreateDelegate(L, typeof(UIPanel.OnGeometryUpdated), func) as UIPanel.OnGeometryUpdated;
		}

		try
		{
			obj.onGeometryUpdated = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index onGeometryUpdated on a nil value");
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
	static int set_showInPanelTool(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.showInPanelTool = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index showInPanelTool on a nil value");
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
	static int set_generateNormals(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.generateNormals = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index generateNormals on a nil value");
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
	static int set_widgetsAreStatic(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.widgetsAreStatic = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index widgetsAreStatic on a nil value");
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
	static int set_cullWhileDragging(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.cullWhileDragging = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index cullWhileDragging on a nil value");
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
	static int set_alwaysOnScreen(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.alwaysOnScreen = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index alwaysOnScreen on a nil value");
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
	static int set_anchorOffset(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.anchorOffset = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index anchorOffset on a nil value");
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
	static int set_softBorderPadding(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.softBorderPadding = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index softBorderPadding on a nil value");
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
	static int set_renderQueue(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UIPanel.RenderQueue arg0 = (UIPanel.RenderQueue)ToLua.CheckObject(L, 2, typeof(UIPanel.RenderQueue));

		try
		{
			obj.renderQueue = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index renderQueue on a nil value");
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
	static int set_startingRenderQueue(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.startingRenderQueue = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index startingRenderQueue on a nil value");
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
	static int set_widgets(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		System.Collections.Generic.List<UIWidget> arg0 = (System.Collections.Generic.List<UIWidget>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<UIWidget>));

		try
		{
			obj.widgets = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index widgets on a nil value");
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
	static int set_drawCalls(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		System.Collections.Generic.List<UIDrawCall> arg0 = (System.Collections.Generic.List<UIDrawCall>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<UIDrawCall>));

		try
		{
			obj.drawCalls = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index drawCalls on a nil value");
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
	static int set_worldToLocal(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Matrix4x4 arg0 = (UnityEngine.Matrix4x4)ToLua.CheckObject(L, 2, typeof(UnityEngine.Matrix4x4));

		try
		{
			obj.worldToLocal = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index worldToLocal on a nil value");
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
	static int set_drawCallClipRange(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 arg0 = ToLua.ToVector4(L, 2);

		try
		{
			obj.drawCallClipRange = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index drawCallClipRange on a nil value");
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
	static int set_onClipMove(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UIPanel.OnClippingMoved arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UIPanel.OnClippingMoved)ToLua.CheckObject(L, 2, typeof(UIPanel.OnClippingMoved));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 2);
			arg0 = DelegateFactory.CreateDelegate(L, typeof(UIPanel.OnClippingMoved), func) as UIPanel.OnClippingMoved;
		}

		try
		{
			obj.onClipMove = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index onClipMove on a nil value");
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
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
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
	static int set_depth(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
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
	static int set_sortingOrder(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.sortingOrder = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index sortingOrder on a nil value");
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
	static int set_clipping(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UIDrawCall.Clipping arg0 = (UIDrawCall.Clipping)ToLua.CheckObject(L, 2, typeof(UIDrawCall.Clipping));

		try
		{
			obj.clipping = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index clipping on a nil value");
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
	static int set_clipOffset(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);

		try
		{
			obj.clipOffset = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index clipOffset on a nil value");
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
	static int set_clipTexture(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Texture2D arg0 = (UnityEngine.Texture2D)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Texture2D));

		try
		{
			obj.clipTexture = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index clipTexture on a nil value");
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
	static int set_baseClipRegion(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Vector4 arg0 = ToLua.ToVector4(L, 2);

		try
		{
			obj.baseClipRegion = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index baseClipRegion on a nil value");
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
	static int set_clipSoftness(IntPtr L)
	{
		UIPanel obj = (UIPanel)ToLua.ToObject(L, 1);
		UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);

		try
		{
			obj.clipSoftness = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index clipSoftness on a nil value");
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
		ToLua.PushOut<UIPanel>(L, new LuaOut<UIPanel>());
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnClippingMoved(IntPtr L)
	{
		LuaFunction func = ToLua.CheckLuaFunction(L, 1);
		Delegate arg1 = DelegateFactory.CreateDelegate(L, typeof(UIPanel.OnClippingMoved), func);
		ToLua.Push(L, arg1);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnGeometryUpdated(IntPtr L)
	{
		LuaFunction func = ToLua.CheckLuaFunction(L, 1);
		Delegate arg1 = DelegateFactory.CreateDelegate(L, typeof(UIPanel.OnGeometryUpdated), func);
		ToLua.Push(L, arg1);
		return 1;
	}
}

