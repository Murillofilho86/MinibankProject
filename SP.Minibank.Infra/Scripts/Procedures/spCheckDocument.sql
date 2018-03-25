CREATE PROCEDURE spCheckDocument
	@Document CHAR(MAX)
AS
	SELECT CASE WHEN EXISTS (
		SELECT [Id]
		FROM [Customer]
		WHERE [Document] = @Document
	)
	THEN CAST(1 AS BIT)
	ELSE CAST(0 AS BIT) END

