CREATE PROCEDURE CreateProduct @Name NVARCHAR(250), @Price money, @Creation datetime2, @Modification datetime2
AS

INSERT INTO [Product]
           ([Name]
           ,[Price]
           ,[Creation]
           ,[Modification])
     VALUES
           (@Name,@Price,@Creation,@Modification)
SELECT * FROM [Product] WHERE Id = (SELECT MAX(ID) FROM [Product])
