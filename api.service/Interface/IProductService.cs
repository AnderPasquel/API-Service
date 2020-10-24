using api.persistance.DTO;
using api.persistance.Models;
using api.persistance.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace api.service.Interface
{
    public interface IProductService
    {
        IEnumerable<Products> GetAll(); 
        IEnumerable<Products> GetPage(PageManager manager);
        Products GetDetail(int Id);
        Products CreateProduct(ProductDTO dto);
        Products UpdateProduct(int Id, ProductDTO dto);
        void DeleteById(int Id);
    }
}
