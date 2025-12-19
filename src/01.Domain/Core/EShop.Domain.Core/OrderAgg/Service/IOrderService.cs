using EShop.Domain.Core.OrderAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.OrderAgg.Service
{
    public interface IOrderService
    {
        Task<int> AddOrder(OrderDTO orderDTO, CancellationToken ct);
        Task<List<OrderDTO>> GetOrdersByUserId(int userid, CancellationToken ct);
        Task<bool> UpdateIspaid(bool ispaid, int orderId, CancellationToken ct);
    }
}
