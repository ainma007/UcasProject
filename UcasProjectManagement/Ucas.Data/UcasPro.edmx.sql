
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/21/2014 00:31:17
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
IF OBJECT_ID(N'[dbo].[FK_AmountsReceiveds_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AmountsReceiveds] DROP CONSTRAINT [FK_AmountsReceiveds_ProjectProfiles];
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
    ALTER TABLE [dbo].[Monthlysalaries] DROP CONSTRAINT [FK_Salaries_Contracts];
GO
IF OBJECT_ID(N'[dbo].[FK_UserTb_Employees]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserTbs] DROP CONSTRAINT [FK_UserTb_Employees];
GO
IF OBJECT_ID(N'[dbo].[FK_Monthlysalaries_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Monthlysalaries] DROP CONSTRAINT [FK_Monthlysalaries_ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectActivities_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectActivities] DROP CONSTRAINT [FK_ProjectActivities_ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectSubActivities_ProjectActivities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectSubActivities] DROP CONSTRAINT [FK_ProjectSubActivities_ProjectActivities];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectControls_ProjectProfiles1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectControls] DROP CONSTRAINT [FK_ProjectControls_ProjectProfiles1];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectControls_UserTb]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectControls] DROP CONSTRAINT [FK_ProjectControls_UserTb];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectExpenses_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_ProjectExpenses_ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectExpenses_ProjectSubActivities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_ProjectExpenses_ProjectSubActivities];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectExpenses_Suppliers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectExpenses] DROP CONSTRAINT [FK_ProjectExpenses_Suppliers];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectSubActivities_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjectSubActivities] DROP CONSTRAINT [FK_ProjectSubActivities_ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_TheFinancerProject_ProjectProfiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TheDonorsProjects] DROP CONSTRAINT [FK_TheFinancerProject_ProjectProfiles];
GO
IF OBJECT_ID(N'[dbo].[FK_UserPermession_SystemPermession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserPermessions] DROP CONSTRAINT [FK_UserPermession_SystemPermession];
GO
IF OBJECT_ID(N'[dbo].[FK_TheFinancerProject_Thefinanciers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TheDonorsProjects] DROP CONSTRAINT [FK_TheFinancerProject_Thefinanciers];
GO
IF OBJECT_ID(N'[dbo].[FK_UserPermession_UserTbs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserPermessions] DROP CONSTRAINT [FK_UserPermession_UserTbs];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
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
IF OBJECT_ID(N'[dbo].[Monthlysalaries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Monthlysalaries];
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
IF OBJECT_ID(N'[dbo].[Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suppliers];
GO
IF OBJECT_ID(N'[dbo].[SystemPermessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SystemPermessions];
GO
IF OBJECT_ID(N'[dbo].[TheDonors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TheDonors];
GO
IF OBJECT_ID(N'[dbo].[TheDonorsProjects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TheDonorsProjects];
GO
IF OBJECT_ID(N'[dbo].[UserPermessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserPermessions];
GO
IF OBJECT_ID(N'[dbo].[UserTbs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserTbs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'AmountsReceiveds'
CREATE TABLE [dbo].[AmountsReceiveds] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [TheDonorsProjectID] int  NULL,
    [Date] datetime  NULL,
    [Cost] float  NULL,
    [ProjectProfile_ID] int  NULL
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
    [StartDate] datetime  NULL,
    [EndDate] datetime  NULL,
    [SelaryAmount] float  NULL,
    [Status] nchar(10)  NULL,
    [ProjectProfile_ID] int  NOT NULL,
    [TotalSalary] nvarchar(max)  NULL
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

-- Creating table 'Monthlysalaries'
CREATE TABLE [dbo].[Monthlysalaries] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ContractID] int  NULL,
    [Amount] float  NULL,
    [IssueDate] datetime  NULL,
    [Formonth] datetime  NULL,
    [ProjectProfile_ID] int  NULL
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
    [Progress] float  NULL,
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
    [Supplier_ID] int  NULL,
    [ProjectProfile_ID] int  NULL
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
    [progress] float  NULL,
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
    [Progress] float  NULL,
    [TotalCost] float  NULL,
    [ProjectActivity_ID] int  NULL,
    [ProjectProfile_ID] int  NULL
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

-- Creating table 'SystemPermessions'
CREATE TABLE [dbo].[SystemPermessions] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [PermessionName] varchar(50)  NULL,
    [Desription] nvarchar(50)  NULL
);
GO

-- Creating table 'TheDonors'
CREATE TABLE [dbo].[TheDonors] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [agentName] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [Fax] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Adderss] nvarchar(max)  NULL
);
GO

-- Creating table 'TheDonorsProjects'
CREATE TABLE [dbo].[TheDonorsProjects] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProjectID] int  NOT NULL,
    [DonorsID] int  NOT NULL,
    [TotalCost] float  NULL
);
GO

-- Creating table 'UserPermessions'
CREATE TABLE [dbo].[UserPermessions] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [UserID] int  NULL,
    [PermessioID] int  NULL,
    [PermessionValue] nvarchar(50)  NULL
);
GO

-- Creating table 'UserTbs'
CREATE TABLE [dbo].[UserTbs] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NULL,
    [Password] nvarchar(max)  NULL,
    [Employee_ID] int  NULL,
    [TypeUser] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

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

-- Creating primary key on [ID] in table 'Monthlysalaries'
ALTER TABLE [dbo].[Monthlysalaries]
ADD CONSTRAINT [PK_Monthlysalaries]
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

-- Creating primary key on [ID] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SystemPermessions'
ALTER TABLE [dbo].[SystemPermessions]
ADD CONSTRAINT [PK_SystemPermessions]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TheDonors'
ALTER TABLE [dbo].[TheDonors]
ADD CONSTRAINT [PK_TheDonors]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TheDonorsProjects'
ALTER TABLE [dbo].[TheDonorsProjects]
ADD CONSTRAINT [PK_TheDonorsProjects]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'UserPermessions'
ALTER TABLE [dbo].[UserPermessions]
ADD CONSTRAINT [PK_UserPermessions]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'UserTbs'
ALTER TABLE [dbo].[UserTbs]
ADD CONSTRAINT [PK_UserTbs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TheDonorsProjectID] in table 'AmountsReceiveds'
ALTER TABLE [dbo].[AmountsReceiveds]
ADD CONSTRAINT [FK_AmountsReceived_TheFinancerProjects]
    FOREIGN KEY ([TheDonorsProjectID])
    REFERENCES [dbo].[TheDonorsProjects]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AmountsReceived_TheFinancerProjects'
CREATE INDEX [IX_FK_AmountsReceived_TheFinancerProjects]
ON [dbo].[AmountsReceiveds]
    ([TheDonorsProjectID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'AmountsReceiveds'
ALTER TABLE [dbo].[AmountsReceiveds]
ADD CONSTRAINT [FK_AmountsReceiveds_ProjectProfiles]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AmountsReceiveds_ProjectProfiles'
CREATE INDEX [IX_FK_AmountsReceiveds_ProjectProfiles]
ON [dbo].[AmountsReceiveds]
    ([ProjectProfile_ID]);
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

-- Creating foreign key on [ContractID] in table 'Monthlysalaries'
ALTER TABLE [dbo].[Monthlysalaries]
ADD CONSTRAINT [FK_Salaries_Contracts]
    FOREIGN KEY ([ContractID])
    REFERENCES [dbo].[Contracts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Salaries_Contracts'
CREATE INDEX [IX_FK_Salaries_Contracts]
ON [dbo].[Monthlysalaries]
    ([ContractID]);
GO

-- Creating foreign key on [Employee_ID] in table 'UserTbs'
ALTER TABLE [dbo].[UserTbs]
ADD CONSTRAINT [FK_UserTb_Employees]
    FOREIGN KEY ([Employee_ID])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserTb_Employees'
CREATE INDEX [IX_FK_UserTb_Employees]
ON [dbo].[UserTbs]
    ([Employee_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'Monthlysalaries'
ALTER TABLE [dbo].[Monthlysalaries]
ADD CONSTRAINT [FK_Monthlysalaries_ProjectProfiles]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Monthlysalaries_ProjectProfiles'
CREATE INDEX [IX_FK_Monthlysalaries_ProjectProfiles]
ON [dbo].[Monthlysalaries]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'ProjectActivities'
ALTER TABLE [dbo].[ProjectActivities]
ADD CONSTRAINT [FK_ProjectActivities_ProjectProfiles]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectActivities_ProjectProfiles'
CREATE INDEX [IX_FK_ProjectActivities_ProjectProfiles]
ON [dbo].[ProjectActivities]
    ([ProjectProfile_ID]);
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
ADD CONSTRAINT [FK_ProjectControls_ProjectProfiles1]
    FOREIGN KEY ([ProjectID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectControls_ProjectProfiles1'
CREATE INDEX [IX_FK_ProjectControls_ProjectProfiles1]
ON [dbo].[ProjectControls]
    ([ProjectID]);
GO

-- Creating foreign key on [UserID] in table 'ProjectControls'
ALTER TABLE [dbo].[ProjectControls]
ADD CONSTRAINT [FK_ProjectControls_UserTb]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[UserTbs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectControls_UserTb'
CREATE INDEX [IX_FK_ProjectControls_UserTb]
ON [dbo].[ProjectControls]
    ([UserID]);
GO

-- Creating foreign key on [ProjectProfile_ID] in table 'ProjectExpenses'
ALTER TABLE [dbo].[ProjectExpenses]
ADD CONSTRAINT [FK_ProjectExpenses_ProjectProfiles]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectExpenses_ProjectProfiles'
CREATE INDEX [IX_FK_ProjectExpenses_ProjectProfiles]
ON [dbo].[ProjectExpenses]
    ([ProjectProfile_ID]);
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

-- Creating foreign key on [ProjectProfile_ID] in table 'ProjectSubActivities'
ALTER TABLE [dbo].[ProjectSubActivities]
ADD CONSTRAINT [FK_ProjectSubActivities_ProjectProfiles]
    FOREIGN KEY ([ProjectProfile_ID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectSubActivities_ProjectProfiles'
CREATE INDEX [IX_FK_ProjectSubActivities_ProjectProfiles]
ON [dbo].[ProjectSubActivities]
    ([ProjectProfile_ID]);
GO

-- Creating foreign key on [ProjectID] in table 'TheDonorsProjects'
ALTER TABLE [dbo].[TheDonorsProjects]
ADD CONSTRAINT [FK_TheFinancerProject_ProjectProfiles]
    FOREIGN KEY ([ProjectID])
    REFERENCES [dbo].[ProjectProfiles]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TheFinancerProject_ProjectProfiles'
CREATE INDEX [IX_FK_TheFinancerProject_ProjectProfiles]
ON [dbo].[TheDonorsProjects]
    ([ProjectID]);
GO

-- Creating foreign key on [PermessioID] in table 'UserPermessions'
ALTER TABLE [dbo].[UserPermessions]
ADD CONSTRAINT [FK_UserPermession_SystemPermession]
    FOREIGN KEY ([PermessioID])
    REFERENCES [dbo].[SystemPermessions]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserPermession_SystemPermession'
CREATE INDEX [IX_FK_UserPermession_SystemPermession]
ON [dbo].[UserPermessions]
    ([PermessioID]);
GO

-- Creating foreign key on [DonorsID] in table 'TheDonorsProjects'
ALTER TABLE [dbo].[TheDonorsProjects]
ADD CONSTRAINT [FK_TheFinancerProject_Thefinanciers]
    FOREIGN KEY ([DonorsID])
    REFERENCES [dbo].[TheDonors]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TheFinancerProject_Thefinanciers'
CREATE INDEX [IX_FK_TheFinancerProject_Thefinanciers]
ON [dbo].[TheDonorsProjects]
    ([DonorsID]);
GO

-- Creating foreign key on [UserID] in table 'UserPermessions'
ALTER TABLE [dbo].[UserPermessions]
ADD CONSTRAINT [FK_UserPermession_UserTbs]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[UserTbs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserPermession_UserTbs'
CREATE INDEX [IX_FK_UserPermession_UserTbs]
ON [dbo].[UserPermessions]
    ([UserID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------