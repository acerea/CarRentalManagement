USE [CarRentalManagement_db]
GO

/****** Object: Table [dbo].[Makes] Script Date: 12/11/2023 12:57:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Makes] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [DateCreated] DATETIME2 (7)  NOT NULL,
    [DateUpdated] DATETIME2 (7)  NOT NULL,
    [CreatedBy]   NVARCHAR (MAX) NULL,
    [UpdatedBy]   NVARCHAR (MAX) NULL
);

/*INSERT INTO Makes VALUES
(1, 'BMW', DateTime.Now, DateTime.Now, 'System', 'System');*/