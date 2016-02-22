local BasePanel = class("BasePanel")

function BasePanel:Awake(obj)
	self.gameObject = obj
	self.transform = obj.transform
	self:InitPanel()
	logWarn("Awake lua--->>"..self.gameObject.name)
end

function BasePanel:InitPanel()
	
end

function BasePanel:OnDestroy()
	
end

return BasePanel