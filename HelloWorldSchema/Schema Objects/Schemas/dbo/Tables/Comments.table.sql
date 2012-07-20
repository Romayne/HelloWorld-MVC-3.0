CREATE TABLE [dbo].[Comments] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [ApplicationId] INT           NOT NULL,
    [Creator]       VARCHAR (255) NULL,
    [Details]       VARCHAR (MAX) NOT NULL,
    [IsPublic]      BIT           NOT NULL,
    [Created]       DATETIME      NOT NULL
);

