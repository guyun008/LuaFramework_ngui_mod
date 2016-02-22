本工程基于：https://github.com/jarjin/LuaFramework_NGUI 感谢ulua作者
修改的点主要有：
	(1)网络：修改为线程处理
	(2)lua层： Controller 和 View 模块 修改为 local方式
	(3)lua层：protocol定义id方式改为table，提高检索效率
	(4)lua层：添加panel基类
修改的bug:
	(1)网络连接失败消息重发bug
本人QQ：1635761637 欢迎大神指正.