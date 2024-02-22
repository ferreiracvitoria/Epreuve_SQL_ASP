CREATE PROCEDURE [dbo].[SP_Categorie_Insert]
	@nom VARCHAR (64)
AS
	INSERT INTO [Categorie] ([Nom])
		OUTPUT [inserted].[Id_Categorie]
		VALUES (@nom)