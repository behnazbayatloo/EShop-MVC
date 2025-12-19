using EShop.Domain.Core.CategoryAgg.DTOs;
using EShop.Domain.Core.ProductAgg.Data;
using EShop.Domain.Core.ProductAgg.DTOs;
using EShop.Domain.Core.ProductAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Services
{
    public class ProductService (IProductRepository _prorepo):IProductService
    {
        public async Task<IEnumerable<GetProductDTO>> GetAllProducts(CancellationToken ct) => await _prorepo.GetAllProducts(ct);
        public async Task<GetProductDTO?> GetProductById(int id , CancellationToken ct) => await _prorepo.GetProductById(id,ct);
        public async Task<ProductByCategory> GetProductsByCategory(int catid, CancellationToken ct) => await _prorepo.GetProductsByCategory(catid, ct);
  
    public async Task<int> GetStockById (int pid,CancellationToken ct)=> await _prorepo.GetStock(pid,ct);   
        public async Task<bool> UpdateStock (int pid,int amount,CancellationToken ct)=> await _prorepo.UpdateStock(pid,amount,ct);
    }
}
