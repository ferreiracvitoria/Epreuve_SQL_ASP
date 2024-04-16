CREATE PROCEDURE [dbo].[SP_Produit_GetByCritere]
	@CritereEcologique NVARCHAR(64)
AS
	SELECT *
	FROM Produit
	WHERE CritereEcologique = @CritereEcologique