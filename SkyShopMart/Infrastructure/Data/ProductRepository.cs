using Core.Entities;
using Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepository(StoreContext context) : IProductRepository
    {
        public void AddProduct(Product product)
        {
            context.SaveChangesAsync();
        }

        public void DeleteProductById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
           return await context.products.FindAsync(id);
        }

        public Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
