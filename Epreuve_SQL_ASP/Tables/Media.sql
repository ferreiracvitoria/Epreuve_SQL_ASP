CREATE TABLE [dbo].[Media]
(
	[Id_Media] INT NOT NULL IDENTITY,
	[Id_Produit] INT NOT NULL,
	[UrlImage] NVARCHAR (256) NOT NULL, 
    CONSTRAINT [PK_Media] PRIMARY KEY ([Id_Media]), 
    CONSTRAINT [FK_Media_Produit] FOREIGN KEY ([Id_Produit]) REFERENCES [dbo].[Produit]([Id_Produit]),

)
