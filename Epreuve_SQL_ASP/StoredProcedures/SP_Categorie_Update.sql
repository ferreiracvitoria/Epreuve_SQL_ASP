CREATE PROCEDURE [dbo].[SP_Categorie_Update]
	@id_categorie INT,
	@nom VARCHAR (64)
AS
	UPDATE	[Categorie]
		SET [Nom] = @nom
		WHERE [Id_Categorie] = @id_categorie
