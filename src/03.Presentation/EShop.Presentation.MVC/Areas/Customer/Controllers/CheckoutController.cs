using EShop.Domain.Core.BasketAgg.AppService;
using EShop.Domain.Core.BasketAgg.DTOs;
using EShop.Domain.Core.BasketItemAgg.DTOs;
using EShop.Domain.Core.OrderAgg.AppService;
using EShop.Domain.Core.OrderAgg.DTOs;
using EShop.Domain.Core.OrderItemAgg.DTOs;
using EShop.Domain.Core.UserAgg.Entity;
using EShop.Presentation.MVC.Framework;
using EShop.Presentation.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EShop.Presentation.MVC.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles ="Customer")]
    public class CheckoutController(UserManager<ApplicationUser> _userManager,IOrderAppService orderApp,IBasketAppService basketApp,ILogger<CheckoutController> _logger) : Controller
    {
        public IActionResult Index()
        {
            var basket = HttpContext.Session.GetObjectFromJson<BasketViewModel>("Basket")
            ?? new BasketViewModel { BasketItems = new List<BasketItemViewModel>() };
            return View(basket);
        }
        public async Task<IActionResult> Checkout(CancellationToken ct)
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = user?.Id;
            var basket = HttpContext.Session.GetObjectFromJson<BasketViewModel>("Basket")
            ?? new BasketViewModel { BasketItems = new List<BasketItemViewModel>() };
            var basketItemsList = new List<BasketItemDTO>();
            foreach (var item in basket.BasketItems)
            {
                var Item = new BasketItemDTO
                {
                    ProductId = item.ProductId,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,

                };
                basketItemsList.Add(Item);
            };
            var Basket = new BasketDTO
            {
                BasketItems = basketItemsList
               ,
                UserId = userId.Value,
               
                
            };
            await basketApp.CreateBasket(Basket, ct);
            var orderItems = new List<OrderItemDTO>();
            foreach (var item in basket.BasketItems)
            {
                var orderItem = new OrderItemDTO
                {
                    ProductId = item.ProductId,
                    UnitPrice = item.UnitPrice,
                    Quantity = item.Quantity,
                    Price = item.Price
                };
                orderItems.Add(orderItem);
            }
            var Order = new OrderDTO
            {
                OrderItems = orderItems,
                OrderDate = DateTime.Now,
              
                UserId = userId.Value,
            };
            var result= await orderApp.CreateOrder(Order, ct);
            if (result)
            {
                HttpContext.Session.Remove("Basket");
                TempData["SuccessMessage"] = "سفارش با موفقیت ثبت شد";
                return RedirectToAction("Index", "ShowOrder",new {area="Customer"});
            }
            else
            {
                ViewBag.ErrorMessage = "ثبت سفارش با خطا مواجه شد. موجودی شما کمتر از مبلغ سفارش می باشد.";
                return View( basket);

            }
        }
    }
}
