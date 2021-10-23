using Microsoft.AspNetCore.Mvc;
using RestfullAPI.Infrastructure.Services;
using RestfullAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP1.Domain.Models.DTO;

namespace RestfullAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductController>/GetAllActive
        [HttpGet("/GetAllActive")]
        public Task<List<ProductDTO>> GetAllActive()
        {
            return _productService.GetAllActive();
        }

        [HttpGet("/GetAll")]
        public Task<List<ProductDTO>> GetAll()
        {
            return _productService.GetAll();
            
        }

        // GET api/<ProductController>/5
        [HttpGet("/GetProductByIdOrName")]
        public async Task<ProductDTO> GetProductByIdOrName(int? id, string? name)
        {
            var result = await _productService.GetProductDTOAsync(id, name);

            return result;
        }

        // POST api/<ProductController>/AddProduct
        [HttpPost("/AddProduct")]
        public Task<bool> AddProduct([FromBody] ProductDTO product)
        {
            return _productService.AddProduct(product);
        }

        // PUT api/<ProductController>/UpdateProduct
        [HttpPut("/UpdateProduct")]
        public Task<bool> Put([FromBody] ProductDTO product)
        {
            return _productService.UpdateProduct(product);
        }

        // DELETE api/<ProductController>/RemoveProduct
        [HttpDelete("/RemoveProduct")]
        public Task<bool> RemoveProduct(string? name, int? id)
        {
            return _productService.RemoveProduct(id, name);
        }
    }
}
