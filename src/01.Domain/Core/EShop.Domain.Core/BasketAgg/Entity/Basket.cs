using EShop.Domain.Core.BasketItemAgg.Entity;
using EShop.Domain.Core.UserAgg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.BasketAgg.Entity
{
    public class Basket
    {   
        public int Id { get; set; }
        
        public double TotalPrice { get; set; }

        public bool IsDeleted { get; set; }
        #region Navigation Prop
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }

        public List<BasketItem> BasketItems { get; set; }
        #endregion
        #region Audit 
        public DateTime CreatedAt { get; set; }
        public int CreatedByUserId { get; set; }
        //public ApplicationUser CreatedByUser { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedByUserId { get; set; }
        //public ApplicationUser? UpdatedByUser { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedByUserId { get; set; }
        //public ApplicationUser? DeletedByUser { get; set; }
        #endregion
    }
}
