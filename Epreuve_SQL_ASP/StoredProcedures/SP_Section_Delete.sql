CREATE PROCEDURE [dbo].[SP_Section_Delete]
	@id_section INT
AS
	DELETE FROM [Section]
	WHERE [Id_Section] = @id_section