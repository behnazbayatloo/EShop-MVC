using EShop.Domain.Core.BasketAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.BasketAgg.AppService
{
    public interface IBasketAppService
    {
        Task<bool> CreateBasket(BasketDTO basket, CancellationToken ct);
    }
}
