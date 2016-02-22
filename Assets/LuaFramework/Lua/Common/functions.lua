
--输出日志--
function log(str)
    Util.Log(str)
end

--错误日志--
function logError(str) 
	Util.LogError(str)
end

--警告日志--
function logWarn(str) 
	Util.LogWarning(str)
end

--查找对象--
function find(str)
	return GameObject.Find(str)
end

function destroy(obj)
	GameObject.Destroy(obj)
end

function newObject(prefab)
	return GameObject.Instantiate(prefab)
end

--创建面板--
function createPanel(name)
	panelMgr:CreatePanel(name)
end

function child(str)
	return transform:FindChild(str)
end

function subGet(childNode, typeName)		
	return child(childNode):GetComponent(typeName)
end

function findPanel(str) 
	local obj = find(str)
	if obj == nil then
		error(str.." is null")
		return nil
	end
	return obj:GetComponent("BaseLua")
end

function clone(object)
    local lookup_table = {}
    local function _copy(object)
        if type(object) ~= "table" then
            return object
        elseif lookup_table[object] then
            return lookup_table[object]
        end
        local new_table = {}
        lookup_table[object] = new_table
        for key, value in pairs(object) do
            new_table[_copy(key)] = _copy(value)
        end
        return setmetatable(new_table, getmetatable(object))
    end
    return _copy(object)
end

function class(classname, super)
    local superType = type(super)
    local cls

    if superType ~= "function" and superType ~= "table" then
        superType = nil
        super = nil
    end

    if superType == "function" or (super and super.__ctype == 1) then
        -- inherited from native C++ Object
        cls = {}

        if superType == "table" then
            -- copy fields from super
            for k,v in pairs(super) do cls[k] = v end
            cls.__create = super.__create
            cls.super    = super
        else
            cls.__create = super
        end

        cls.ctor    = function() end
        cls.__cname = classname
        cls.__ctype = 1

        function cls.new(...)
            local instance = cls.__create(...)
            -- copy fields from class to native object
            for k,v in pairs(cls) do instance[k] = v end
            instance.class = cls
            instance:ctor(...)
            return instance
        end

    else
        -- inherited from Lua Object
        if super then
            cls = clone(super)
            cls.super = super
        else
            cls = {ctor = function() end}
        end

        cls.__cname = classname
        cls.__ctype = 2 -- lua
        cls.__index = cls

        function cls.new(...)
            local instance = setmetatable({}, cls)
            instance.class = cls
            instance:ctor(...)
            return instance
        end
    end

    return cls
end