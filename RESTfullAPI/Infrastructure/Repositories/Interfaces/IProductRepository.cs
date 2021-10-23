using RestfullAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestfullAPI.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllActive();
        Task<List<Product>> GetAll();
        Task<bool> AddProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> RemoveProduct(int? id, string? name);
        Task<Product> GetProductAsync(int? id, string? name);


    }
}
