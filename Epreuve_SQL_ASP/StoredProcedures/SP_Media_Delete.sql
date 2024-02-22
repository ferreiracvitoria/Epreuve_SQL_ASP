CREATE PROCEDURE [dbo].[SP_Media_Delete]
	@id_media INT
AS
	DELETE FROM [Media]
	WHERE [Id_Media] = @id_media
