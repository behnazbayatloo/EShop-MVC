using EShop.Domain.Core.OrderItemAgg.Data;
using EShop.Domain.Core.OrderItemAgg.DTOs;
using EShop.Domain.Core.OrderItemAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Services
{
    public class OrderItemService(IOrderItemRepository _orderItemrepo):IOrderItemService
    {
        public async Task<bool> AddOrderItem(List<OrderItemDTO> orderItemDTOs, CancellationToken ct) => await _orderItemrepo.Add(orderItemDTOs, ct);
    public async Task<List<OrderItemDTO>> GetItemsByOrderId(int id,CancellationToken ct)=> await _orderItemrepo.GetOrderItemsByOrderId(id, ct);
    }
}
