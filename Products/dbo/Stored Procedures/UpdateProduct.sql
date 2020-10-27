CREATE PROCEDURE UpdateProduct @Id int, @Name NVARCHAR(250), @Price money, @Creation datetime2, @Modification datetime2
AS
UPDATE [Product]
SET Name = @Name, Price = @Price, Creation = @Creation, Modification = @Modification
WHERE Id = @Id;

SELECT * FROM [Product] WHERE Id = @Id
