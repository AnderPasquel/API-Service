using System;
using System.Collections.Generic;
using api.persistance.DTO;
using api.persistance.Models;
using api.persistance.Utils;
using api.service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace api.web.Controllers
{
    [Produces("application/json")]
    [ApiController]
    public class ProductsController : Controller
    {
        private IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get all Products.
        /// </summary>
        [HttpGet]
        [Route("/v1/GetAll")]
        public IEnumerable<Products> GetAll() {
            return _service.GetAll();
        }

        /// <summary>
        /// Get Products Pageble.
        /// </summary>
        /// <param name="pid"></param> 
        [HttpGet]
        [Route("/v1/{pid}/products")]
        public IEnumerable<Products> GetPagable(int pid)
        {
            PageManager page = new PageManager(pid);
            return _service.GetPage(page);
        }

        /// <summary>
        /// Get Detail Product.
        /// </summary>
        /// <param name="pid"></param> 
        [HttpGet]
        [Route("/v1/products/{pid}")]
        public Products GetDetail(int pid)
        {
            return _service.GetDetail(pid);
        }

        /// <summary>
        /// Create Product.
        /// </summary>
        [HttpPost]
        [Route("/v1/products")]
        public Products CreateProduct([FromBody]ProductDTO dto)
        {
            return _service.CreateProduct(dto);
        }

        /// <summary>
        /// Update Product.
        /// </summary>
        [HttpPut]
        [Route("/v1/products/{pid}")]
        public Products UpdateProduct(int pid, [FromBody]ProductDTO dto)
        {
            return _service.UpdateProduct(pid,dto);
        }

        /// <summary>
        /// Deletes a specific Product.
        /// </summary>
        /// <param name="pid"></param> 
        [HttpDelete]
        [Route("/v1/products/{pid}")]
        public ActionResult DeleteProduct(int pid)
        {
            try
            {
                _service.DeleteById(pid);
                return Json(new { Status = "Succes" });
            }
            catch(Exception Ex)
            {
                return Json(new { Status = "Error", Message = Ex.Message });
            }
          
        }
    }
}