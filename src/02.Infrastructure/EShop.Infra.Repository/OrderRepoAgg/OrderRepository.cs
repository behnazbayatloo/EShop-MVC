using EShop.Domain.Core.OrderAgg.Data;
using EShop.Domain.Core.OrderAgg.DTOs;
using EShop.Domain.Core.OrderAgg.Entity;
using EShop.Domain.Core.OrderItemAgg.DTOs;
using EShop.Infra.Db.Sql.DbCtx;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Repository.OrderRepoAgg
{
    public class OrderRepository(AppDbContext _context) : IOrderRepository
    {
        public async Task<int> Add(OrderDTO orderDTO,CancellationToken cancellationToken)
        {
            var order = new Order
            {
                CreatedAt=DateTime.Now,
                OrderDate = DateTime.Now,
                TotalAmount=orderDTO.TotalAmount,
                UserId=orderDTO.UserId,
               
            };
            await _context.Orders.AddAsync(order, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return order.Id;
        }
        public async Task<bool> IsPaid (bool  isPaid,int orderId,CancellationToken ct)
        {
            await _context.Orders.Where(o => o.Id == orderId)
                .ExecuteUpdateAsync(s => s.SetProperty(o => o.IsPaid, isPaid), ct);
            return true;
        }

        public async Task<List<OrderDTO>> GetOrderByUserId(int userid,CancellationToken ct)
        {
            return await _context.Orders.AsNoTracking().Where(o => o.UserId == userid).Select(o => new OrderDTO
            {
                Id= o.Id,
                OrderDate = o.OrderDate,
                TotalAmount = o.TotalAmount,
                OrderItemCount = o.OrderItems.Count

            }).ToListAsync(ct);
        }
        
    }
}
