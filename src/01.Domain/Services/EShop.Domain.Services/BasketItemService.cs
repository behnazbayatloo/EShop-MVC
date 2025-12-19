using EShop.Domain.Core.BasketItemAgg.Data;
using EShop.Domain.Core.BasketItemAgg.DTOs;
using EShop.Domain.Core.BasketItemAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Services
{
    public class BasketItemService(IBasketItemRepository _basketitem):IBasketItemService
    {
        public async Task<bool> AddBasketItem(List<BasketItemDTO> basketItem,CancellationToken ct)=>await _basketitem.Add(basketItem,ct);
    }
}
