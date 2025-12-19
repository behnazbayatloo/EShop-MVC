using EShop.Domain.Core.BasketItemAgg.Data;
using EShop.Domain.Core.BasketItemAgg.DTOs;
using EShop.Domain.Core.BasketItemAgg.Entity;
using EShop.Infra.Db.Sql.DbCtx;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Repository.BasketItemRepoAgg
{
    public class BasketItemRepository(AppDbContext _context):IBasketItemRepository
    {
      public async Task<bool> Add(List<BasketItemDTO> basketitem,CancellationToken ct)
        {
            var list =new List<BasketItem>();
            foreach (var item in basketitem)
            {
                var basketItem = new BasketItem()
                {
                    BasketId = item.BasketId,
                    Price =item.Price,
                    Quantity = item.Quantity,
                    ProductId = item.ProductId,
                    UnitPrice = item.UnitPrice
                };
                list.Add(basketItem);
            }
            await _context.BasketItems.AddRangeAsync(list, ct);
               return  await _context.SaveChangesAsync(ct)>0;
            
               
        }
    }
}
