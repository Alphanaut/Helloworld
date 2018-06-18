CREATE TABLE [dbo].[AddressTypes] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Position]    INT            DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_dbo.AddressTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

