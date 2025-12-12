using EShop.Domain.Core.OrderItemAgg.Entity;
using EShop.Domain.Core.ProductAgg.Entity;
using EShop.Domain.Core.UserAgg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.CategoryAgg.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        #region Navigation Prop
        
        public List<Product>? Products { get; set; }
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
