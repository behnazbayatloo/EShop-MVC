using EShop.Domain.Core.ProductAgg.AppService;
using EShop.Presentation.MVC.Areas.Product.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EShop.Presentation.MVC.Areas.Product.Controllers
{
    [Area("Product")]
    public class ProductController(IProductAppService _product) : Controller
    {
        public async Task<IActionResult> Index(int id,CancellationToken ct)
        {
            var product = await _product.GetProducById(id,ct);
            ProductDetailViewModel viewModel =new ProductDetailViewModel { Product= product} ;
            return View(viewModel);
        }
    }
}
