using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.ProductAgg.DTOs
{
    public class GetProductDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public double Price { get; set; }
        public int Stock {  get; set; }
        public string CategoryName { get; set; }
    }
}
