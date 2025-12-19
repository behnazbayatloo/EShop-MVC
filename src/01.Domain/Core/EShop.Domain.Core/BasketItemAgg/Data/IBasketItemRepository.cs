using EShop.Domain.Core.BasketItemAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.BasketItemAgg.Data
{
    public interface IBasketItemRepository
    {
        Task<bool> Add(List<BasketItemDTO> basketitem, CancellationToken ct);
    }
}
