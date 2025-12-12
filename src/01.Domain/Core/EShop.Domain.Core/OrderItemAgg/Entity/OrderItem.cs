using EShop.Domain.Core.OrderAgg.Entity;
using EShop.Domain.Core.ProductAgg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.OrderItemAgg.Entity
{
    public class OrderItem
    {
        public int Id { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }


        #region Navigation Prop
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        #endregion




    }
}
