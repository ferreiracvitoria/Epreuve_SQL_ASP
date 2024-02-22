CREATE PROCEDURE [dbo].[SP_Produit_Update]
	@id_produit INT,
	@nom VARCHAR(64),
	@description VARCHAR(MAX),
	@prix DECIMAL,
	@stock INT,
	@id_critereEcologique INT,
	@id_categorie INT
AS
	UPDATE [Produit] 
		SET [Nom] = @nom,
			[Description] = @description,
			[Prix] = @prix,
			[Stock] = @stock,
			[Id_CritereEcologique] = @id_critereEcologique,
			[Id_Categorie] = @id_categorie
		WHERE [Id_Produit] = @id_produit
