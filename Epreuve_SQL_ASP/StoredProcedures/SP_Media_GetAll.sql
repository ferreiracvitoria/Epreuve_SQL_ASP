CREATE PROCEDURE [dbo].[SP_Media_GetAll]
AS
	SELECT	[Id_Media],
			[Id_Produit],
			[UrlImage]
	FROM [Media]
