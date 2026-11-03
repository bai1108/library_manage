-- 服务器：BAI；目标数据库：DoorAccess2026。
-- 只创建尚不存在的图书系统表，不修改原 dbo.Stu，不写入演示人员或默认密码。
-- SQL Server 2016 可执行；整批失败时回滚；可重复执行。
USE [DoorAccess2026];
SET NOCOUNT ON;
SET XACT_ABORT ON;
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
SET ANSI_PADDING ON;
SET ANSI_WARNINGS ON;
SET ARITHABORT ON;
SET CONCAT_NULL_YIELDS_NULL ON;
SET NUMERIC_ROUNDABORT OFF;
BEGIN TRY
    BEGIN TRANSACTION;

    IF OBJECT_ID(N'dbo.Admin', N'U') IS NULL
    CREATE TABLE dbo.Admin (
        AdminID int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Admin PRIMARY KEY,
        LoginName nvarchar(50) NOT NULL CONSTRAINT UQ_Admin_LoginName UNIQUE,
        DisplayName nvarchar(50) NOT NULL,
        PasswordHash varbinary(256) NOT NULL,
        PasswordSalt varbinary(64) NOT NULL,
        PasswordAlgorithm nvarchar(50) NOT NULL,
        PasswordIterations int NOT NULL,
        Role nvarchar(20) NOT NULL CONSTRAINT DF_Admin_Role DEFAULT(N'业务管理员'),
        Status nvarchar(10) NOT NULL CONSTRAINT DF_Admin_Status DEFAULT(N'正常'),
        CreatedAt datetime2(0) NOT NULL CONSTRAINT DF_Admin_CreatedAt DEFAULT(SYSDATETIME()),
        CONSTRAINT CK_Admin_LoginName CHECK(LEN(LTRIM(RTRIM(LoginName))) > 0),
        CONSTRAINT CK_Admin_DisplayName CHECK(LEN(LTRIM(RTRIM(DisplayName))) > 0),
        CONSTRAINT CK_Admin_Password CHECK(DATALENGTH(PasswordHash) > 0 AND DATALENGTH(PasswordSalt) >= 16 AND PasswordIterations > 0 AND LEN(PasswordAlgorithm) > 0),
        CONSTRAINT CK_Admin_Role CHECK(Role IN(N'系统管理员',N'业务管理员')),
        CONSTRAINT CK_Admin_Status CHECK(Status IN(N'正常',N'停用'))
    );

    IF OBJECT_ID(N'dbo.Reader', N'U') IS NULL
    CREATE TABLE dbo.Reader (
        ReaderID nvarchar(20) NOT NULL CONSTRAINT PK_Reader PRIMARY KEY,
        ReaderName nvarchar(50) NOT NULL,
        ReaderType nvarchar(20) NOT NULL CONSTRAINT DF_Reader_Type DEFAULT(N'学生'),
        ClassOrDepartment nvarchar(100) NULL,
        Phone nvarchar(30) NULL,
        ExpireDate date NULL,
        Status nvarchar(10) NOT NULL CONSTRAINT DF_Reader_Status DEFAULT(N'正常'),
        CreatedAt datetime2(0) NOT NULL CONSTRAINT DF_Reader_CreatedAt DEFAULT(SYSDATETIME()),
        UpdatedAt datetime2(0) NOT NULL CONSTRAINT DF_Reader_UpdatedAt DEFAULT(SYSDATETIME()),
        CONSTRAINT CK_Reader_ID CHECK(LEN(LTRIM(RTRIM(ReaderID))) > 0),
        CONSTRAINT CK_Reader_Name CHECK(LEN(LTRIM(RTRIM(ReaderName))) > 0),
        CONSTRAINT CK_Reader_Status CHECK(Status IN(N'正常',N'停用',N'注销'))
    );

    IF OBJECT_ID(N'dbo.IrisTemplate', N'U') IS NULL
    CREATE TABLE dbo.IrisTemplate (
        TemplateID int IDENTITY(1,1) NOT NULL CONSTRAINT PK_IrisTemplate PRIMARY KEY,
        ReaderID nvarchar(20) NOT NULL,
        EyeSide char(1) NOT NULL,
        TemplateData varbinary(max) NOT NULL,
        TemplateFormat nvarchar(100) NOT NULL,
        QualityScore decimal(5,2) NULL,
        IsActive bit NOT NULL CONSTRAINT DF_IrisTemplate_IsActive DEFAULT(1),
        RegisteredAt datetime2(0) NOT NULL CONSTRAINT DF_IrisTemplate_RegisteredAt DEFAULT(SYSDATETIME()),
        RegisteredBy int NULL,
        CONSTRAINT FK_IrisTemplate_Reader FOREIGN KEY(ReaderID) REFERENCES dbo.Reader(ReaderID),
        CONSTRAINT FK_IrisTemplate_Admin FOREIGN KEY(RegisteredBy) REFERENCES dbo.Admin(AdminID),
        CONSTRAINT CK_IrisTemplate_EyeSide CHECK(EyeSide IN('L','R')),
        CONSTRAINT CK_IrisTemplate_Data CHECK(DATALENGTH(TemplateData) > 0 AND LEN(TemplateFormat) > 0),
        CONSTRAINT CK_IrisTemplate_Quality CHECK(QualityScore IS NULL OR QualityScore BETWEEN 0 AND 100)
    );

    IF OBJECT_ID(N'dbo.Book', N'U') IS NULL
    CREATE TABLE dbo.Book (
        BookID int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Book PRIMARY KEY,
        ISBN nvarchar(20) NULL,
        BookName nvarchar(200) NOT NULL,
        Author nvarchar(100) NULL,
        Publisher nvarchar(100) NULL,
        Category nvarchar(50) NULL,
        PublishYear smallint NULL,
        CreatedAt datetime2(0) NOT NULL CONSTRAINT DF_Book_CreatedAt DEFAULT(SYSDATETIME()),
        CONSTRAINT CK_Book_Name CHECK(LEN(LTRIM(RTRIM(BookName))) > 0),
        CONSTRAINT CK_Book_Year CHECK(PublishYear IS NULL OR PublishYear BETWEEN 1000 AND 9999),
        CONSTRAINT CK_Book_ISBN CHECK(ISBN IS NULL OR LEN(LTRIM(RTRIM(ISBN))) > 0)
    );

    IF OBJECT_ID(N'dbo.BookCopy', N'U') IS NULL
    CREATE TABLE dbo.BookCopy (
        CopyID int IDENTITY(1,1) NOT NULL CONSTRAINT PK_BookCopy PRIMARY KEY,
        BookID int NOT NULL,
        Barcode nvarchar(30) NOT NULL CONSTRAINT UQ_BookCopy_Barcode UNIQUE,
        Location nvarchar(100) NULL,
        Status nvarchar(10) NOT NULL CONSTRAINT DF_BookCopy_Status DEFAULT(N'可借'),
        EntryDate date NOT NULL CONSTRAINT DF_BookCopy_EntryDate DEFAULT(CONVERT(date,GETDATE())),
        CONSTRAINT FK_BookCopy_Book FOREIGN KEY(BookID) REFERENCES dbo.Book(BookID),
        CONSTRAINT CK_BookCopy_Barcode CHECK(LEN(LTRIM(RTRIM(Barcode))) > 0),
        CONSTRAINT CK_BookCopy_Status CHECK(Status IN(N'可借',N'在借',N'遗失',N'停用'))
    );

    IF OBJECT_ID(N'dbo.BorrowRecord', N'U') IS NULL
    CREATE TABLE dbo.BorrowRecord (
        BorrowID bigint IDENTITY(1,1) NOT NULL CONSTRAINT PK_BorrowRecord PRIMARY KEY,
        ReaderID nvarchar(20) NOT NULL,
        CopyID int NOT NULL,
        BorrowDate datetime2(0) NOT NULL CONSTRAINT DF_BorrowRecord_BorrowDate DEFAULT(SYSDATETIME()),
        OriginalDueDate datetime2(0) NOT NULL,
        DueDate datetime2(0) NOT NULL,
        ReturnDate datetime2(0) NULL,
        RenewCount int NOT NULL CONSTRAINT DF_BorrowRecord_RenewCount DEFAULT(0),
        LastRenewAt datetime2(0) NULL,
        Status nvarchar(10) NOT NULL CONSTRAINT DF_BorrowRecord_Status DEFAULT(N'借出'),
        LostAt datetime2(0) NULL,
        ClosedAt datetime2(0) NULL,
        ResolutionNote nvarchar(500) NULL,
        BorrowAdminID int NULL,
        ReturnAdminID int NULL,
        CONSTRAINT FK_BorrowRecord_Reader FOREIGN KEY(ReaderID) REFERENCES dbo.Reader(ReaderID),
        CONSTRAINT FK_BorrowRecord_Copy FOREIGN KEY(CopyID) REFERENCES dbo.BookCopy(CopyID),
        CONSTRAINT FK_BorrowRecord_BorrowAdmin FOREIGN KEY(BorrowAdminID) REFERENCES dbo.Admin(AdminID),
        CONSTRAINT FK_BorrowRecord_ReturnAdmin FOREIGN KEY(ReturnAdminID) REFERENCES dbo.Admin(AdminID),
        CONSTRAINT CK_BorrowRecord_Dates CHECK(OriginalDueDate > BorrowDate AND DueDate >= OriginalDueDate AND (ReturnDate IS NULL OR ReturnDate >= BorrowDate) AND (ClosedAt IS NULL OR ClosedAt >= BorrowDate) AND (LostAt IS NULL OR LostAt >= BorrowDate)),
        CONSTRAINT CK_BorrowRecord_Renew CHECK(RenewCount >= 0 AND ((RenewCount=0 AND LastRenewAt IS NULL) OR (RenewCount>0 AND LastRenewAt IS NOT NULL AND LastRenewAt >= BorrowDate))),
        CONSTRAINT CK_BorrowRecord_Lifecycle CHECK(
            (Status=N'借出' AND ReturnDate IS NULL AND ClosedAt IS NULL AND LostAt IS NULL) OR
            (Status=N'已归还' AND ReturnDate IS NOT NULL AND ClosedAt IS NOT NULL AND ClosedAt >= ReturnDate) OR
            (Status=N'遗失待处理' AND ReturnDate IS NULL AND ClosedAt IS NULL AND LostAt IS NOT NULL) OR
            (Status=N'遗失已结案' AND ReturnDate IS NULL AND ClosedAt IS NOT NULL AND LostAt IS NOT NULL AND ClosedAt >= LostAt))
    );

    IF OBJECT_ID(N'dbo.OperationLog', N'U') IS NULL
    CREATE TABLE dbo.OperationLog (
        LogID bigint IDENTITY(1,1) NOT NULL CONSTRAINT PK_OperationLog PRIMARY KEY,
        AdminID int NULL,
        ReaderID nvarchar(20) NULL,
        BusinessType nvarchar(30) NOT NULL,
        EntityName nvarchar(50) NOT NULL,
        EntityID nvarchar(50) NOT NULL,
        OperationTime datetime2(0) NOT NULL CONSTRAINT DF_OperationLog_Time DEFAULT(SYSDATETIME()),
        BeforeValue nvarchar(max) NULL,
        AfterValue nvarchar(max) NULL,
        Result nvarchar(10) NOT NULL CONSTRAINT DF_OperationLog_Result DEFAULT(N'成功'),
        Remark nvarchar(500) NULL,
        CONSTRAINT FK_OperationLog_Admin FOREIGN KEY(AdminID) REFERENCES dbo.Admin(AdminID),
        CONSTRAINT FK_OperationLog_Reader FOREIGN KEY(ReaderID) REFERENCES dbo.Reader(ReaderID),
        CONSTRAINT CK_OperationLog_Result CHECK(Result IN(N'成功',N'失败')),
        CONSTRAINT CK_OperationLog_Object CHECK(LEN(BusinessType)>0 AND LEN(EntityName)>0 AND LEN(EntityID)>0)
    );

    IF NOT EXISTS(SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID(N'dbo.IrisTemplate') AND name=N'UX_IrisTemplate_ActiveEye')
        CREATE UNIQUE INDEX UX_IrisTemplate_ActiveEye ON dbo.IrisTemplate(ReaderID,EyeSide) WHERE IsActive=1;
    IF NOT EXISTS(SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID(N'dbo.BorrowRecord') AND name=N'UX_BorrowRecord_OpenCopy')
        CREATE UNIQUE INDEX UX_BorrowRecord_OpenCopy ON dbo.BorrowRecord(CopyID) WHERE ReturnDate IS NULL AND ClosedAt IS NULL;
    IF NOT EXISTS(SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID(N'dbo.BookCopy') AND name=N'IX_BookCopy_Book')
        CREATE INDEX IX_BookCopy_Book ON dbo.BookCopy(BookID,Status);
    IF NOT EXISTS(SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID(N'dbo.BorrowRecord') AND name=N'IX_BorrowRecord_Reader')
        CREATE INDEX IX_BorrowRecord_Reader ON dbo.BorrowRecord(ReaderID,BorrowDate) INCLUDE(CopyID,DueDate,ReturnDate,Status);
    IF NOT EXISTS(SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID(N'dbo.BorrowRecord') AND name=N'IX_BorrowRecord_Due')
        CREATE INDEX IX_BorrowRecord_Due ON dbo.BorrowRecord(DueDate) INCLUDE(ReaderID,CopyID) WHERE ReturnDate IS NULL AND ClosedAt IS NULL;
    IF NOT EXISTS(SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID(N'dbo.Book') AND name=N'IX_Book_ISBN')
        CREATE INDEX IX_Book_ISBN ON dbo.Book(ISBN);
    IF NOT EXISTS(SELECT 1 FROM sys.indexes WHERE object_id=OBJECT_ID(N'dbo.OperationLog') AND name=N'IX_OperationLog_TypeTime')
        CREATE INDEX IX_OperationLog_TypeTime ON dbo.OperationLog(BusinessType,OperationTime);

    -- SSMS 中可在每张表“属性→扩展属性”查看中文用途。
    DECLARE @Names TABLE(TableName sysname, Description nvarchar(100));
    INSERT INTO @Names VALUES
        (N'Admin',N'管理员表：账户、密码派生值、角色与状态'),
        (N'Reader',N'读者表：读者编号、姓名、班级部门与档案状态'),
        (N'IrisTemplate',N'虹膜模板表：逐眼保存 SDK 特征模板并关联读者'),
        (N'Book',N'图书信息表：ISBN、书名、作者与出版社'),
        (N'BookCopy',N'馆藏复本表：每册图书的唯一条码、位置与状态'),
        (N'BorrowRecord',N'借阅记录表：借出、归还、续借与遗失处理'),
        (N'OperationLog',N'操作日志表：业务变更、操作者与操作结果');
    DECLARE @Table sysname,@Description nvarchar(100);
    DECLARE TableDescriptions CURSOR LOCAL FAST_FORWARD FOR SELECT TableName,Description FROM @Names;
    OPEN TableDescriptions;
    FETCH NEXT FROM TableDescriptions INTO @Table,@Description;
    WHILE @@FETCH_STATUS=0
    BEGIN
        IF NOT EXISTS(SELECT 1 FROM sys.extended_properties WHERE class=1 AND major_id=OBJECT_ID(N'dbo.'+@Table) AND minor_id=0 AND name=N'MS_Description')
            EXEC sys.sp_addextendedproperty @name=N'MS_Description',@value=@Description,@level0type=N'SCHEMA',@level0name=N'dbo',@level1type=N'TABLE',@level1name=@Table;
        FETCH NEXT FROM TableDescriptions INTO @Table,@Description;
    END;
    CLOSE TableDescriptions;
    DEALLOCATE TableDescriptions;
    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION;
    THROW;
END CATCH;
