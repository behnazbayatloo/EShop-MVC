using EShop.Domain.Core.BasketAgg.Data;
using EShop.Domain.Core.BasketAgg.DTOs;
using EShop.Domain.Core.BasketAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Services
{
    public class BasketService(IBasketRepository _basket):IBasketService
    {
        public async Task<int> AddBasket (BasketDTO basket,CancellationToken ct)=>await _basket.Add(basket, ct);
    }
}
