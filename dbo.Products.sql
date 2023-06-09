CREATE TABLE [dbo].[Products] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (MAX) NULL,
    [Description]    NVARCHAR (MAX) NOT NULL,
    [Price]          FLOAT (53)     NOT NULL,
    [Size]           NVARCHAR (MAX) NULL,
    [Gender]         NVARCHAR (MAX) NULL,
    [ProductTypesId] INT            NOT NULL,
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Products_dbo.ProductTypes_ProductTypesId] FOREIGN KEY ([ProductTypesId]) REFERENCES [dbo].[ProductTypes] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ProductTypesId]
    ON [dbo].[Products]([ProductTypesId] ASC);

