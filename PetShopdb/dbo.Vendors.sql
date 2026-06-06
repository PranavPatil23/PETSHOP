CREATE TABLE [dbo].[Vendors] (
    [VendorID]     INT           NOT NULL,
    [VendorName]   VARCHAR (50)  NOT NULL,
    [Address]      VARCHAR (100) NOT NULL,
    [Phone]        VARCHAR (13)  NOT NULL,
    [VendorTypeID] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([VendorID] ASC)
);

