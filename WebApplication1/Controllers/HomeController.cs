using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product {Image = "\"C:\\Users\\User\\Downloads\\S&W_M&P_.40_left_side.jpeg\"", Name = "Smith & Wesson Glock 19", Description = "compact, semi-automatic, 9mm", Price = 180, DiscountPrice = 10, Category = "Handgun", Color = "Olive"}, 
                new Product {Image = "\"C:\\Users\\User\\Downloads\\m16a4-rifle.jpg\"", Name ="M16-A4", Description = " lightweight, gas-operated, air-cooled, magazine-fed, selective-fire ", Price = 362, DiscountPrice = 20, Category = "Firearm", Color = "Black"}
            };

			HomeVM homeVm = new HomeVM { products = products };

            return View(homeVm);
        }
    }
}