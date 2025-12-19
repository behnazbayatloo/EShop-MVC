using EShop.Domain.Core.BasketAgg.AppService;
using EShop.Domain.Core.BasketAgg.DTOs;
using EShop.Domain.Core.BasketAgg.Service;
using EShop.Domain.Core.BasketItemAgg.DTOs;
using EShop.Domain.Core.BasketItemAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.AppServices
{
    public class BasketAppService(IBasketService _basketservice,IBasketItemService _basketitemservice) :IBasketAppService
    {
        public async Task<bool> CreateBasket (BasketDTO basket,CancellationToken ct)
        {
            var basketid= await _basketservice.AddBasket(basket,ct);
          foreach(var item in basket.BasketItems)
            {
                item.BasketId = basketid;
            }
          basket.TotalPrice=basket.BasketItems.Sum(x => x.Price);
         return await _basketitemservice.AddBasketItem(basket.BasketItems,ct);
        }
    }
}
