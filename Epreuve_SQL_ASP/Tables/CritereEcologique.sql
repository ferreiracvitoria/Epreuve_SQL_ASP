CREATE TABLE [dbo].[CritereEcologique]
(
	[Id_CritereEcologique] INT NOT NULL IDENTITY, 
	[Nom] NVARCHAR (64) NOT NULL,
    CONSTRAINT [PK_CritereEcologique] PRIMARY KEY ([Id_CritereEcologique]),
)
