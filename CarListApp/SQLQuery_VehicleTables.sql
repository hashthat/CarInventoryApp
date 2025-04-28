-- Drop all tables if they exist
DROP TABLE IF EXISTS [dbo].[Table_Car];
DROP TABLE IF EXISTS [dbo].[Table_SUV];
DROP TABLE IF EXISTS [dbo].[Table_Truck];
DROP TABLE IF EXISTS [dbo].[Table_User];

-- Create Table for Cars
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

-- Insert Data into Table_Car
INSERT INTO [dbo].[Table_Car] (CarID, Make, Model, Year, Color, Transmission)
VALUES 
(1, 'Toyota', 'Camry', 2020, 'Silver', 'Automatic'),
(2, 'Honda', 'Civic', 2019, 'Blue', 'Manual'),
(3, 'Nissan', 'Juke', 2017, 'Black', 'Manual'),
(4, 'Acura', 'Integra', 2012, 'Forrest Green', 'Manual');

-- Create Table for SUVs
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

-- Insert Data into Table_SUV
INSERT INTO [dbo].[Table_SUV] (Make, Model, Year, Price, Color, Condition, Drivetrain)
VALUES 
('Jeep', 'Grand Cherokee', 2022, 35000, 'White', 'New', 'AWD'),
('Honda', 'CR-V', 2021, 28000, 'Gray', 'Used', 'FWD'),
('Toyota', 'RAV4', 2020, 27000, 'Red', 'New', 'AWD'),
('Kia', 'Soul', 2019, 17999, 'Black', 'Used', 'FWD');

-- Create Table for Trucks
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

-- Insert Data into Table_Truck
INSERT INTO [dbo].[Table_Truck] (Make, Model, Year, Price, TruckType, Drivetrain, Color)
VALUES 
('Ford', 'F-150', 2022, 45000, 'Full-Size', '4WD', 'Black'),
('Chevrolet', 'Silverado', 2021, 43000, 'Full-Size', '4WD', 'White'),
('Toyota', 'Tacoma', 2013, 22000, 'Compact', '4WD', 'Blue'),
('Honda', 'Ridgeline', 2025, 41149, 'Compact', '4x4', 'Silver');

-- Create Table for Users
CREATE TABLE [dbo].[Table_User] (
    [UserID]      INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50)  NULL,
    [LastName]  NVARCHAR (50)  NULL,
    [UserName]  NVARCHAR (250) NULL,
    [Password]   NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);

-- Insert Data into Table_User
INSERT INTO [dbo].[Table_User] (FirstName, LastName, UserName, Password)
VALUES 
('Tracy', 'Smith', 'WhiteRabbit', 'Password123'),
('Bobby', 'Brusella', 'BobzyBlue', 'MySecret!'),
('Kenobi', 'Sky', 'GusSkynet', 'Pa$$w0rd'),
('Kasper', 'Light', 'Mokaspo', 'Flounder123');
