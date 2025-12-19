using EShop.Domain.Core.ProductAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.ProductAgg.Service
{
    public interface IProductService
    {
        Task<IEnumerable<GetProductDTO>> GetAllProducts(CancellationToken ct);
        Task<GetProductDTO> GetProductById(int id, CancellationToken ct);
        Task<ProductByCategory> GetProductsByCategory(int catid, CancellationToken ct);
        Task<int> GetStockById(int pid, CancellationToken ct);
        Task<bool> UpdateStock(int pid, int amount, CancellationToken ct);
    }
}
