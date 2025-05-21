CREATE TABLE [dbo].[Pen] (
    [PenID]    INT            IDENTITY (1, 1) NOT NULL,
    [PenName]  NVARCHAR (100) NULL,
    [Capacity] INT            NULL,
    [Location] NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([PenID] ASC)
);

CREATE TABLE [dbo].[Staff] (
    [StaffID]  INT            IDENTITY (1, 1) NOT NULL,
    [FullName] NVARCHAR (100) NULL,
    [Position] NVARCHAR (50)  NULL,
    [Phone]    NVARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([StaffID] ASC)
);

CREATE TABLE [dbo].[Animal] (
    [AnimalID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (100) NULL,
    [Species]  NVARCHAR (50)  NULL,
    [Breed]    NVARCHAR (50)  NULL,
    [Gender]   NVARCHAR (10)  NULL,
    [Weight]   FLOAT (53)     NULL,
    [PenID]    INT            NULL,
    PRIMARY KEY CLUSTERED ([AnimalID] ASC),
    FOREIGN KEY ([PenID]) REFERENCES [dbo].[Pen] ([PenID])
);

CREATE TABLE [dbo].[Feed] (
    [FeedID]      INT            IDENTITY (1, 1) NOT NULL,
    [FeedName]    NVARCHAR (100) NULL,
    [Description] NVARCHAR (255) NULL,
    [Quantity]    FLOAT (53)     NULL,
    [Unit]        NVARCHAR (20)  NULL,
    PRIMARY KEY CLUSTERED ([FeedID] ASC)
);

CREATE TABLE [dbo].[FeedingSchedule] (
    [ScheduleID] INT        IDENTITY (1, 1) NOT NULL,
    [AnimalID]   INT        NULL,
    [FeedID]     INT        NULL,
    [FeedTime]   DATETIME   NULL,
    [Amount]     FLOAT (53) NULL,
    PRIMARY KEY CLUSTERED ([ScheduleID] ASC),
    FOREIGN KEY ([AnimalID]) REFERENCES [dbo].[Animal] ([AnimalID]),
    FOREIGN KEY ([FeedID]) REFERENCES [dbo].[Feed] ([FeedID])
);

CREATE TABLE [dbo].[CareLog] (
    [LogID]       INT            IDENTITY (1, 1) NOT NULL,
    [AnimalID]    INT            NULL,
    [StaffID]     INT            NULL,
    [CareDate]    DATE           NULL,
    [Description] NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([LogID] ASC),
    FOREIGN KEY ([AnimalID]) REFERENCES [dbo].[Animal] ([AnimalID]),
    FOREIGN KEY ([StaffID]) REFERENCES [dbo].[Staff] ([StaffID])
);

CREATE TABLE [dbo].[HealthCheck] (
    [CheckID]   INT            IDENTITY (1, 1) NOT NULL,
    [AnimalID]  INT            NULL,
    [CheckDate] DATE           NULL,
    [Status]    NVARCHAR (255) NULL,
    [Notes]     NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([CheckID] ASC),
    FOREIGN KEY ([AnimalID]) REFERENCES [dbo].[Animal] ([AnimalID])
);
