
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/19/2014 17:43:14
-- Generated from EDMX file: C:\Users\Heroo\Documents\GitHub\UcasProject\UcasProjectManagement\Ucas.Data\UcasPro.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [UcasPro];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AmountsReceived_TheFinancerProjects]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AmountsReceiveds] DROP CONSTRAINT [FK_AmountsReceived_TheFinancerProjects];
GO
IF OBJECT_ID(N'[dbo].[FK_Attachments_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Attachments] DROP CONSTRAINT [FK_Attachments_ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_Contracts_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contracts] DROP CONSTRAINT [FK_Contracts_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_Contracts_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contracts] DROP CONSTRAINT [FK_Contracts_ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_Salaries_Contracts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Salaries] DROP CONSTRAINT [FK_Salaries_Contracts];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersTb_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersTbs] DROP CONSTRAINT [FK_UsersTb_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_PeremissionsTb_GroupsTb]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PeremissionsTbs] DROP CONSTRAINT [FK_PeremissionsTb_GroupsTb];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersTb_GroupsTb]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsersTbs] DROP CONSTRAINT [FK_UsersTb_GroupsTb];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectSubActivities_ProjectActivities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectSubActivities] DROP CONSTRAINT [FK_ProjectSubActivities_ProjectActivities];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectControl_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectControls] DROP CONSTRAINT [FK_ProjectControl_ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectControl_UsersTb]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectControls] DROP CONSTRAINT [FK_ProjectControl_UsersTb];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectExpenses_ProjectSubActivities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_ProjectExpenses_ProjectSubActivities];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectExpenses_Suppliers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_ProjectExpenses_Suppliers];
GO
IF OBJECT_ID(N'[dbo].[FK_TheFinancerProject_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TheFinancerProjects] DROP CONSTRAINT [FK_TheFinancerProject_ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_TheFinancerProject_Thefinanciers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TheFinancerProjects] DROP CONSTRAINT [FK_TheFinancerProject_Thefinanciers];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AmountsReceiveds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AmountsReceiveds];
GO
IF OBJECT_ID(N'[dbo].[Attachments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Attachments];
GO
IF OBJECT_ID(N'[dbo].[Contracts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contracts];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[GroupsTbs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GroupsTbs];
GO
IF OBJECT_ID(N'[dbo].[PeremissionsTbs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PeremissionsTbs];
GO
IF OBJECT_ID(N'[dbo].[ProjectActivities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectActivities];
GO
IF OBJECT_ID(N'[dbo].[ProjectControls]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectControls];
GO
IF OBJECT_ID(N'[dbo].[ProjectExpenses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectExpenses];
GO
IF OBJECT_ID(N'[dbo].[ProjectProfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[ProjectSubActivities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectSubActivities];
GO
IF OBJECT_ID(N'[dbo].[Salaries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Salaries];
GO
IF OBJECT_ID(N'[dbo].[Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suppliers];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TheFinancerProjects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TheFinancerProjects];
GO
IF OBJECT_ID(N'[dbo].[Thefinanciers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Thefinanciers];
GO
IF OBJECT_ID(N'[dbo].[UsersTbs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersTbs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AmountsReceiveds'
CREATE TABLE [dbo].[AmountsReceiveds] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [TheFinancerProjectsID] int  NULL,
    [Date] datetime  NULL,
    [Cost] float  NULL
);
GO

-- Creating table 'Attachments'
CREATE TABLE [dbo].[Attachments] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [AttachmentName] nvarchar(max)  NULL,
    [CreateDate] datetime  NULL,
    [fileContent] varbinary(max)  NULL,
    [ProjectProfile_ID] int  NOT NULL
);
GO

-- Creating table 'Contracts'
CREATE TABLE [dbo].[Contracts] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Employee_ID] int  NOT NULL,
    [StartDate] nchar(10)  NULL,
    [EndDate] nchar(10)  NULL,
    [SelaryAmount] nchar(10)  NULL,
    [Status] nchar(10)  NULL,
    [ProjectProfile_ID] int  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [EmployeeName] nvarchar(max)  NULL,
    [EmployeejobNumber] nvarchar(max)  NULL,
    [EmployeeGender] nvarchar(max)  NULL,
    [EmployeeNationalNumber] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [Mobilenumber] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL
);
GO

-- Creating table 'GroupsTbs'
CREATE TABLE [dbo].[GroupsTbs] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [GroupName] nvarchar(50)  NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'PeremissionsTbs'
CREATE TABLE [dbo].[PeremissionsTbs] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [GroupID] int  NULL,
    [AddUser] int  NULL,
    [UpDateUser] int  NULL,
    [DeleteUser] int  NULL,
    [AddProject] int  NULL,
    [DisplayExpenses] int  NULL,
    [CanPrint] int  NULL,
    [AddEmployee] int  NULL,
    [AddSuppliers] int  NULL,
    [AddFinncers] int  NULL,
    [EditEmployee] int  NULL,
    [DeleteEmployee] int  NULL,
    [EditFinncers] int  NULL,
    [DeleteFinncers] int  NULL,
    [EditSuppliers] int  NULL,
    [DeleteSuppliers] int  NULL
);
GO

-- Creating table 'ProjectActivities'
CREATE TABLE [dbo].[ProjectActivities] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ActivityName] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [StartDate] datetime  NULL,
    [EndDate] datetime  NULL,
    [Status] nvarchar(max)  NULL,
    [Progress] int  NULL,
    [TotalCost] float  NULL,
    [ProjectProfile_ID] int  NOT NULL
);
GO

-- Creating table 'ProjectControls'
CREATE TABLE [dbo].[ProjectControls] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [UserID] int  NULL,
    [ProjectID] int  NULL,
    [Status] nvarchar(50)  NULL
);
GO

-- Creating table 'ProjectExpenses'
CREATE TABLE [dbo].[ProjectExpenses] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ExpensesName] nvarchar(max)  NULL,
    [DateofProcess] datetime  NULL,
    [BillNumber] nvarchar(max)  NULL,
    [RequiarAmount] float  NULL,
    [CashingNumber] nvarchar(max)  NULL,
    [ProjectSubActivity_ID] int  NULL,
    [Supplier_ID] int  NULL
);
GO

-- Creating table 'ProjectProfiles'
CREATE TABLE [dbo].[ProjectProfiles] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProjectName] nvarchar(max)  NULL,
    [ProjectDescription] nvarchar(max)  NULL,
    [StartDate] datetime  NULL,
    [EndDate] datetime  NULL,
    [Status] nvarchar(max)  NULL,
    [progress] int  NULL,
    [TotalCost] float  NULL,
    [Coin] nvarchar(50)  NULL
);
GO

-- Creating table 'ProjectSubActivities'
CREATE TABLE [dbo].[ProjectSubActivities] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SubActivityName] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [Startdate] datetime  NULL,
    [enddate] datetime  NULL,
    [Status] nvarchar(max)  NULL,
    [Progress] int  NULL,
    [TotalCost] float  NULL,
    [ProjectActivity_ID] int  NULL
);
GO

