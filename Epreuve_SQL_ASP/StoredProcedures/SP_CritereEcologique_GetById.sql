CREATE PROCEDURE [dbo].[SP_CritereEcologique_GetById]
	@id_critereEcologique INT
AS
	SELECT	[Id_CritereEcologique],
			[Nom]			
	FROM [CritereEcologique]
	WHERE [Id_CritereEcologique] = @id_critereEcologique
