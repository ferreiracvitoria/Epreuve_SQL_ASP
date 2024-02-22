CREATE PROCEDURE [dbo].[SP_Section_GetByID]
	@id_section INT 
AS
	SELECT	[Id_Section],
			[Id_Commande],
			[Id_Produit],
			[Quantite]
			FROM [Section]
			WHERE [Id_Section] = @id_section
