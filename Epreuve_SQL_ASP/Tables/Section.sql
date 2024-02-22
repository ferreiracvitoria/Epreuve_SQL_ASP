CREATE TABLE [dbo].[Section]
(
	[Id_Section] INT NOT NULL IDENTITY, 
    [Id_Commande] INT NOT NULL,
    [Id_Produit] INT NOT NULL,
    [Quantite] INT NOT NULL, 
    CONSTRAINT [PK_Section] PRIMARY KEY ([Id_Section]), 
    CONSTRAINT [FK_Section_Commande] FOREIGN KEY ([Id_Commande]) REFERENCES [dbo].[Commande]([Id_Commande]), 
    CONSTRAINT [FK_Section_Produit] FOREIGN KEY ([Id_Produit]) REFERENCES [dbo].[Produit]([Id_Produit])
)
