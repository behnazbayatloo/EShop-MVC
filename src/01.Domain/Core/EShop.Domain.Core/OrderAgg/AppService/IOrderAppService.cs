using EShop.Domain.Core.OrderAgg.DTOs;
using EShop.Domain.Core.OrderItemAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.OrderAgg.AppService
{
    public interface IOrderAppService
    {
        Task<bool> CreateOrder(OrderDTO orderDTO, CancellationToken ct);
        Task<List<OrderItemDTO>> GetItemsByOrderId(int id, CancellationToken ct);
        Task<List<OrderDTO>> GetOrderByUserId(int userid, CancellationToken ct);
    }
}
