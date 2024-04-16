CREATE TABLE [dbo].[Produit]
(
	[Id_Produit] INT NOT NULL IDENTITY,
	[CritereEcologique] NVARCHAR(64) NOT NULL,
	[Categorie] NVARCHAR(64) NOT NULL,
	[Nom] NVARCHAR (64) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	[Prix] DECIMAL NOT NULL,
	[Stock] INT NOT NULL, 
    CONSTRAINT [PK_Produit] PRIMARY KEY ([Id_Produit]), 
    CONSTRAINT [FK_Produit_CritereEcologique] FOREIGN KEY ([CritereEcologique]) 
	REFERENCES [dbo].[CritereEcologique]([Nom]), 
    CONSTRAINT [FK_Produit_Categorie] FOREIGN KEY ([Categorie]) 
	REFERENCES [dbo].[Categorie]([Nom])
)

