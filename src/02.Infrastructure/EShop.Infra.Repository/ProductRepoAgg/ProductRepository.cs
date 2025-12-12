using EShop.Domain.Core.CategoryAgg.Entity;
using EShop.Domain.Core.ProductAgg.Data;
using EShop.Domain.Core.ProductAgg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Repository.ProductRepoAgg
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
