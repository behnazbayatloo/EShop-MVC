using EShop.Domain.Core.BasketAgg.Entity;
using EShop.Domain.Core.ProductAgg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.BasketItemAgg.Entity
{
    public class BasketItem
    {
        public int Id { get; set; }
    
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Price { get; set; }

        #region Navigation Prop
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BasketId {  get; set; }
        public Basket Basket { get; set; }
        #endregion
    }
}
