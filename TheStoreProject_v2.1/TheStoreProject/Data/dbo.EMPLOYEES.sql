﻿CREATE TABLE [dbo].[EMPLOYEES] (
    [EMPLOYEE_ID]   INT           NOT NULL,
    [FIRST_NAME]    VARCHAR (255) NULL,
    [LAST_NAME]     VARCHAR (255) NULL,
    [PHONE_NUMBER]  VARCHAR (255) NULL,
    [ADDRESS]       VARCHAR (255) NULL,
    [CITY]          VARCHAR (255) NULL,
    [STATE]         VARCHAR (255) NULL,
    [ZIP_CODE]      INT           NULL,
    [EMAIL_ADDRESS] VARCHAR (255) NULL,
    [SITE_NAME]     VARCHAR (255) NULL, 
    CONSTRAINT [PK_EMPLOYEES] PRIMARY KEY ([EMPLOYEE_ID])
);

