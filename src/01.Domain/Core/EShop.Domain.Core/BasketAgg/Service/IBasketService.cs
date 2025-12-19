using EShop.Domain.Core.BasketAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.BasketAgg.Service
{
    public interface IBasketService
    {
        Task<int> AddBasket(BasketDTO basket, CancellationToken ct);
    }
}
