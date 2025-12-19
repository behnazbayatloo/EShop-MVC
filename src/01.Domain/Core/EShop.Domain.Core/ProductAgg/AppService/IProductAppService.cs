using EShop.Domain.Core.ProductAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.ProductAgg.AppService
{
    public interface IProductAppService
    {
        Task<IEnumerable<GetProductDTO>> GetAllProducts(CancellationToken ct);
        Task<GetProductDTO?> GetProducById(int id, CancellationToken ct);
        Task<ProductByCategory> GetProductsByCategory(int catid, CancellationToken ct);
    }
}
