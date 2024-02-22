CREATE PROCEDURE [dbo].[SP_Section_Insert]
	@id_commande INT,
	@id_produit INT,
	@quantite INT
AS
	INSERT INTO [Section] ([Id_Commande], [Id_Produit], [Quantite])
		OUTPUT [inserted].[Id_Section]
		VALUES (@id_commande, @id_produit, @quantite)
