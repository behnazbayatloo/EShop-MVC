using EShop.Domain.Core.CategoryAgg.Entity;
using EShop.Domain.Core.ProductAgg.DTOs;
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
        Task<IEnumerable<GetProductDTO>> GetAllProducts(CancellationToken ct);

        Task<GetProductDTO> GetProductById(int id,CancellationToken ct);

        Task<ProductByCategory> GetProductsByCategory(int categoryId,CancellationToken ct);
        Task<int> GetStock(int pid, CancellationToken ct);
        Task<bool> UpdateStock(int pid, int newstock, CancellationToken ct);
    }
}
