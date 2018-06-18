CREATE TABLE [dbo].[Registrants] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [FirstName]   NVARCHAR (MAX)   NOT NULL,
    [LastName]    NVARCHAR (MAX)   NOT NULL,
    [CreatedDate] DATETIME         NOT NULL,
    CONSTRAINT [PK_dbo.Registrants] PRIMARY KEY CLUSTERED ([Id] ASC)
);

