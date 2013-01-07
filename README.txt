DoubanApiReader
===============

Just API Reader

要求：编写一个图形界面的应用程序，能够利用豆瓣网站的API，查询和显示图书的信息

具体任务：
1. 访问豆瓣网站开发者页面，了解豆瓣V2 API的内容
2. 学习JSON格式，了解JSON格式的标准；利用你熟悉的语言(Python/Java等)，学习解析JSON格式的数据
3. 学习HTTP协议，了解HTTP协议的标准；利用你熟悉的语言(Python/Java等)，学习如何完成一个HTTP请求
4. 学习WxPython开发工具，编写GUI程序；或其它你熟悉的语言
5. 了解Git源代码管理工具；学习使用GitHub网站提供的代码托管服务管理你的源代码

作业要求：将源代码提交到GitHub的自己帐号的项目中；将项目地址发邮件到rudeyyao@gmail.com。


完成过程：
第一步：GetDataSource.cs类，用来通过HTTP协议从网络获取json文件，并通过文件流操作将json转化为string类型返回

第二步：通过c#语言在visual studio 2010上画图形界面

第三步：引用"using Newtonsoft.Json.Linq;"，使用JObject来解析返回的string类型的json文件，获取符合关键字"q"的所有图书
        遍历文件获取图书信息，将内容添加带List<Boos>集合上，并绑定到datagridview.显示在窗体上；

第四步：通过传参数（图书的API），获取每本图书的信息，并显示在WinForm窗体上。

第五步：修改程序，使用多线程和委托技术，防止在获取大量数据时候界面卡死情况。

第六步：基本实现课程设计的基本要求。