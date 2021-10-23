using AutoMapper;
using RestfullAPI.Infrastructure.Repositories;
using RestfullAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP1.Domain.Models.DTO;

namespace RestfullAPI.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDTO>> GetAllActive()
        {
            var products = await _productRepository.GetAllActive();
            var aux = _mapper.Map<List<ProductDTO>>(products);

            return aux;

        }

        public async Task<List<ProductDTO>> GetAll()
        {
            var products = await _productRepository.GetAll();
            var aux = _mapper.Map<List<ProductDTO>>(products);

            return aux;
        }

        public async Task<bool> AddProduct(ProductDTO product)
        {

            var aux = _mapper.Map<Product>(product);

            return await _productRepository.AddProduct(aux);
        }

        public async Task<bool> UpdateProduct(ProductDTO product)
        {
            var aux = _mapper.Map<Product>(product);

            return await _productRepository.UpdateProduct(aux);
        }

        public async Task<bool> RemoveProduct(int? id, string? name)
        {
            return await (_productRepository.RemoveProduct(id, name));
        }

        public async Task<ProductDTO> GetProductDTOAsync(int? id, string? name)
        {
            var aux = await _productRepository.GetProductAsync(id, name);

            var result = _mapper.Map<ProductDTO>(aux);

            return result;
        }

    }
}
