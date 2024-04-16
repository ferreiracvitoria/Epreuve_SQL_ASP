CREATE PROCEDURE [dbo].[SP_Produit_Update]
	@id_produit INT,
	@nom VARCHAR(64),
	@description VARCHAR(MAX),
	@prix DECIMAL,
	@stock INT,
	@critereEcologique NVARCHAR(64),
	@categorie NVARCHAR(64)
AS
	UPDATE [Produit] 
		SET [Nom] = @nom,
			[Description] = @description,
			[Prix] = @prix,
			[Stock] = @stock,
			[CritereEcologique] = @critereEcologique,
			[Categorie] = @categorie
		WHERE [Id_Produit] = @id_produit
