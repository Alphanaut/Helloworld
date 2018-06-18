CREATE TABLE [dbo].[States] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [USPSCode] NVARCHAR (MAX) NULL,
    [Position] INT            NOT NULL,
    CONSTRAINT [PK_dbo.States] PRIMARY KEY CLUSTERED ([Id] ASC)
);

