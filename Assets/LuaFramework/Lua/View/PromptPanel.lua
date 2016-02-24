local PromptPanel = class("PromptPanel",require("View.BasePanel"))

function PromptPanel:ctor()
	self.super.ctor(self,"Prompt")
end

--初始化面板--
function PromptPanel:InitPanel()
	self.super:InitPanel()
	self.btnOpen = self.transform:FindChild("Open").gameObject
	self.gridParent = self.transform:FindChild('ScrollView/Grid')
end

function PromptPanel:OnDestroy()
	log("PromptPanel:OnDestroy---")
	self.super:OnDestroy()
	-- to do
	self.btnOpen = nil
	self.gridParent = nil
	log("PromptPanel:OnDestroy")
end

return PromptPanel