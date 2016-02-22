local PromptPanel = class("PromptPanel",require("View.BasePanel"))

--初始化面板--
function PromptPanel:InitPanel()
	self.btnOpen = self.transform:FindChild("Open").gameObject
	self.gridParent = self.transform:FindChild('ScrollView/Grid')
end

return PromptPanel