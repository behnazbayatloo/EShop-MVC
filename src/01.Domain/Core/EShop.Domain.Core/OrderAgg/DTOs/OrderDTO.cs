using EShop.Domain.Core.OrderItemAgg.DTOs;
using EShop.Domain.Core.OrderItemAgg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.OrderAgg.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public bool IsPaid { get; set; }
        public List<OrderItemDTO> OrderItems { get; set; }
        public int UserId { get; set; }
        public int OrderItemCount { get; set; }
    }
}
