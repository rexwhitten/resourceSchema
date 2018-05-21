CREATE TABLE [meta].[Relations] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Parent] VARCHAR (50) NOT NULL,
    [Child]  VARCHAR (50) NOT NULL,
    [Active] BIT          NOT NULL,
    CONSTRAINT [PK_Relations] PRIMARY KEY CLUSTERED ([Id] ASC)
);

