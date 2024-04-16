CREATE PROCEDURE [dbo].[SP_Section_GetByID]
	@id_section INT 
AS
	SELECT	*
	FROM [Section]
	WHERE [Id_Section] = @id_section
