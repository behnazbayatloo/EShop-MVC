using EShop.Domain.Core.OrderAgg.AppService;
using EShop.Domain.Core.OrderAgg.DTOs;
using EShop.Domain.Core.OrderAgg.Service;
using EShop.Domain.Core.OrderItemAgg.DTOs;
using EShop.Domain.Core.OrderItemAgg.Service;
using EShop.Domain.Core.ProductAgg.Service;
using EShop.Domain.Core.UserAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.AppServices
{
    public class OrderAppService(IOrderService orderService,IOrderItemService orderItemService,IApplicationUserService _user,IProductService product):IOrderAppService
    {
        public async Task<bool> CreateOrder(OrderDTO orderDTO,CancellationToken ct)
        {
            orderDTO.TotalAmount = orderDTO.OrderItems.Sum(o => o.Price);
            var ballance = await _user.GetBallance(orderDTO.UserId, ct);
         
            if (ballance > orderDTO.TotalAmount)
            {
                var orderid = await orderService.AddOrder(orderDTO, ct);
               
                foreach (var item in orderDTO.OrderItems)
                {
                    item.OrderId = orderid;
                  
                }

                await orderItemService.AddOrderItem(orderDTO.OrderItems, ct);
                foreach(var item in orderDTO.OrderItems)
                {
                    var stock = await product.GetStockById(item.ProductId, ct);
                    var newAmount = stock - item.Quantity;
                    await product.UpdateStock(item.ProductId,newAmount,ct);
                }
                var newBallance = ballance - orderDTO.TotalAmount;
                await _user.UpdateBallance(orderDTO.UserId,newBallance, ct);
                return await orderService.UpdateIspaid(true, orderid, ct);

            }
            else return false;
            
        }
        public async Task<List<OrderDTO>> GetOrderByUserId(int userid ,CancellationToken ct)=> await orderService.GetOrdersByUserId(userid, ct);
          public async Task<List<OrderItemDTO>> GetItemsByOrderId(int id,CancellationToken ct)=> await orderItemService.GetItemsByOrderId(id, ct);
    }
}
