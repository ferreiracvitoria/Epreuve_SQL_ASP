CREATE PROCEDURE [dbo].[SP_Commande_Update]
	@id_commande INT,
	@dateCommande DATETIME
AS
	UPDATE [Commande]
		SET	[DateCommande] = @dateCommande
		WHERE [Id_Commande] = @id_commande
