local BasePanel = class("BasePanel")

function BasePanel:ctor(name)
	self.name = name
	log("PanelName:  "..self.name)
	-- To overwrite....
end

function BasePanel:Awake(obj)
	self.gameObject = obj
	self.transform = obj.transform
	self:InitPanel()
	logWarn("Awake lua--->>"..self.name)
end

function BasePanel:InitPanel()
	-- To overwrite....
end

function BasePanel:OnDestroy()
	self.gameObject = nil
	self.transform = nil
end

return BasePanel