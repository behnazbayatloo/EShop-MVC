using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.ProductAgg.DTOs
{
    public class ProductByCategory
    {
        public IEnumerable<GetProductDTO> Products { get; set; }
        public string? CategoryName { get; set; }
    }
}
