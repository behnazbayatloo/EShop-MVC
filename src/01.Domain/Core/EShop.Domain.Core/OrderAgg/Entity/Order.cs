using EShop.Domain.Core.UserAgg.Entity;
using EShop.Domain.Core.OrderItemAgg.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.OrderAgg.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public bool IsPaid { get; set; }
        public bool IsDeleted { get; set; }


        #region Navigation Prop
        public List<OrderItem> OrderItems { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
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
