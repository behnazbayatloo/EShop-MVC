using EShop.Domain.Core.OrderAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.OrderAgg.Data
{
    public interface IOrderRepository
    {
        Task<int> Add(OrderDTO orderDTO, CancellationToken cancellationToken);
        Task<List<OrderDTO>> GetOrderByUserId(int userid, CancellationToken ct);
        Task<bool> IsPaid(bool isPaid, int orderId, CancellationToken ct);
    }
}
