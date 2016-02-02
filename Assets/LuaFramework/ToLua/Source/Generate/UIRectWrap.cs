using System;
using LuaInterface;

public class UIRectWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIRect), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("CalculateFinalAlpha", CalculateFinalAlpha);
		L.RegFunction("Invalidate", Invalidate);
		L.RegFunction("GetSides", GetSides);
		L.RegFunction("Update", Update);
		L.RegFunction("UpdateAnchors", UpdateAnchors);
		L.RegFunction("SetAnchor", SetAnchor);
		L.RegFunction("ResetAnchors", ResetAnchors);
		L.RegFunction("ResetAndUpdateAnchors", ResetAndUpdateAnchors);
		L.RegFunction("SetRect", SetRect);
		L.RegFunction("ParentHasChanged", ParentHasChanged);
		L.RegFunction("New", _CreateUIRect);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("leftAnchor", get_leftAnchor, set_leftAnchor);
		L.RegVar("rightAnchor", get_rightAnchor, set_rightAnchor);
		L.RegVar("bottomAnchor", get_bottomAnchor, set_bottomAnchor);
		L.RegVar("topAnchor", get_topAnchor, set_topAnchor);
		L.RegVar("updateAnchors", get_updateAnchors, set_updateAnchors);
		L.RegVar("finalAlpha", get_finalAlpha, set_finalAlpha);
		L.RegVar("cachedGameObject", get_cachedGameObject, null);
		L.RegVar("cachedTransform", get_cachedTransform, null);
		L.RegVar("anchorCamera", get_anchorCamera, null);
		L.RegVar("isFullyAnchored", get_isFullyAnchored, null);
		L.RegVar("isAnchoredHorizontally", get_isAnchoredHorizontally, null);
		L.RegVar("isAnchoredVertically", get_isAnchoredVertically, null);
		L.RegVar("canBeAnchored", get_canBeAnchored, null);
		L.RegVar("parent", get_parent, null);
		L.RegVar("root", get_root, null);
		L.RegVar("isAnchored", get_isAnchored, null);
		L.RegVar("alpha", get_alpha, set_alpha);
		L.RegVar("localCorners", get_localCorners, null);
		L.RegVar("worldCorners", get_worldCorners, null);
		L.RegVar("out", get_out, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUIRect(IntPtr L)
	{
		return LuaDLL.luaL_error(L, "UIRect class does not have a constructor function");
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateFinalAlpha(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIRect obj = (UIRect)ToLua.CheckObject(L, 1, typeof(UIRect));
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
		UIRect obj = (UIRect)ToLua.CheckObject(L, 1, typeof(UIRect));
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
	static int GetSides(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 2);
		UIRect obj = (UIRect)ToLua.CheckObject(L, 1, typeof(UIRect));
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
	static int Update(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIRect obj = (UIRect)ToLua.CheckObject(L, 1, typeof(UIRect));

		try
		{
			obj.Update();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateAnchors(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIRect obj = (UIRect)ToLua.CheckObject(L, 1, typeof(UIRect));

		try
		{
			obj.UpdateAnchors();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAnchor(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UIRect), typeof(UnityEngine.GameObject)))
		{
			UIRect obj = (UIRect)ToLua.ToObject(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 2);

			try
			{
				obj.SetAnchor(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			return 0;
		}
		else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(UIRect), typeof(UnityEngine.Transform)))
		{
			UIRect obj = (UIRect)ToLua.ToObject(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.ToObject(L, 2);

			try
			{
				obj.SetAnchor(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			return 0;
		}
		else if (count == 6 && ToLua.CheckTypes(L, 1, typeof(UIRect), typeof(UnityEngine.GameObject), typeof(int), typeof(int), typeof(int), typeof(int)))
		{
			UIRect obj = (UIRect)ToLua.ToObject(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 2);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
			int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
			int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
			int arg4 = (int)LuaDLL.lua_tonumber(L, 6);

			try
			{
				obj.SetAnchor(arg0, arg1, arg2, arg3, arg4);
			}
			catch(Exception e)
			{
				return LuaDLL.luaL_error(L, e.Message);
			}

			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UIRect.SetAnchor");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetAnchors(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIRect obj = (UIRect)ToLua.CheckObject(L, 1, typeof(UIRect));

		try
		{
			obj.ResetAnchors();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetAndUpdateAnchors(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIRect obj = (UIRect)ToLua.CheckObject(L, 1, typeof(UIRect));

		try
		{
			obj.ResetAndUpdateAnchors();
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, e.Message);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRect(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 5);
		UIRect obj = (UIRect)ToLua.CheckObject(L, 1, typeof(UIRect));
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
	static int ParentHasChanged(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UIRect obj = (UIRect)ToLua.CheckObject(L, 1, typeof(UIRect));

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
	static int get_leftAnchor(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect.AnchorPoint ret = null;

		try
		{
			ret = obj.leftAnchor;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index leftAnchor on a nil value" : e.Message);
		}

		ToLua.PushObject(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rightAnchor(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect.AnchorPoint ret = null;

		try
		{
			ret = obj.rightAnchor;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index rightAnchor on a nil value" : e.Message);
		}

		ToLua.PushObject(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bottomAnchor(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect.AnchorPoint ret = null;

		try
		{
			ret = obj.bottomAnchor;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index bottomAnchor on a nil value" : e.Message);
		}

		ToLua.PushObject(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_topAnchor(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect.AnchorPoint ret = null;

		try
		{
			ret = obj.topAnchor;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index topAnchor on a nil value" : e.Message);
		}

		ToLua.PushObject(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updateAnchors(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect.AnchorUpdate ret;

		try
		{
			ret = obj.updateAnchors;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index updateAnchors on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_finalAlpha(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		float ret;

		try
		{
			ret = obj.finalAlpha;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index finalAlpha on a nil value" : e.Message);
		}

		LuaDLL.lua_pushnumber(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedGameObject(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UnityEngine.GameObject ret = null;

		try
		{
			ret = obj.cachedGameObject;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index cachedGameObject on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedTransform(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UnityEngine.Transform ret = null;

		try
		{
			ret = obj.cachedTransform;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index cachedTransform on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_anchorCamera(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UnityEngine.Camera ret = null;

		try
		{
			ret = obj.anchorCamera;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index anchorCamera on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isFullyAnchored(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.isFullyAnchored;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index isFullyAnchored on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isAnchoredHorizontally(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.isAnchoredHorizontally;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index isAnchoredHorizontally on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isAnchoredVertically(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.isAnchoredVertically;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index isAnchoredVertically on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_canBeAnchored(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
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
	static int get_parent(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect ret = null;

		try
		{
			ret = obj.parent;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index parent on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_root(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRoot ret = null;

		try
		{
			ret = obj.root;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index root on a nil value" : e.Message);
		}

		ToLua.Push(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isAnchored(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		bool ret;

		try
		{
			ret = obj.isAnchored;
		}
		catch(Exception e)
		{
			return LuaDLL.luaL_error(L, obj == null ? "attempt to index isAnchored on a nil value" : e.Message);
		}

		LuaDLL.lua_pushboolean(L, ret);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alpha(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
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
	static int get_localCorners(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
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
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
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
	static int set_leftAnchor(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect.AnchorPoint arg0 = (UIRect.AnchorPoint)ToLua.CheckObject(L, 2, typeof(UIRect.AnchorPoint));

		try
		{
			obj.leftAnchor = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index leftAnchor on a nil value");
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
	static int set_rightAnchor(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect.AnchorPoint arg0 = (UIRect.AnchorPoint)ToLua.CheckObject(L, 2, typeof(UIRect.AnchorPoint));

		try
		{
			obj.rightAnchor = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index rightAnchor on a nil value");
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
	static int set_bottomAnchor(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect.AnchorPoint arg0 = (UIRect.AnchorPoint)ToLua.CheckObject(L, 2, typeof(UIRect.AnchorPoint));

		try
		{
			obj.bottomAnchor = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index bottomAnchor on a nil value");
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
	static int set_topAnchor(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect.AnchorPoint arg0 = (UIRect.AnchorPoint)ToLua.CheckObject(L, 2, typeof(UIRect.AnchorPoint));

		try
		{
			obj.topAnchor = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index topAnchor on a nil value");
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
	static int set_updateAnchors(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		UIRect.AnchorUpdate arg0 = (UIRect.AnchorUpdate)ToLua.CheckObject(L, 2, typeof(UIRect.AnchorUpdate));

		try
		{
			obj.updateAnchors = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index updateAnchors on a nil value");
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
	static int set_finalAlpha(IntPtr L)
	{
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
		float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);

		try
		{
			obj.finalAlpha = arg0;
		}
		catch(Exception e)
		{
			if (obj == null)
			{
				LuaDLL.luaL_error(L, "attempt to index finalAlpha on a nil value");
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
		UIRect obj = (UIRect)ToLua.ToObject(L, 1);
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
	static int get_out(IntPtr L)
	{
		ToLua.PushOut<UIRect>(L, new LuaOut<UIRect>());
		return 1;
	}
}

