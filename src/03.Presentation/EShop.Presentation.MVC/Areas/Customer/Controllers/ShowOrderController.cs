using EShop.Domain.Core.OrderAgg.AppService;
using EShop.Domain.Core.OrderAgg.Entity;
using EShop.Domain.Core.UserAgg.Entity;
using EShop.Presentation.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Presentation.MVC.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = "Customer")]
    public class ShowOrderController(UserManager<ApplicationUser> _userManager, IOrderAppService orderApp,ILogger<ShowOrderController> _logger) : Controller
    {
        public async Task<IActionResult> Index(CancellationToken ct)
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = user?.Id;
            var Orders= new List<BasketViewModel>();
            var orders = await orderApp.GetOrderByUserId(userId.Value, ct);
            if(orders==null || !orders.Any())
            {
                Orders =  new List<BasketViewModel>();
            }
            Orders= orders.Select(orderApp => new BasketViewModel
            {
                Id = orderApp.Id,
            BasketItemCount=orderApp.OrderItemCount,
            Created=orderApp.OrderDate,
            TotalPrice=orderApp.TotalAmount
                
            }).ToList();
           
            return View(Orders);
        }
        public async Task<IActionResult> OrderDetails(int id,CancellationToken ct)
        {
            var items = await orderApp.GetItemsByOrderId(id, ct);
            var Items = items.Select(o => new BasketItemViewModel
            {
                Title=o.ProductName,
                Quantity=o.Quantity,
                Price=o.Price,
                UnitPrice=o.UnitPrice,

            }).ToList();

            return View(Items);
        }
    }
}
