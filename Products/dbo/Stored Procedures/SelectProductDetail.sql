CREATE PROCEDURE SelectProductDetail @Id INT
AS
SELECT * FROM Product WHERE Id = @Id;
