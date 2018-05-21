CREATE TABLE [meta].[Attributes] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [ObjectTitle] VARCHAR (50) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [DataType]    VARCHAR (50) NOT NULL,
    [Active]      BIT          NOT NULL,
    CONSTRAINT [PK_Attributes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

