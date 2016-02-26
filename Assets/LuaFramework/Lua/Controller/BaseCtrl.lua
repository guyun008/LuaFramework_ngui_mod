local BaseCtrl = class("BaseCtrl")

function BaseCtrl:ctor( name )
	self.name = name
end

function BaseCtrl:Awake()
	logWarn("PromptCtrl.Awake--->>")
	panelMgr:CreatePanel(self.name, self.OnCreate,self)
end

function BaseCtrl:InitPanel( ... )
	-- body
end

function BaseCtrl:OnDestroy()
	self.name = nil
end
return BaseCtrl