using EShop.Domain.Core.CategoryAgg.AppService;
using EShop.Domain.Core.ProductAgg.AppService;
using EShop.Domain.Core.ProductAgg.DTOs;
using EShop.Presentation.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Presentation.MVC.Areas.Product.Controllers
{
    [Area("Product")]
    public class CategoryController(IProductAppService _product,ICategoryAppService _catapp) : Controller
    {
        public async Task< IActionResult> Index(int categoryId,CancellationToken ct)
        {
            var product = await _product.GetProductsByCategory(categoryId, ct);
            var category = await _catapp.GetAllCategories(ct);
            var products = new HomeIndexViewModel();
            products.Products= product.Products.Select(p=> new GetProductDTO
            {
                Id=p.Id,
                Title = p.Title,
                Description= !string.IsNullOrEmpty(p.Description)?( p.Description.Length>7 ? p.Description.Substring(0,7)+"..." :p.Description):string.Empty,
                ImageUrl =p.ImageUrl,
                Stock = p.Stock,
                Price=p.Price,
                CategoryName = p.CategoryName
            } ).ToList();
            products.Categories = category;
            products.CategoryName = product.CategoryName;
            return View(products);
        }
    }
}
