CREATE PROCEDURE [dbo].[SP_Section_Update]
	@id_section INT,
	@id_commande INT,
	@id_produit INT,
	@quantite INT
AS
	UPDATE [Section]
		SET [Id_Commande] = @id_commande,
			[Id_Produit] = @id_produit,
			[Quantite] = @quantite
		WHERE [Id_Section] = @id_section