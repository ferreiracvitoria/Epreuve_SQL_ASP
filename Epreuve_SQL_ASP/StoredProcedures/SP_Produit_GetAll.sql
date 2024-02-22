CREATE PROCEDURE [dbo].[SP_Produit_GetAll]
AS
	SELECT	[Id_Produit],
			[Id_CritereEcologique],
			[Id_Categorie],
			[Nom],
			[Description],
			[Prix],
			[Stock]
	FROM [Produit]
