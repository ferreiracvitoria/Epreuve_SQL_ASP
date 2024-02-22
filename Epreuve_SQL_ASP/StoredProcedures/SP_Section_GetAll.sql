CREATE PROCEDURE [dbo].[SP_Section_GetAll]
AS
	SELECT	[Id_Section],
			[Id_Commande],
			[Id_Produit],
			[Quantite]
	FROM [Section]
