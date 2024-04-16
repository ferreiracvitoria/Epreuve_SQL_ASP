CREATE PROCEDURE [dbo].[SP_Produit_GetAll]
AS
	SELECT	[Id_Produit],
			[CritereEcologique],
			[Categorie],
			[Nom],
			[Description],
			[Prix],
			[Stock]
	FROM [Produit]
