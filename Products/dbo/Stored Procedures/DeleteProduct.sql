CREATE PROCEDURE DeleteProduct @Id INT
AS
Delete from Product where Id = @Id