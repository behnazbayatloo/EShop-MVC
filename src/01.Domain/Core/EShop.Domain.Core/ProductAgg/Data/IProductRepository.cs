using EShop.Domain.Core.CategoryAgg.Entity;
using EShop.Domain.Core.ProductAgg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.ProductAgg.Data
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();

        Task<Product> GetProductById(int id);

        Task<IEnumerable<Product>> GetProductsByCategory(int categoryId);

        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category>GetCategoryById(int id);

    }
}
