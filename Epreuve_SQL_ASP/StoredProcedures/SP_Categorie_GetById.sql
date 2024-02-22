CREATE PROCEDURE [dbo].[SP_Categorie_GetById]
	@id_categorie INT
AS
	SELECT	[Id_Categorie],
			[Nom]			
			FROM [Categorie]
	WHERE [Id_Categorie] = @id_categorie
