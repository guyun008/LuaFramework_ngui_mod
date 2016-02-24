local PromptCtrl = class("PromptCtrl",require("Controller.BaseCtrl"))

function PromptCtrl:ctor()
	self.super.ctor(self,"Prompt") -- 一定用点调用
	self.panel = nil
	self.prompt = nil
	self.transform = nil
	self.gameObject = nil
    self.promptPanel = require("View.PromptPanel"):new("PromptPanel")
end

function PromptCtrl:OnCreate( obj )
	log(table.tostring(self))
	self.promptPanel:Awake(obj)
	self.gameObject = obj
	self.transform = obj.transform

	self.panel = self.transform:GetComponent('UIPanel')
	self.prompt = self.transform:GetComponent('LuaBehaviour')
	logWarn("Start lua--->>"..self.gameObject.name)

	self:InitPanel()	--初始化面板--
	self.prompt:AddClick(self.promptPanel.btnOpen, self.OnClick)
end

--初始化面板--
function PromptCtrl:InitPanel()
	self.panel.depth = 1	--设置纵深--
	local parent = self.promptPanel.gridParent
	local itemPrefab = self.prompt:LoadAsset('PromptItem')
	for i = 1, 100 do
		local go = newObject(itemPrefab)
		go.name = tostring(i)
		go.transform.parent = parent
		go.transform.localScale = Vector3.one
		go.transform.localPosition = Vector3.zero
		self.prompt:AddClick(go, self.OnItemClick)

		local goo = go.transform:FindChild('Label')
		goo:GetComponent('UILabel').text = i
	end
	local grid = parent:GetComponent('UIGrid')
	grid:Reposition()
	grid.repositionNow = true
	parent:GetComponent('WrapGrid'):InitGrid()
end

--滚动项单击事件--
function PromptCtrl:OnItemClick(go)
	log(go.name)
end

--单击事件--
function PromptCtrl:OnClick(go)

	logWarn("OnClick---->>>"..go.name)
end

--关闭事件--
function PromptCtrl:Close()
    log("PromptCtrl.Close")
    --PanelManager  cstolua 对象
    self.promptPanel:OnDestroy()
    self.super:Close()
	self.panel = nil
	self.prompt = nil
	self.transform = nil
	self.gameObject = nil
    self.promptPanel = nil
end

return PromptCtrl