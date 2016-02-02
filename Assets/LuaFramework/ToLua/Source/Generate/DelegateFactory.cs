using System;
using System.Collections.Generic;
using LuaInterface;

public static class DelegateFactory
{
	delegate Delegate DelegateValue(LuaFunction func);
	static Dictionary<Type, DelegateValue> dict = new Dictionary<Type, DelegateValue>();

	static DelegateFactory()
	{
		Register();
	}

	[NoToLuaAttribute]
	public static void Register()
	{
		dict.Clear();
		dict.Add(typeof(System.Action), System_Action);
		dict.Add(typeof(System.Action<UnityEngine.GameObject>), System_Action_UnityEngine_GameObject);
		dict.Add(typeof(UnityEngine.Events.UnityAction), UnityEngine_Events_UnityAction);
		dict.Add(typeof(TestEventListener.OnClick), TestEventListener_OnClick);
		dict.Add(typeof(TestEventListener.VoidDelegate), TestEventListener_VoidDelegate);
		dict.Add(typeof(UnityEngine.Camera.CameraCallback), UnityEngine_Camera_CameraCallback);
		dict.Add(typeof(UnityEngine.AudioClip.PCMReaderCallback), UnityEngine_AudioClip_PCMReaderCallback);
		dict.Add(typeof(UnityEngine.AudioClip.PCMSetPositionCallback), UnityEngine_AudioClip_PCMSetPositionCallback);
		dict.Add(typeof(UnityEngine.Application.LogCallback), UnityEngine_Application_LogCallback);
		dict.Add(typeof(UnityEngine.Application.AdvertisingIdentifierCallback), UnityEngine_Application_AdvertisingIdentifierCallback);
		dict.Add(typeof(UIPanel.OnGeometryUpdated), UIPanel_OnGeometryUpdated);
		dict.Add(typeof(UIPanel.OnClippingMoved), UIPanel_OnClippingMoved);
		dict.Add(typeof(UIWidget.OnDimensionsChanged), UIWidget_OnDimensionsChanged);
		dict.Add(typeof(UIWidget.OnPostFillCallback), UIWidget_OnPostFillCallback);
		dict.Add(typeof(UIDrawCall.OnRenderCallback), UIDrawCall_OnRenderCallback);
		dict.Add(typeof(UIWidget.HitCheck), UIWidget_HitCheck);
		dict.Add(typeof(UIGrid.OnReposition), UIGrid_OnReposition);
		dict.Add(typeof(System.Comparison<UnityEngine.Transform>), System_Comparison_UnityEngine_Transform);
		dict.Add(typeof(System.Action<NotiData>), System_Action_NotiData);
	}

    [NoToLuaAttribute]
    public static Delegate CreateDelegate(IntPtr L, Type t, LuaFunction func = null)
    {
        DelegateValue create = null;

        if (!dict.TryGetValue(t, out create))
        {
            LuaDLL.luaL_error(L, string.Format("Delegate {0} not register", LuaMisc.GetTypeName(t)));
            return null;
        }
        
        return create(func);        
    }
    
	class System_Action_Event : LuaDelegate
	{
		public System_Action_Event(LuaFunction func) : base(func) { }

		public void Call()
		{
			func.Call();
		}
	}

	public static Delegate System_Action(LuaFunction func)
	{
		if (func == null)
		{
			System.Action fn = delegate { };
			return fn;
		}

		System.Action d = (new System_Action_Event(func)).Call;
		return d;
	}

	class System_Action_UnityEngine_GameObject_Event : LuaDelegate
	{
		public System_Action_UnityEngine_GameObject_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.GameObject param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate System_Action_UnityEngine_GameObject(LuaFunction func)
	{
		if (func == null)
		{
			System.Action<UnityEngine.GameObject> fn = delegate { };
			return fn;
		}

		System.Action<UnityEngine.GameObject> d = (new System_Action_UnityEngine_GameObject_Event(func)).Call;
		return d;
	}

	class UnityEngine_Events_UnityAction_Event : LuaDelegate
	{
		public UnityEngine_Events_UnityAction_Event(LuaFunction func) : base(func) { }

		public void Call()
		{
			func.Call();
		}
	}

	public static Delegate UnityEngine_Events_UnityAction(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Events.UnityAction fn = delegate { };
			return fn;
		}

		UnityEngine.Events.UnityAction d = (new UnityEngine_Events_UnityAction_Event(func)).Call;
		return d;
	}

