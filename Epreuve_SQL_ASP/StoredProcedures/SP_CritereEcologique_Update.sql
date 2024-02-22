CREATE PROCEDURE [dbo].[SP_CritereEcologique_Update]
	@id_critereEcologique INT,
	@nom VARCHAR (64)
AS
	UPDATE [CritereEcologique]
	SET [Nom] = @nom
	WHERE [Id_CritereEcologique] = @id_critereEcologique
