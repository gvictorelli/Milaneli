CREATE TABLE [dbo].[Historico] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Origem]      NCHAR (10)      NULL,
    [Destino]     NCHAR (10)      NULL,
    [Tempo]       INT             NULL,
    [Plano]       NCHAR (15)      NULL,
    [ComFaleMais] DECIMAL (18, 2) NULL,
    [SemFaleMais] DECIMAL (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);