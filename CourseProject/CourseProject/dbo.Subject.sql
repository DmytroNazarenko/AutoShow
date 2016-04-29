CREATE TABLE [dbo].[Subject] (
    [ID]         INT           NOT NULL IDENTITY,
    [FirstName]  NCHAR (10)    NULL,
    [SecondName] NCHAR (10)    NULL,
    [Email]      NVARCHAR (50) NOT NULL,
    [Password]   NVARCHAR (50) NOT NULL
);

