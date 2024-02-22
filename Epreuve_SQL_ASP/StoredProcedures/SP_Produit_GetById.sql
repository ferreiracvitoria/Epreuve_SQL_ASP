CREATE PROCEDURE [dbo].[SP_Produit_GetById]
	@id_produit INT
AS
	SELECT	[Id_Produit],
			[Id_CritereEcologique],
			[Id_Categorie],
			[Nom],
			[Description],
			[Prix],
			[Stock]
			FROM [Produit]
		WHERE [Id_Produit] = @id_produit