using api.persistance.DTO;
using api.persistance.Models;
using api.persistance.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace api.persistance.Repositories.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAll();
        IEnumerable<Products> GetPage(PageManager manager);
        Products GetDetail(int Id);
        Products CreateProduct(ProductDTO dto);
        Products UpdateProduct(int Id, ProductDTO dto);
        void DeleteById(int Id);
    }
}
