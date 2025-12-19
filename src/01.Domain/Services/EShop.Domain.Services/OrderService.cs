using EShop.Domain.Core.OrderAgg.Data;
using EShop.Domain.Core.OrderAgg.DTOs;
using EShop.Domain.Core.OrderAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Services
{
    public class OrderService(IOrderRepository _orderrepo):IOrderService
    {
        public async Task<int> AddOrder(OrderDTO orderDTO,CancellationToken ct)=>await _orderrepo.Add(orderDTO, ct);
        public async Task<bool> UpdateIspaid(bool ispaid, int orderId, CancellationToken ct) => await _orderrepo.IsPaid(ispaid, orderId, ct);
   public async Task<List<OrderDTO>> GetOrdersByUserId(int userid,CancellationToken ct)=>await _orderrepo.GetOrderByUserId(userid, ct);
    }
}
