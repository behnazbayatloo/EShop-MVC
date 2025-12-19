using EShop.Domain.Core.CategoryAgg.Entity;
using EShop.Domain.Core.ProductAgg.Data;
using EShop.Domain.Core.ProductAgg.DTOs;
using EShop.Domain.Core.ProductAgg.Entity;
using EShop.Infra.Db.Sql.DbCtx;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Repository.ProductRepoAgg
{
    public class ProductRepository (AppDbContext _context ,ILogger<ProductRepository> log) : IProductRepository
    {
       
        
        public async Task<IEnumerable<GetProductDTO>> GetAllProducts(CancellationToken ct)
        {
            return await _context.Products.AsNoTracking().Where(p => !p.IsDeleted)
           .Select(p => new GetProductDTO
           {
               Id=p.Id,
               Description=p.Description
               ,ImageUrl=p.ImageUrl,
               Price= p.Price,
               Title = p.Title,
               Stock=p.Stock
           }).ToListAsync(ct);
                }

        

        public async Task<GetProductDTO?> GetProductById(int id,CancellationToken ct)
        {
            return await _context.Products.AsNoTracking().Where(p => !p.IsDeleted).Select(p => new GetProductDTO
            {
                Id=p.Id,
                Description=p.Description,
                ImageUrl=p.ImageUrl,
                Price= p.Price,
                Title= p.Title,
                Stock=p.Stock
                ,CategoryName=p.Category.Name
                
            } ).FirstOrDefaultAsync(ct);
        }

        public async Task<ProductByCategory?> GetProductsByCategory(int categoryId, CancellationToken ct)
        {
            var products = new ProductByCategory();
            products.Products= await _context.Products.AsNoTracking().Where(p => !p.IsDeleted && p.CategoryId == categoryId).Select(p => new GetProductDTO
            {
                CategoryName = p.Category.Name,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Price = p.Price,
                Title = p.Title,
                Stock = p.Stock
               ,
                Id = p.Id

            }).ToListAsync(ct);
            products.CategoryName = await _context.Categories.AsNoTracking().Where(c => c.Id == categoryId).Select(c => c.Name).FirstOrDefaultAsync(ct);
            return products;
        }

        public async Task<int> GetStock(int pid,CancellationToken ct)
        {
            return await _context.Products.AsNoTracking().Where(p=>p.Id==pid).Select(p=>p.Stock).FirstOrDefaultAsync(ct);
        }
        public async Task<bool> UpdateStock(int pid,int newstock, CancellationToken ct)
        {
            await _context.Products.ExecuteUpdateAsync(s => s.SetProperty(p => p.Stock, newstock), ct);
            return true;
        }
    }
}
