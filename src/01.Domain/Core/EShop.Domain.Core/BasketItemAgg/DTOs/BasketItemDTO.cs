using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.BasketItemAgg.DTOs
{
    public class BasketItemDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int BasketId { get; set; }
    }
}
