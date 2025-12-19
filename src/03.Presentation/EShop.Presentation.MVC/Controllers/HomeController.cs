using EShop.Domain.Core.CategoryAgg.AppService;
using EShop.Domain.Core.ProductAgg.AppService;
using EShop.Domain.Core.ProductAgg.DTOs;
using EShop.Presentation.MVC.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace EShop.Presentation.MVC.Controllers
{
    public class HomeController(ICategoryAppService _catapp,IProductAppService _prd,ILogger<HomeController> _logger) : Controller
    {
        

        public async Task<IActionResult> Index(CancellationToken ct)
        {
            var category = await _catapp.GetAllCategories(ct);
            var cat = new HomeIndexViewModel
            {
                Categories = category
            };
            var products = await _prd.GetAllProducts(ct);
            cat.Products = products.Select(p=> new GetProductDTO
            {
                Id=p.Id,
                Title=p.Title,
                Description= !string.IsNullOrEmpty(p.Description)?( p.Description.Length>7 ? p.Description.Substring(0,7)+"..." :p.Description):string.Empty,
                ImageUrl =p.ImageUrl,
                Stock = p.Stock,
                Price=p.Price
            }

                ).ToList();
            return View(cat);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
 //< div class= "form-group" >
 //       < label asp -for= "CPost.ImageFile" > ?????? ?????(JPEG? ?????? 2MB) </ label >
 //       < input type = "file" asp -for= "CPost.ImageFile" id = "imageInput" accept = "image/jpeg" class= "form-control" />
 //       < span asp - validation -for= "CPost.ImageFile" class= "text-danger" ></ span >
 //   </ div >