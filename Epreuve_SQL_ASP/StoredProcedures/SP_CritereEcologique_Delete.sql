CREATE PROCEDURE [dbo].[SP_CritereEcologique_Delete]
	@id_critereEcologique INT
AS
	DELETE FROM [CritereEcologique]
	WHERE [Id_CritereEcologique] = @id_critereEcologique

