CREATE TABLE [dbo].[SubCategory] (
    [SubCategoryID]   INT          NOT NULL,
    [SubCategoryName] VARCHAR (50) NULL,
    [CategoryID]      INT          NULL,
    PRIMARY KEY CLUSTERED ([SubCategoryID] ASC)
);

