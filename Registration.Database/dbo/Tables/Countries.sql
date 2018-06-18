CREATE TABLE [dbo].[Countries] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [CountryCode] NVARCHAR (MAX) NULL,
    [Name]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Countries] PRIMARY KEY CLUSTERED ([Id] ASC)
);