-- Creating table 'Salaries'
CREATE TABLE [dbo].[Salaries] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ContractID] int  NULL,
    [Salary1] float  NULL,
    [Dateofexchange] datetime  NULL,
    [Formonth] datetime  NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [SuppliersNatural] nvarchar(max)  NULL,
    [Fax] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Adderss] nvarchar(max)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TheFinancerProjects'
CREATE TABLE [dbo].[TheFinancerProjects] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProjectID] int  NOT NULL,
    [FinacerID] int  NOT NULL,
    [TotalCost] float  NULL
);
GO

-- Creating table 'Thefinanciers'
CREATE TABLE [dbo].[Thefinanciers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [agentName] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [Fax] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Adderss] nvarchar(max)  NULL
);
GO

-- Creating table 'UsersTbs'
CREATE TABLE [dbo].[UsersTbs] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(50)  NULL,
    [Password] nvarchar(50)  NULL,
    [GroupID] int  NULL,
    [EmployeeID] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'AmountsReceiveds'
ALTER TABLE [dbo].[AmountsReceiveds]
ADD CONSTRAINT [PK_AmountsReceiveds]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Attachments'
ALTER TABLE [dbo].[Attachments]
ADD CONSTRAINT [PK_Attachments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [PK_Contracts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'GroupsTbs'
ALTER TABLE [dbo].[GroupsTbs]
ADD CONSTRAINT [PK_GroupsTbs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PeremissionsTbs'
ALTER TABLE [dbo].[PeremissionsTbs]
ADD CONSTRAINT [PK_PeremissionsTbs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectActivities'
ALTER TABLE [dbo].[ProjectActivities]
ADD CONSTRAINT [PK_ProjectActivities]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectControls'
ALTER TABLE [dbo].[ProjectControls]
ADD CONSTRAINT [PK_ProjectControls]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [PK_ProjectExpenses]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectProfiles'
ALTER TABLE [dbo].[ProjectProfiles]
ADD CONSTRAINT [PK_ProjectProfiles]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ProjectSubActivities'
ALTER TABLE [dbo].[ProjectSubActivities]
ADD CONSTRAINT [PK_ProjectSubActivities]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Salaries'
ALTER TABLE [dbo].[Salaries]
ADD CONSTRAINT [PK_Salaries]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID] in table 'TheFinancerProjects'
ALTER TABLE [dbo].[TheFinancerProjects]
ADD CONSTRAINT [PK_TheFinancerProjects]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Thefinanciers'
ALTER TABLE [dbo].[Thefinanciers]
ADD CONSTRAINT [PK_Thefinanciers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'UsersTbs'
ALTER TABLE [dbo].[UsersTbs]
ADD CONSTRAINT [PK_UsersTbs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TheFinancerProjectsID] in table 'AmountsReceiveds'
ALTER TABLE [dbo].[AmountsReceiveds]
ADD CONSTRAINT [FK_AmountsReceived_TheFinancerProjects]
    FOREIGN KEY ([TheFinancerProjectsID])
    REFERENCES [dbo].[TheFinancerProjects]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AmountsReceived_TheFinancerProjects'
CREATE INDEX [IX_FK_AmountsReceived_TheFinancerProjects]
ON [dbo].[AmountsReceiveds]
    ([TheFinancerProjectsID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'Attachments'
ALTER TABLE [dbo].[Attachments]
ADD CONSTRAINT [FK_Attachments_ProjectProfiles]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Attachments_ProjectProfiles'
CREATE INDEX [IX_FK_Attachments_ProjectProfiles]
ON [dbo].[Attachments]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [Employee_ID] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [FK_Contracts_Employees]
    FOREIGN KEY ([Employee_ID])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Contracts_Employees'
CREATE INDEX [IX_FK_Contracts_Employees]
ON [dbo].[Contracts]
    ([Employee_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'Contracts'
ALTER TABLE [dbo].[Contracts]
ADD CONSTRAINT [FK_Contracts_ProjectProfiles]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Contracts_ProjectProfiles'
CREATE INDEX [IX_FK_Contracts_ProjectProfiles]
ON [dbo].[Contracts]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [ContractID] in table 'Salaries'
ALTER TABLE [dbo].[Salaries]
ADD CONSTRAINT [FK_Salaries_Contracts]
    FOREIGN KEY ([ContractID])
    REFERENCES [dbo].[Contracts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Salaries_Contracts'
CREATE INDEX [IX_FK_Salaries_Contracts]
ON [dbo].[Salaries]
    ([ContractID]);
GO

-- Creating foreign key on [EmployeeID] in table 'UsersTbs'
ALTER TABLE [dbo].[UsersTbs]
ADD CONSTRAINT [FK_UsersTb_Employees]
    FOREIGN KEY ([EmployeeID])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersTb_Employees'
CREATE INDEX [IX_FK_UsersTb_Employees]
ON [dbo].[UsersTbs]
    ([EmployeeID]);
GO

-- Creating foreign key on [GroupID] in table 'PeremissionsTbs'
ALTER TABLE [dbo].[PeremissionsTbs]
ADD CONSTRAINT [FK_PeremissionsTb_GroupsTb]
    FOREIGN KEY ([GroupID])
    REFERENCES [dbo].[GroupsTbs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PeremissionsTb_GroupsTb'
CREATE INDEX [IX_FK_PeremissionsTb_GroupsTb]
ON [dbo].[PeremissionsTbs]
    ([GroupID]);
GO

-- Creating foreign key on [GroupID] in table 'UsersTbs'
ALTER TABLE [dbo].[UsersTbs]
ADD CONSTRAINT [FK_UsersTb_GroupsTb]
    FOREIGN KEY ([GroupID])
    REFERENCES [dbo].[GroupsTbs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersTb_GroupsTb'
CREATE INDEX [IX_FK_UsersTb_GroupsTb]
ON [dbo].[UsersTbs]
    ([GroupID]);
GO

-- Creating foreign key on [ProjectActivity_ID] in table 'ProjectSubActivities'
ALTER TABLE [dbo].[ProjectSubActivities]
ADD CONSTRAINT [FK_ProjectSubActivities_ProjectActivities]
    FOREIGN KEY ([ProjectActivity_ID])
    REFERENCES [dbo].[ProjectActivities]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectSubActivities_ProjectActivities'
CREATE INDEX [IX_FK_ProjectSubActivities_ProjectActivities]
ON [dbo].[ProjectSubActivities]
    ([ProjectActivity_ID]);
GO

-- Creating foreign key on [ProjectID] in table 'ProjectControls'
ALTER TABLE [dbo].[ProjectControls]
ADD CONSTRAINT [FK_ProjectControl_ProjectProfiles]
    FOREIGN KEY ([ProjectID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectControl_ProjectProfiles'
CREATE INDEX [IX_FK_ProjectControl_ProjectProfiles]
ON [dbo].[ProjectControls]
    ([ProjectID]);
GO

-- Creating foreign key on [UserID] in table 'ProjectControls'
ALTER TABLE [dbo].[ProjectControls]
ADD CONSTRAINT [FK_ProjectControl_UsersTb]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[UsersTbs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectControl_UsersTb'
CREATE INDEX [IX_FK_ProjectControl_UsersTb]
ON [dbo].[ProjectControls]
    ([UserID]);
GO

-- Creating foreign key on [ProjectSubActivity_ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [FK_ProjectExpenses_ProjectSubActivities]
    FOREIGN KEY ([ProjectSubActivity_ID])
    REFERENCES [dbo].[ProjectSubActivities]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectExpenses_ProjectSubActivities'
CREATE INDEX [IX_FK_ProjectExpenses_ProjectSubActivities]
ON [dbo].[ProjectExpenses]
    ([ProjectSubActivity_ID]);
GO

-- Creating foreign key on [Supplier_ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [FK_ProjectExpenses_Suppliers]
    FOREIGN KEY ([Supplier_ID])
    REFERENCES [dbo].[Suppliers]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectExpenses_Suppliers'
CREATE INDEX [IX_FK_ProjectExpenses_Suppliers]
ON [dbo].[ProjectExpenses]
    ([Supplier_ID]);
GO

-- Creating foreign key on [ProjectID] in table 'TheFinancerProjects'
ALTER TABLE [dbo].[TheFinancerProjects]
ADD CONSTRAINT [FK_TheFinancerProject_ProjectProfiles]
    FOREIGN KEY ([ProjectID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TheFinancerProject_ProjectProfiles'
CREATE INDEX [IX_FK_TheFinancerProject_ProjectProfiles]
ON [dbo].[TheFinancerProjects]
    ([ProjectID]);
GO

-- Creating foreign key on [FinacerID] in table 'TheFinancerProjects'
ALTER TABLE [dbo].[TheFinancerProjects]
ADD CONSTRAINT [FK_TheFinancerProject_Thefinanciers]
    FOREIGN KEY ([FinacerID])
    REFERENCES [dbo].[Thefinanciers]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TheFinancerProject_Thefinanciers'
CREATE INDEX [IX_FK_TheFinancerProject_Thefinanciers]
ON [dbo].[TheFinancerProjects]
    ([FinacerID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------