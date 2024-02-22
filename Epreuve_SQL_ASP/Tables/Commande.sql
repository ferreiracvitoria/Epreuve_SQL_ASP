CREATE TABLE [dbo].[Commande]
(
	[Id_Commande] INT NOT NULL IDENTITY,
	[DateCommande] DATETIME NOT NULL,
    CONSTRAINT [PK_Commande] PRIMARY KEY ([Id_Commande]),
)
