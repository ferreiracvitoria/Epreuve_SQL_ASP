CREATE PROCEDURE [dbo].[SP_Commande_Insert]
	@dateCommande DATETIME
AS
	INSERT INTO [Commande] ([DateCommande])
		OUTPUT [inserted].[Id_Commande]
		VALUES (@dateCommande)

