using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
namespace Core.Interface
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>>GetProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        void DeleteProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        Task<bool> SaveProductAsync(Product product);

    }
}
