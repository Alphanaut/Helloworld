CREATE TABLE [dbo].[Addresses] (
    [Id]            INT              IDENTITY (1, 1) NOT NULL,
    [Street]        NVARCHAR (MAX)   NOT NULL,
    [City]          NVARCHAR (MAX)   NOT NULL,
    [StateId]       INT              NOT NULL,
    [ZipCode]       NVARCHAR (15)    NOT NULL,
    [CountryId]     INT              NOT NULL,
    [AddressTypeId] INT              NOT NULL,
    [Registrant_Id] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_dbo.Addresses] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Addresses_dbo.AddressTypes_AddressTypeId] FOREIGN KEY ([AddressTypeId]) REFERENCES [dbo].[AddressTypes] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Addresses_dbo.Countries_CountryId] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Addresses_dbo.Registrants_Registrant_Id] FOREIGN KEY ([Registrant_Id]) REFERENCES [dbo].[Registrants] ([Id]),
    CONSTRAINT [FK_dbo.Addresses_dbo.States_StateId] FOREIGN KEY ([StateId]) REFERENCES [dbo].[States] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Registrant_Id]
    ON [dbo].[Addresses]([Registrant_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AddressTypeId]
    ON [dbo].[Addresses]([AddressTypeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CountryId]
    ON [dbo].[Addresses]([CountryId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_StateId]
    ON [dbo].[Addresses]([StateId] ASC);

