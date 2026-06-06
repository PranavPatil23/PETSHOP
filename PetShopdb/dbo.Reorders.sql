CREATE TABLE [dbo].[Reorders] (
    [ReorderID]    INT           NOT NULL,
    [ProductName]  VARCHAR (100) NULL,
    [Quantity]     INT           NULL,
    [ReorderLevel] INT           NULL,
    PRIMARY KEY CLUSTERED ([ReorderID] ASC)
);

