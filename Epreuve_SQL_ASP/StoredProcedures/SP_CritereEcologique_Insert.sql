CREATE PROCEDURE [dbo].[SP_CritereEcologique_Insert]
	@nom VARCHAR(64)
AS
	INSERT INTO [CritereEcologique] ([Nom])
		OUTPUT [inserted].[Id_CritereEcologique]
		VALUES (@nom)
