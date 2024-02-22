CREATE PROCEDURE [dbo].[SP_Media_Insert]
	@id_produit INT,
	@urlImage VARCHAR (256)
AS
	INSERT INTO [Media] ([Id_Produit], [UrlImage])
		OUTPUT [inserted].[Id_Media]
		VALUES (@id_produit, @urlImage)
