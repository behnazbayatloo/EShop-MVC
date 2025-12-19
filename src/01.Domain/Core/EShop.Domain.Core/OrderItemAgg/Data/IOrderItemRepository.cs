using EShop.Domain.Core.OrderItemAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.OrderItemAgg.Data
{
    public interface IOrderItemRepository
    {
        Task<bool> Add(List<OrderItemDTO> orderItems, CancellationToken cancellationToken);
        Task<List<OrderItemDTO>> GetOrderItemsByOrderId(int id, CancellationToken ct);
    }
}
