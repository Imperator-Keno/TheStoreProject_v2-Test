CREATE TABLE [dbo].[ITEM_MASTER] (
    [ITEM_ID]             INT           NOT NULL,
    [ITEM_UPC]            VARCHAR (255) NULL,
    [ITEM_DESCRIPTION]    VARCHAR (255) NULL,
    [INNER_PACK_QTY]      INT           NULL,
    [RETAIL_PRICE]        MONEY         NULL,
    [DISCOUNT_PERCENTAGE] INT           NULL,
    [SUPPLIER]            VARCHAR (255) NULL,
    [SUPPLIER_ID]         INT           NULL,
    [ITEM_CATEGORY]       VARCHAR (255) NULL,
    [CATEGORY_ID]         INT           NULL,
    [BUYER_NAME]          VARCHAR (255) NULL,
    [BUYER_ID]            INT           NULL, 
    CONSTRAINT [PK_ITEM_MASTER] PRIMARY KEY ([ITEM_ID])
);

