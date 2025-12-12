using EShop.Domain.Core.BasketAgg.Entity;
using EShop.Domain.Core.OrderAgg.Entity;
using EShop.Domain.Core.UserAgg.Enum;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.UserAgg.Entity
{
    public class ApplicationUser : IdentityUser<int>
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }

        #region Navigation Prop
        public List<Basket>? Baskets { get; set; }
        public List<Order>? Orders { get; set; }

        #endregion

        #region Audit 
        public DateTime CreatedAt { get; set; }
        
        public DateTime? UpdatedAt { get; set; }
        
        public DateTime? DeletedAt { get; set; }
        #endregion
    }
}
