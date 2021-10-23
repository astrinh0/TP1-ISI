using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RestfullAPI.Context;
using RestfullAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfullAPI.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllActive()
        {
            return await _context.Products.Where(p => p.Active == Consts.EnumActive.Y).ToListAsync();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<bool> AddProduct(Product product)
        {
            if (await _context.Products.FirstOrDefaultAsync(p => p.Name == product.Name) != null)
            {
                return false;
            }
            var result = _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            var productAux = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (productAux != null)
            {
                productAux.Name = product.Name;
                productAux.Stock = product.Stock;
                productAux.Price = product.Price;
                productAux.Active = product.Active;

                _context.Products.Update(productAux);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<bool> RemoveProduct(int? id, string? name)
        {
            Product product = new Product();

            if (name != null) { product = _context.Products.FirstOrDefault(p => p.Name == name); }

            if (id != null) { product = _context.Products.FirstOrDefault(p => p.Id == id); }

            if (product != null)
            {
                product.Active = Consts.EnumActive.N;
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<Product> GetProductAsync(int? id, string? name)
        {
            Product product = new Product();

            if (id != null) { product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id); }

            if (name != null) { product = await _context.Products.FirstOrDefaultAsync(p => p.Name == name); }

            if (product != null)
            {
                return product;
            }

            return null;
        }




    }
}
