using System;
using LuaInterface;

public class UIGridWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIGrid), typeof(UIWidgetContainer));
		L.RegFunction("GetChildList", GetChildList);
		L.RegFunction("GetChild", GetChild);
		L.RegFunction("GetIndex", GetIndex);
		L.RegFunction("AddChild", AddChild);
		L.RegFunction("RemoveChild", RemoveChild);
		L.RegFunction("SortByName", SortByName);
		L.RegFunction("SortHorizontal", SortHorizontal);
		L.RegFunction("SortVertical", SortVertical);
		L.RegFunction("Reposition", Reposition);
		L.RegFunction("ConstrainWithinPanel", ConstrainWithinPanel);
		L.RegFunction("New", _CreateUIGrid);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("arrangement", get_arrangement, set_arrangement);
		L.RegVar("sorting", get_sorting, set_sorting);
		L.RegVar("pivot", get_pivot, set_pivot);
		L.RegVar("maxPerLine", get_maxPerLine, set_maxPerLine);
		L.RegVar("cellWidth", get_cellWidth, set_cellWidth);
		L.RegVar("cellHeight", get_cellHeight, set_cellHeight);
		L.RegVar("animateSmoothly", get_animateSmoothly, set_animateSmoothly);
		L.RegVar("hideInactive", get_hideInactive, set_hideInactive);
		L.RegVar("keepWithinPanel", get_keepWithinPanel, set_keepWithinPanel);
		L.RegVar("onReposition", get_onReposition, set_onReposition);
		L.RegVar("onCustomSort", get_onCustomSort, set_onCustomSort);
		L.RegVar("repositionNow", null, set_repositionNow);
		L.RegFunction("OnReposition", OnReposition);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUIGrid(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "UIGrid class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChildList(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIGrid obj = (UIGrid)ToLua.CheckObject(L, 1, typeof(UIGrid));
		System.Collections.Generic.List<UnityEngine.Transform> o = null;

		try
		{
			o = obj.GetChildList();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChild(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIGrid obj = (UIGrid)ToLua.CheckObject(L, 1, typeof(UIGrid));
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		UnityEngine.Transform o = null;

		try
		{
			o = obj.GetChild(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		ToLua.Push(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetIndex(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIGrid obj = (UIGrid)ToLua.CheckObject(L, 1, typeof(UIGrid));
		UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
		int o;

		try
		{
			o = obj.GetIndex(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddChild(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UIGrid), typeof(UnityEngine.Transform)))
		{
			UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);

			try
			{
				obj.AddChild(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			return 0;
		}
		else if (count == 3 && ToLua.CheckTypes(L, 1, typeof(UIGrid), typeof(UnityEngine.Transform), typeof(bool)))
		{
			UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);
			bool arg1 = LuaDLL.lua_toboolean(L, 3);

			try
			{
				obj.AddChild(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIGrid.AddChild");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChild(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIGrid obj = (UIGrid)ToLua.CheckObject(L, 1, typeof(UIGrid));
		UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
		bool o;

		try
		{
			o = obj.RemoveChild(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SortByName(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
		UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
		int o;

		try
		{
			o = UIGrid.SortByName(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SortHorizontal(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
		UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
		int o;

		try
		{
			o = UIGrid.SortHorizontal(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SortVertical(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 1, typeof(UnityEngine.Transform));
		UnityEngine.Transform arg1 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
		int o;

		try
		{
			o = UIGrid.SortVertical(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		LuaDLL.lua_pushinteger(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reposition(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIGrid obj = (UIGrid)ToLua.CheckObject(L, 1, typeof(UIGrid));

		try
		{
			obj.Reposition();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConstrainWithinPanel(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIGrid obj = (UIGrid)ToLua.CheckObject(L, 1, typeof(UIGrid));

		try
		{
			obj.ConstrainWithinPanel();
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
	static int get_arrangement(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		UIGrid.Arrangement ret;

		try
		{
			ret = obj.arrangement;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index arrangement on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sorting(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		UIGrid.Sorting ret;

		try
		{
			ret = obj.sorting;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index sorting on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pivot(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
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
	static int get_maxPerLine(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		int ret;

		try
		{
			ret = obj.maxPerLine;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index maxPerLine on a nil value" : e.Message);
		}

		LuaDLL.lua_pushinteger(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cellWidth(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.cellWidth;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index cellWidth on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cellHeight(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.cellHeight;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index cellHeight on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animateSmoothly(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.animateSmoothly;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index animateSmoothly on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hideInactive(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.hideInactive;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index hideInactive on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_keepWithinPanel(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.keepWithinPanel;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index keepWithinPanel on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onReposition(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		UIGrid.OnReposition ret = null;

		try
		{
			ret = obj.onReposition;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index onReposition on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onCustomSort(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		System.Comparison<UnityEngine.Transform> ret = null;

		try
		{
			ret = obj.onCustomSort;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index onCustomSort on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_arrangement(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		UIGrid.Arrangement arg0 = (UIGrid.Arrangement)ToLua.CheckObject(L, 2, typeof(UIGrid.Arrangement));

		try
		{
			obj.arrangement = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index arrangement on a nil value");
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
	static int set_sorting(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		UIGrid.Sorting arg0 = (UIGrid.Sorting)ToLua.CheckObject(L, 2, typeof(UIGrid.Sorting));

		try
		{
			obj.sorting = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index sorting on a nil value");
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
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
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
	static int set_maxPerLine(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.maxPerLine = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index maxPerLine on a nil value");
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
	static int set_cellWidth(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.cellWidth = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index cellWidth on a nil value");
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
	static int set_cellHeight(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.cellHeight = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index cellHeight on a nil value");
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
	static int set_animateSmoothly(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.animateSmoothly = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index animateSmoothly on a nil value");
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
	static int set_hideInactive(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.hideInactive = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index hideInactive on a nil value");
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
	static int set_keepWithinPanel(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.keepWithinPanel = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index keepWithinPanel on a nil value");
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
	static int set_onReposition(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		UIGrid.OnReposition arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (UIGrid.OnReposition)ToLua.CheckObject(L, 2, typeof(UIGrid.OnReposition));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 2);
			arg0 = DelegateFactory.CreateDelegate(L, typeof(UIGrid.OnReposition), func) as UIGrid.OnReposition;
		}

		try
		{
			obj.onReposition = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index onReposition on a nil value");
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
	static int set_onCustomSort(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		System.Comparison<UnityEngine.Transform> arg0 = null;
		LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

		if (funcType2 != LuaTypes.LUA_TFUNCTION)
		{
			 arg0 = (System.Comparison<UnityEngine.Transform>)ToLua.CheckObject(L, 2, typeof(System.Comparison<UnityEngine.Transform>));
		}
		else
		{
			LuaFunction func = ToLua.ToLuaFunction(L, 2);
			arg0 = DelegateFactory.CreateDelegate(L, typeof(System.Comparison<UnityEngine.Transform>), func) as System.Comparison<UnityEngine.Transform>;
		}

		try
		{
			obj.onCustomSort = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index onCustomSort on a nil value");
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
	static int set_repositionNow(IntPtr L)
	{
		UIGrid obj = (UIGrid)ToLua.ToObject(L, 1);
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);

		try
		{
			obj.repositionNow = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index repositionNow on a nil value");
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
		ToLua.PushOut<UIGrid>(L, new LuaOut<UIGrid>());
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnReposition(IntPtr L)
	{
		LuaFunction func = ToLua.CheckLuaFunction(L, 1);
		Delegate arg1 = DelegateFactory.CreateDelegate(L, typeof(UIGrid.OnReposition), func);
		ToLua.Push(L, arg1);
		return 1;
	}
}

