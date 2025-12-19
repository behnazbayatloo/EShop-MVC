using EShop.Domain.Core.BasketAgg.Data;
using EShop.Domain.Core.BasketAgg.DTOs;
using EShop.Domain.Core.BasketAgg.Entity;
using EShop.Infra.Db.Sql.DbCtx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Repository.BasketRepoAgg
{
    public class BasketRepository(AppDbContext _context) : IBasketRepository
    {
        public async Task<int> Add (BasketDTO basket,CancellationToken ct)
        {
            var Basket = new Basket
            {
                CreatedAt = DateTime.Now,
                UserId = basket.UserId,
                TotalPrice = basket.TotalPrice,
            };
            await _context.Baskets.AddAsync(Basket,ct);
            await _context.SaveChangesAsync(ct);
            return Basket.Id;
        }
    }
}
