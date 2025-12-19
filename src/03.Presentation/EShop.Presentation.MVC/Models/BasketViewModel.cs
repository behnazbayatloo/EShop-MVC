using EShop.Presentation.MVC.Models;
using EShop.Domain.Core.UserAgg.Entity;

namespace EShop.Presentation.MVC.Models
{
    public class BasketViewModel
    {
        public int Id { get; set; }

        public double TotalPrice { get; set; }

        public bool IsDeleted { get; set; }
       
        public int? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public List<BasketItemViewModel> BasketItems { get; set; }
        public int BasketItemCount { get; set; }
        public DateTime Created {  get; set; }
    }
}
