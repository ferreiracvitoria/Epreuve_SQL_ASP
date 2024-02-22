CREATE PROCEDURE [dbo].[SP_CritereEcologique_GetAll]
AS
	SELECT	[Id_CritereEcologique],
			[Nom]
	FROM [CritereEcologique]
