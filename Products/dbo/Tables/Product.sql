CREATE TABLE [dbo].[Product] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (250) NOT NULL,
    [Price]        MONEY          NULL,
    [Creation]     DATETIME2 (7)  NULL,
    [Modification] DATETIME2 (7)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

