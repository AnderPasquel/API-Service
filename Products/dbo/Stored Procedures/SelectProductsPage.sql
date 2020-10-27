CREATE PROCEDURE SelectProductsPage @offset INT, @limit INT
AS
select * from Product order by Id 
OFFSET @offset ROWS 
FETCH NEXT @limit ROWS ONLY;