CREATE TABLE [dbo].[Produit]
(
	[Id_Produit] INT NOT NULL  IDENTITY,
	[Id_CritereEcologique] INT NOT NULL,
	[Id_Categorie] INT NOT NULL,
	[Nom] NVARCHAR (64) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	[Prix] DECIMAL NOT NULL,
	[Stock] INT NOT NULL, 
    CONSTRAINT [PK_Produit] PRIMARY KEY ([Id_Produit]), 
    CONSTRAINT [FK_Produit_CritereEcologique] FOREIGN KEY ([Id_CritereEcologique]) REFERENCES [dbo].[CritereEcologique]([Id_CritereEcologique]), 
    CONSTRAINT [FK_Produit_Categorie] FOREIGN KEY ([Id_Categorie]) REFERENCES [dbo].[Categorie]([Id_Categorie]),
)
