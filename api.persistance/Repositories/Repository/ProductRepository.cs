using api.persistance.ConnectionProvider;
using api.persistance.Models;
using api.persistance.Repositories.Interface;
using System;
using System.Collections.Generic;
using Dapper;
using System.Text;
using System.Linq;
using api.persistance.Utils;
using api.persistance.DTO;

namespace api.persistance.Repositories.Repository
{
    public class ProductRepository : IProductRepository
    {
        /// <summary> Instancia de la clase <see cref="ConnectionProvider"/> encargada de las conexiones a BDs.</summary>
        private IConnectionProvider _context;
        public ProductRepository(IConnectionProvider context)
        {
            _context = context;
        }
        public IEnumerable<Products> GetAll()
        {
            using (var connection = _context.GetConnection())
            {
                var products = connection.Query<Products>("SELECT * FROM Product");
                return products;                
            }            
        }
        public Products GetDetail(int Id)
        {
            var procedure = "EXEC [SelectProductDetail] @Id";
            var value = new { Id = Id };
            using (var connection = _context.GetConnection())
            {
                var products = connection.Query<Products>(procedure, value).FirstOrDefault();
                return products;
            }
        }
        public IEnumerable<Products> GetPage(PageManager manager)
        {
            var procedure = "EXEC [SelectProductsPage] @offset, @limit";
            var values = new { offset = manager.Offset, limit = manager.PageSize };
            using (var connection = _context.GetConnection())
            {
                var products = connection.Query<Products>(procedure, values);
                return products;
            }
        }
        public Products CreateProduct(ProductDTO dto)
        {
            var procedure = "EXEC [CreateProduct] @Name, @Price, @Creation, @Modification";
            var value = new { Name = dto.Name, Price = dto.Price, Creation = dto.Creation, Modification = dto.Modification };
            using (var connection = _context.GetConnection())
            {
                var products = connection.Query<Products>(procedure, value).FirstOrDefault();
                return products;
            }
        }
        public Products UpdateProduct(int Id,ProductDTO dto)
        {
            var procedure = "EXEC [UpdateProduct] @Id, @Name, @Price, @Creation, @Modification";
            var value = new { Id = Id, Name = dto.Name, Price = dto.Price, Creation = dto.Creation, Modification = dto.Modification };
            using (var connection = _context.GetConnection())
            {
                var products = connection.Query<Products>(procedure, value).FirstOrDefault();
                return products;
            }
        }
        public void DeleteById(int Id)
        {
            var procedure = "EXEC [DeleteProduct] @Id";
            var value = new { Id = Id };
            using (var connection = _context.GetConnection())
            {
                var products = connection.Query<Products>(procedure, value);              
            }
        }
    }
}
