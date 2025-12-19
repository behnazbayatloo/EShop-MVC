using EShop.Domain.Core.OrderItemAgg.Data;
using EShop.Domain.Core.OrderItemAgg.DTOs;
using EShop.Domain.Core.OrderItemAgg.Entity;
using EShop.Infra.Db.Sql.DbCtx;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Repository.OrderItemRepoAgg
{
    public class OrderItemRepository(AppDbContext _context) : IOrderItemRepository
    {
        public async Task<bool> Add(List<OrderItemDTO> orderItems, CancellationToken cancellationToken)
        {
            var list = new List<OrderItem>();
            foreach (var item in orderItems)
            {
                var orderItem = new OrderItem
                {
                    OrderId = item.OrderId
                ,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Price = item.UnitPrice * item.Quantity
                };
                list.Add(orderItem);
            }
            await _context.OrderItems.AddRangeAsync(list, cancellationToken);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<List<OrderItemDTO>> GetOrderItemsByOrderId(int id, CancellationToken ct)
        {
            return await _context.OrderItems.AsNoTracking().Where(o => o.OrderId == id)
                .Select(o => new OrderItemDTO
                {
                    ProductName = o.Product.Title,
                    Price = o.Price,
                    Quantity = o.Quantity,
                    UnitPrice = o.UnitPrice,
                }).ToListAsync(ct);
        }
    }
}
