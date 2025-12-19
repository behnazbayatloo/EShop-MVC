using EShop.Domain.Core.ProductAgg.DTOs;
using EShop.Presentation.MVC.Models;

namespace EShop.Presentation.MVC.Areas.Product.Models
{
    public class ProductDetailViewModel
    {
        public GetProductDTO Product {  get; set; }
        public BasketItemViewModel? BasketItem { get; set; }
    }
}
