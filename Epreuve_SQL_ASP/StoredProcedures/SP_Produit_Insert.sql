CREATE PROCEDURE [dbo].[SP_Produit_Insert]
	@nom VARCHAR(64),
	@description VARCHAR(MAX),
	@prix DECIMAL,
	@stock INT,
	@critereEcologique NVARCHAR(64),
	@categorie NVARCHAR(64) 
AS
	INSERT INTO [Produit] ([Nom], [Description],[Prix], [Stock], [CritereEcologique], [Categorie])
		OUTPUT [inserted].[Id_Produit]
		VALUES (@nom, @description, @prix, @stock, @critereEcologique ,@categorie )
