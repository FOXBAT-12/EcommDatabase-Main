using Ecomm_Database_Class.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomm_Database_Class.Repository.IRepository
{
    public interface IProductRepository
    {
        // Basic CRUD operations
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<Product> AddAsync(Product product);
        Task<Product?> UpdateAsync(Product product);
        Task<bool> DeleteAsync(int id);

        // Get products by Category
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);

        // Get best-selling products (top N by SoldCount)
        Task<IEnumerable<Product>> GetBestSellingProductsAsync(int count);

        // Search, Filter and Sort
        Task<IEnumerable<Product>> SearchFilterSortAsync(string? search, int? categoryId, string? sortBy);
    }
}
