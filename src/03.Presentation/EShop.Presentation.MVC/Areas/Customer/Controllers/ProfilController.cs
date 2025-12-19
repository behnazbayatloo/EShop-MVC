using EShop.Domain.Core.UserAgg.Entity;
using EShop.Presentation.MVC.Areas.Customer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace EShop.Presentation.MVC.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles ="Customer")]
    public class ProfilController (UserManager<ApplicationUser>  _userManager,SignInManager<ApplicationUser> _signInManager) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var user= await _userManager.GetUserAsync(User);
            var ballance = user.Balance;
            var firstname= user.FirstName;
            var lastname= user.LastName;
            var email= user.Email;
            var username= user.UserName;
            var Customer = new UserViewModel
            {
                FirstName = firstname, LastName = lastname,
                Email = email
                ,Ballance=ballance,
                UserName=username
            };
            return View(Customer);
        }
        [HttpGet]
        public async Task <IActionResult> ChangePassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model) 
        { if (!ModelState.IsValid) 
            {
                return View(model); 
            } 
            var user = await _userManager.GetUserAsync(User);
            if (user == null) 
            { 
                return RedirectToAction("Login", "Account",new {area="Identity"});
            } 
            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPass, model.NewPass); 
            if (result.Succeeded)
            { await _signInManager.RefreshSignInAsync(user); 
                TempData["SuccessMessage"] = "پسورد شما با موفقیت تغییر کرد.";
                return RedirectToAction("Index"); 
            } 
            foreach (var error in result.Errors) 
            { 
                ModelState.AddModelError(string.Empty, error.Description); 
            } 
            return View(model); 
        }
        [HttpGet]
        public IActionResult ChangeFirstName()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangeFirstNameAsync(ChangeFirstNameViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account", new { area = "Identity" });
            }
            user.FirstName= model.FirstName;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            } 
            return View(user);
        }
        [HttpGet]
        public IActionResult ChangeLastName()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangeLastNameAsync(ChangeLastNameViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account", new { area = "Identity" });
            }
            user.LastName= model.LastName;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(user);

        }
    }
}

