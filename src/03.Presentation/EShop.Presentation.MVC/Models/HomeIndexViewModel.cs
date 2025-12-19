using EShop.Domain.Core.CategoryAgg.DTOs;
using EShop.Domain.Core.ProductAgg.DTOs;

namespace EShop.Presentation.MVC.Models
{
    public class HomeIndexViewModel
    {
        public List<GetCategoryDTO>? Categories { get; set; }
        public List<GetProductDTO>? Products { get; set; }
        public int? qtr {  get; set; }
       
        public string? CategoryName { get; set; }
        public BasketItemViewModel? BasketItem { get; set; }
    }
}
