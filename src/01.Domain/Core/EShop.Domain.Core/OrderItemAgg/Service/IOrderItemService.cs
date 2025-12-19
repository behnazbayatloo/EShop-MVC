using EShop.Domain.Core.OrderItemAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.OrderItemAgg.Service
{
    public interface IOrderItemService
    {
        Task<bool> AddOrderItem(List<OrderItemDTO> orderItemDTOs, CancellationToken ct);
        Task<List<OrderItemDTO>> GetItemsByOrderId(int id, CancellationToken ct);
    }
}
