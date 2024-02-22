CREATE PROCEDURE [dbo].[SP_Media_Update]
	@id_media INT,
	@id_produit INT,
	@urlImage VARCHAR (256)
AS
	UPDATE [Media]
		SET [Id_Produit] = @id_produit,
			[UrlImage] = @urlImage
		WHERE [Id_Media] = @id_media
