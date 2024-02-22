CREATE PROCEDURE [dbo].[SP_Categorie_GetAll]
AS
	SELECT	[Id_Categorie],
			[Nom]
	FROM [Categorie]
