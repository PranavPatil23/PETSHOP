CREATE TABLE [dbo].[Orders] (
    [OrderID]     INT  NOT NULL,
    [OrderDate]   DATE NOT NULL,
    [VendorID]    INT  NOT NULL,
    [StatusID]    INT  NULL,
    [UpdateStock] INT  NULL,
    PRIMARY KEY CLUSTERED ([OrderID] ASC)
);

