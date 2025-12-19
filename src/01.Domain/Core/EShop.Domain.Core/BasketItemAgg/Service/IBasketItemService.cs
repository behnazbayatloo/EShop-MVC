using EShop.Domain.Core.BasketItemAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.BasketItemAgg.Service
{
    public interface IBasketItemService
    {
        Task<bool> AddBasketItem(List<BasketItemDTO> basketItem, CancellationToken ct);
    }
}
