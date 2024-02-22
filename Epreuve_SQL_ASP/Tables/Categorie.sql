CREATE TABLE [dbo].[Categorie]
(
	[Id_Categorie] INT NOT NULL IDENTITY,
	[Nom] NVARCHAR (64) NOT NULL,
    CONSTRAINT [PK_Categorie] PRIMARY KEY ([Id_Categorie]),
)
