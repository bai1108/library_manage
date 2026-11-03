# 基于虹膜识别的图书借阅管理系统

使用 C# Windows Forms 和 SQL Server 开发的课程项目，包含读者管理、书目与馆藏复本管理、借还续借、借阅查询、管理员账户和系统设置。

## 开发环境

- Visual Studio 2015
- .NET Framework 4.5.2
- SQL Server 2016
- Windows 身份验证连接数据库

## 项目结构

```text
Library_manage.sln                 解决方案
Library_manage/
  Library_manage.csproj            WinForms 项目
  App.config                       数据库连接配置
  Database.cs                      数据库访问、密码验证与借还事务
  ReaderLoginForm.cs                读者入口
  AdminLoginForm.cs                 管理员登录
  BorrowForm.cs                     借还续借
  ManageForm.cs                     管理窗口
  Views/                           各管理页面
  Assets/                          界面图片
数据库/
  图书管理系统建表.sql              7张主要数据表及约束
```

各窗体主 `.cs` 文件包含事件和数据绑定逻辑，`.Designer.cs` 与 `.resx` 用于界面设计。项目保留两个旧绑定文件作为兼容占位，业务实现位于对应窗体主文件。

## 运行方法

1. 下载项目，用 Visual Studio 打开 `Library_manage.sln`。
2. 在 SQL Server 中准备数据库 `DoorAccess2026`，执行 `数据库/图书管理系统建表.sql`。脚本中的 `USE` 指定了该数据库；如使用其他名称，应先修改脚本和连接配置。
3. 修改 `Library_manage/App.config` 中的服务器名称。当前配置为服务器 `BAI`、数据库 `DoorAccess2026`、Windows 身份验证。
4. 重新生成解决方案并运行。管理员登录使用 `Admin` 表中的有效账户。本机账户数据不包含在此仓库中，在其他环境运行时需要自行建立管理员账户；密码字段保存随机盐与PBKDF2派生值，不是明文。
5. 在读者管理新增档案，在图书管理新增书目和复本；选择读者并核对身份后，通过“核验后借还”办理业务。

## 主要功能

- 读者档案查询、新增、修改、停用与恢复。
- 书目和馆藏复本分别管理，复本条码唯一。
- 借书、还书和续借，业务记录、复本状态与日志通过事务保存。
- 借阅明细查询、事件统计和CSV导出。
- 管理员密码验证、角色权限及账户维护。
- 本机用户借阅规则保存及数据库连接测试。
- 虹膜注册页面读取读者与已有模板的注册状态。

## 虹膜设备状态

目前未接入虹膜设备SDK，因此不提供真实虹膜采集、模板注册写入或身份匹配。“开始虹膜识别”会显示设备支持尚未接入的提示。现阶段借还业务由管理员核验读者身份后办理。

数据库包含 `Reader`、`IrisTemplate`、`Book`、`BookCopy`、`BorrowRecord`、`Admin`、`OperationLog` 七张主要表。仓库提供源码与建表脚本，不包含本机数据库记录、管理员凭据、编译输出或VS缓存。
