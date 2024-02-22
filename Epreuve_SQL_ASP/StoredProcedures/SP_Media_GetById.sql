CREATE PROCEDURE [dbo].[SP_Media_GetById]
	@id_media INT
AS
	SELECT	[Id_Media],
			[Id_Produit]
			[UrlImage]
			FROM [Media]
			WHERE [Id_Media] = @id_media

