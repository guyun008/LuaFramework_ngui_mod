local transform
local gameObject

local MessagePanel = {}
local this = MessagePanel

function MessagePanel.New()
	return this
end

--启动事件--
function MessagePanel.Awake(obj)
	gameObject = obj
	transform = obj.transform

	this.InitPanel()
	logWarn("Awake lua--->>"..gameObject.name)
end

--初始化面板--
function MessagePanel.InitPanel()
	this.btnClose = transform:FindChild("Button").gameObject
end

--单击事件--
function MessagePanel.OnDestroy()
	logWarn("OnDestroy---->>>")
end

return MessagePanel