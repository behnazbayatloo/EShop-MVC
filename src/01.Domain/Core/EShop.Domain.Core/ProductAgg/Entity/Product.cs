using EShop.Domain.Core.CategoryAgg.Entity;
using EShop.Domain.Core.UserAgg.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.ProductAgg.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsDeleted { get; set; }

        #region Navigation Prop
        public int CategoryId { get; set; }
        public Category Category {  get; set; }
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
