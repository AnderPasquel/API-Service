using api.persistance.ConnectionProvider;
using api.persistance.DTO;
using api.persistance.Models;
using api.persistance.Repositories.Interface;
using api.persistance.Utils;
using api.service.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace api.service.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;
        public ProductService(IProductRepository repository) 
        {
            _repository = repository;
        }
        public IEnumerable<Products> GetAll() 
        {
            return _repository.GetAll();
        }
        public IEnumerable<Products> GetPage(PageManager manager)
        {
            return _repository.GetPage(manager);
        }
        public IEnumerable<Products> GetDetail(PageManager manager)
        {
            return _repository.GetPage(manager);
        }
        public Products GetDetail(int Id)
        {
            return _repository.GetDetail(Id);
        }      
        public Products CreateProduct(ProductDTO dto)
        {
            return _repository.CreateProduct(dto);
        }
        public Products UpdateProduct(int Id, ProductDTO dto)
        {
            return _repository.UpdateProduct(Id,dto);
        }
        public void DeleteById(int Id)
        {
            _repository.DeleteById(Id);
        }
    }
}
