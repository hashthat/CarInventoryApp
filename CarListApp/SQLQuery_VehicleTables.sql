CREATE TABLE [dbo].[Table_Car] (
    [CarID]   INT           NOT NULL,
    [Make]         NVARCHAR (50) NULL,
    [Model]        NVARCHAR (50) NULL,
    [Year]         INT           NULL,
    [Price]        INT           IDENTITY (1, 1) NOT NULL,
    [Color]        NVARCHAR (50) NULL,
    [Transmission] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CarID] ASC)
);

CREATE TABLE [dbo].[Table_SUV] (
    [SUV_ID]     INT           IDENTITY (1, 1) NOT NULL,
    [Make]       NVARCHAR (50) NULL,
    [Model]      NVARCHAR (50) NULL,
    [Year]       INT           NULL,
    [Price]      INT           NOT NULL,
    [Color]      NVARCHAR (50) NULL,
    [Condition]  NVARCHAR (50) NULL,
    [Drivetrain] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([SUV_ID] ASC)
);

CREATE TABLE [dbo].[Table_Truck] (
    [TruckID] INT           IDENTITY (1, 1) NOT NULL,
    [Make]         NVARCHAR (50) NULL,
    [Model]        NVARCHAR (50) NULL,
    [Year]         INT           NULL,
    [Price]        INT           NOT NULL,
    [TruckType]    NVARCHAR (50) NULL,
    [Drivetrain]   NVARCHAR (50) NULL,
    [Color]        NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([TruckID] ASC)
);

CREATE TABLE [dbo].[Table_User] (
    [UserID]      INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50)  NULL,
    [LastName]  NVARCHAR (50)  NULL,
    [UserName]  NVARCHAR (250) NULL,
    [Password]   NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);
