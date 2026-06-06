CREATE TABLE [dbo].[Product] (
    [ProductID]     INT           NOT NULL,
    [ProductName]   VARCHAR (MAX) NULL,
    [Quantity]      INT           NULL,
    [UnitPrice]     MONEY         NULL,
    [Margin]        INT           NULL,
    [ReorderLevel]  SMALLINT      NULL,
    [SubCategoryID] INT           NOT NULL,
    [MfgDate]       DATE          NULL,
    [ExpDate]       DATE          NULL,
    [CompanyID]     INT           NULL,
    PRIMARY KEY CLUSTERED ([ProductID] ASC)
);

