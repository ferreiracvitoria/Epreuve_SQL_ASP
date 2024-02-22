CREATE PROCEDURE [dbo].[SP_Commande_GetById]
	@id_commande INT
AS
	SELECT	[Id_Commande],
			[DateCommande]
			FROM [Commande]
			WHERE [Id_Commande] = @id_commande
