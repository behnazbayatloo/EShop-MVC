using EShop.Domain.Core.ProductAgg.AppService;
using EShop.Domain.Core.ProductAgg.DTOs;
using EShop.Domain.Core.ProductAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.AppServices
{
    public class ProductAppService(IProductService _productsrv) : IProductAppService
    {
        public async Task<IEnumerable<GetProductDTO>> GetAllProducts(CancellationToken ct) => await _productsrv.GetAllProducts(ct);
        public async Task<GetProductDTO?> GetProducById(int id,CancellationToken ct)=> await _productsrv.GetProductById(id, ct);
    public async Task<ProductByCategory> GetProductsByCategory(int catid,CancellationToken ct)=>await _productsrv.GetProductsByCategory(catid, ct);
    }
}
