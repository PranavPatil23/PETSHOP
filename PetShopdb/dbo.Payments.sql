CREATE TABLE [dbo].[Payments] (
    [PaymentID]   INT          NOT NULL,
    [PaymentDate] DATE         NULL,
    [ModeID]      INT          NULL,
    [Amount]      MONEY        NULL,
    [OrderID]     INT          NULL,
    [Description] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([PaymentID] ASC)
);

