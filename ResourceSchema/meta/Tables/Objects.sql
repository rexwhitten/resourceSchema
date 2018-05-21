CREATE TABLE [meta].[Objects] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Title]  VARCHAR (150) NOT NULL,
    [Path]   VARCHAR (512) NOT NULL,
    [Active] BIT           NOT NULL,
    CONSTRAINT [PK_Objects] PRIMARY KEY CLUSTERED ([Id] ASC)
);

