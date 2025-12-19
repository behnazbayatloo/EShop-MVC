using EShop.Presentation.MVC.Framework;
using EShop.Presentation.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EShop.Presentation.MVC.Areas.Product.Controllers
{
    [Area("Product")]
    public class AddToBasketController : Controller
    {
        public IActionResult Index()
        {
            var basket = HttpContext.Session.GetObjectFromJson<BasketViewModel>("Basket")
            ?? new BasketViewModel { BasketItems = new List<BasketItemViewModel>() };
            return View(basket);
        }

        [HttpPost]
        public IActionResult Add(BasketItemViewModel basketitem)
        {
            var basket = HttpContext.Session.GetObjectFromJson<BasketViewModel>("Basket")
                ?? new BasketViewModel { BasketItems = new List<BasketItemViewModel>() };
            var item = new BasketItemViewModel
            {
                Title=basketitem.Title,
                UnitPrice = basketitem.UnitPrice,
                Quantity = basketitem.Quantity,
                Price = basketitem.UnitPrice * basketitem.Quantity,
                ProductId=basketitem.ProductId
            };
            basket.BasketItems.Add(item);
            basket.TotalPrice = basket.BasketItems.Sum(x => x.Price);
            HttpContext.Session.SetObjectAsJson("Basket", basket);
            return RedirectToAction("Index","Home",new {area=""});
        }
        [HttpPost]
        public IActionResult Remove (int itemid)
        {
            var basket = HttpContext.Session.GetObjectFromJson<BasketViewModel>("Basket")
                ?? new BasketViewModel { BasketItems = new List<BasketItemViewModel>() };
            var item=basket.BasketItems.Where(b=>b.Id==itemid).FirstOrDefault();
            basket.BasketItems.Remove(item);
            basket.TotalPrice = basket.BasketItems.Sum(x => x.Price);
            HttpContext.Session.SetObjectAsJson("Basket", basket);
            return RedirectToAction("Index");

        }
    }
}
