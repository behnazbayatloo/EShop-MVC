using EShop.Domain.Core.BasketItemAgg.DTOs;
using EShop.Domain.Core.UserAgg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.BasketAgg.DTOs
{
    public class BasketDTO
    {
        
            public int Id { get; set; }

            public double TotalPrice { get; set; }

            public bool IsDeleted { get; set; }

            public int UserId { get; set; }
            public ApplicationUser? User { get; set; }

            public List<BasketItemDTO> BasketItems { get; set; }
        
        }
    
}