	class TestEventListener_OnClick_Event : LuaDelegate
	{
		public TestEventListener_OnClick_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.GameObject param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate TestEventListener_OnClick(LuaFunction func)
	{
		if (func == null)
		{
			TestEventListener.OnClick fn = delegate { };
			return fn;
		}

		TestEventListener.OnClick d = (new TestEventListener_OnClick_Event(func)).Call;
		return d;
	}

	class TestEventListener_VoidDelegate_Event : LuaDelegate
	{
		public TestEventListener_VoidDelegate_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.GameObject param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate TestEventListener_VoidDelegate(LuaFunction func)
	{
		if (func == null)
		{
			TestEventListener.VoidDelegate fn = delegate { };
			return fn;
		}

		TestEventListener.VoidDelegate d = (new TestEventListener_VoidDelegate_Event(func)).Call;
		return d;
	}

	class UnityEngine_Camera_CameraCallback_Event : LuaDelegate
	{
		public UnityEngine_Camera_CameraCallback_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.Camera param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_Camera_CameraCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Camera.CameraCallback fn = delegate { };
			return fn;
		}

		UnityEngine.Camera.CameraCallback d = (new UnityEngine_Camera_CameraCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_AudioClip_PCMReaderCallback_Event : LuaDelegate
	{
		public UnityEngine_AudioClip_PCMReaderCallback_Event(LuaFunction func) : base(func) { }

		public void Call(float[] param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_AudioClip_PCMReaderCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.AudioClip.PCMReaderCallback fn = delegate { };
			return fn;
		}

		UnityEngine.AudioClip.PCMReaderCallback d = (new UnityEngine_AudioClip_PCMReaderCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_AudioClip_PCMSetPositionCallback_Event : LuaDelegate
	{
		public UnityEngine_AudioClip_PCMSetPositionCallback_Event(LuaFunction func) : base(func) { }

		public void Call(int param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_AudioClip_PCMSetPositionCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.AudioClip.PCMSetPositionCallback fn = delegate { };
			return fn;
		}

		UnityEngine.AudioClip.PCMSetPositionCallback d = (new UnityEngine_AudioClip_PCMSetPositionCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_Application_LogCallback_Event : LuaDelegate
	{
		public UnityEngine_Application_LogCallback_Event(LuaFunction func) : base(func) { }

		public void Call(string param0,string param1,UnityEngine.LogType param2)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.Push(param2);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_Application_LogCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Application.LogCallback fn = delegate { };
			return fn;
		}

		UnityEngine.Application.LogCallback d = (new UnityEngine_Application_LogCallback_Event(func)).Call;
		return d;
	}

	class UnityEngine_Application_AdvertisingIdentifierCallback_Event : LuaDelegate
	{
		public UnityEngine_Application_AdvertisingIdentifierCallback_Event(LuaFunction func) : base(func) { }

		public void Call(string param0,bool param1,string param2)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.Push(param2);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UnityEngine_Application_AdvertisingIdentifierCallback(LuaFunction func)
	{
		if (func == null)
		{
			UnityEngine.Application.AdvertisingIdentifierCallback fn = delegate { };
			return fn;
		}

		UnityEngine.Application.AdvertisingIdentifierCallback d = (new UnityEngine_Application_AdvertisingIdentifierCallback_Event(func)).Call;
		return d;
	}

	class UIPanel_OnGeometryUpdated_Event : LuaDelegate
	{
		public UIPanel_OnGeometryUpdated_Event(LuaFunction func) : base(func) { }

		public void Call()
		{
			func.Call();
		}
	}

	public static Delegate UIPanel_OnGeometryUpdated(LuaFunction func)
	{
		if (func == null)
		{
			UIPanel.OnGeometryUpdated fn = delegate { };
			return fn;
		}

		UIPanel.OnGeometryUpdated d = (new UIPanel_OnGeometryUpdated_Event(func)).Call;
		return d;
	}

	class UIPanel_OnClippingMoved_Event : LuaDelegate
	{
		public UIPanel_OnClippingMoved_Event(LuaFunction func) : base(func) { }

		public void Call(UIPanel param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UIPanel_OnClippingMoved(LuaFunction func)
	{
		if (func == null)
		{
			UIPanel.OnClippingMoved fn = delegate { };
			return fn;
		}

		UIPanel.OnClippingMoved d = (new UIPanel_OnClippingMoved_Event(func)).Call;
		return d;
	}

	class UIWidget_OnDimensionsChanged_Event : LuaDelegate
	{
		public UIWidget_OnDimensionsChanged_Event(LuaFunction func) : base(func) { }

		public void Call()
		{
			func.Call();
		}
	}

	public static Delegate UIWidget_OnDimensionsChanged(LuaFunction func)
	{
		if (func == null)
		{
			UIWidget.OnDimensionsChanged fn = delegate { };
			return fn;
		}

		UIWidget.OnDimensionsChanged d = (new UIWidget_OnDimensionsChanged_Event(func)).Call;
		return d;
	}

	class UIWidget_OnPostFillCallback_Event : LuaDelegate
	{
		public UIWidget_OnPostFillCallback_Event(LuaFunction func) : base(func) { }

		public void Call(UIWidget param0,int param1,BetterList<UnityEngine.Vector3> param2,BetterList<UnityEngine.Vector2> param3,BetterList<UnityEngine.Color32> param4)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.PushObject(param2);
			func.PushObject(param3);
			func.PushObject(param4);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UIWidget_OnPostFillCallback(LuaFunction func)
	{
		if (func == null)
		{
			UIWidget.OnPostFillCallback fn = delegate { };
			return fn;
		}

		UIWidget.OnPostFillCallback d = (new UIWidget_OnPostFillCallback_Event(func)).Call;
		return d;
	}

	class UIDrawCall_OnRenderCallback_Event : LuaDelegate
	{
		public UIDrawCall_OnRenderCallback_Event(LuaFunction func) : base(func) { }

		public void Call(UnityEngine.Material param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate UIDrawCall_OnRenderCallback(LuaFunction func)
	{
		if (func == null)
		{
			UIDrawCall.OnRenderCallback fn = delegate { };
			return fn;
		}

		UIDrawCall.OnRenderCallback d = (new UIDrawCall_OnRenderCallback_Event(func)).Call;
		return d;
	}

	class UIWidget_HitCheck_Event : LuaDelegate
	{
		public UIWidget_HitCheck_Event(LuaFunction func) : base(func) { }

		public bool Call(UnityEngine.Vector3 param0)
		{
			func.BeginPCall();
			func.Push(param0);
			func.PCall();
			bool ret = func.CheckBoolean();
			func.EndPCall();
			return ret;
		}
	}

	public static Delegate UIWidget_HitCheck(LuaFunction func)
	{
		if (func == null)
		{
			UIWidget.HitCheck fn = delegate { return false; };
			return fn;
		}

		UIWidget.HitCheck d = (new UIWidget_HitCheck_Event(func)).Call;
		return d;
	}

	class UIGrid_OnReposition_Event : LuaDelegate
	{
		public UIGrid_OnReposition_Event(LuaFunction func) : base(func) { }

		public void Call()
		{
			func.Call();
		}
	}

	public static Delegate UIGrid_OnReposition(LuaFunction func)
	{
		if (func == null)
		{
			UIGrid.OnReposition fn = delegate { };
			return fn;
		}

		UIGrid.OnReposition d = (new UIGrid_OnReposition_Event(func)).Call;
		return d;
	}

	class System_Comparison_UnityEngine_Transform_Event : LuaDelegate
	{
		public System_Comparison_UnityEngine_Transform_Event(LuaFunction func) : base(func) { }

		public int Call(UnityEngine.Transform param0,UnityEngine.Transform param1)
		{
			func.BeginPCall();
			func.Push(param0);
			func.Push(param1);
			func.PCall();
			int ret = (int)func.CheckNumber();
			func.EndPCall();
			return ret;
		}
	}

	public static Delegate System_Comparison_UnityEngine_Transform(LuaFunction func)
	{
		if (func == null)
		{
			System.Comparison<UnityEngine.Transform> fn = delegate { return 0; };
			return fn;
		}

		System.Comparison<UnityEngine.Transform> d = (new System_Comparison_UnityEngine_Transform_Event(func)).Call;
		return d;
	}

	class System_Action_NotiData_Event : LuaDelegate
	{
		public System_Action_NotiData_Event(LuaFunction func) : base(func) { }

		public void Call(NotiData param0)
		{
			func.BeginPCall();
			func.PushObject(param0);
			func.PCall();
			func.EndPCall();
		}
	}

	public static Delegate System_Action_NotiData(LuaFunction func)
	{
		if (func == null)
		{
			System.Action<NotiData> fn = delegate { };
			return fn;
		}

		System.Action<NotiData> d = (new System_Action_NotiData_Event(func)).Call;
		return d;
	}

}

