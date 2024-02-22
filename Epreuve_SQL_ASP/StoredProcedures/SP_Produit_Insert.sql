CREATE PROCEDURE [dbo].[SP_Produit_Insert]
	@nom VARCHAR(64),
	@description VARCHAR(MAX),
	@prix DECIMAL,
	@stock INT,
	@id_critereEcologique INT,
	@id_categorie INT
AS
	INSERT INTO [Produit] ([Nom], [Description],[Prix], [Stock], [Id_CritereEcologique], [Id_Categorie])
		OUTPUT [inserted].[Id_Produit]
		VALUES (@nom, @description, @prix, @stock, @id_critereEcologique ,@id_categorie )
