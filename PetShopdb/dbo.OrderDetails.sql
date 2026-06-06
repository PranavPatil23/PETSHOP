CREATE TABLE [dbo].[OrderDetails] (
    [OrderID]   INT   NOT NULL,
    [ProductID] INT   NOT NULL,
    [Quantity]  INT   NOT NULL,
    [UnitPrice] MONEY NULL,
    [Margin]    INT   NULL,
    CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED ([OrderID] ASC, [ProductID] ASC)
);

