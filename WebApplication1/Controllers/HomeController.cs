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
                new Product {Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.pngegg.com%2Fen%2Fpng-mqhrc&psig=AOvVaw279UMA5_WDg-Aj1XgbnMep&ust=1732112463815000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKiTmLjM6IkDFQAAAAAdAAAAABAJ", Name = "Smith & Wesson Glock 19", Description = "compact, semi-automatic, 9mm", Price = 180, DiscountPrice = 10, Category = "Handgun", Color = "Olive"}, 
                new Product {Image = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.shutterstock.com%2Fsearch%2Fm16&psig=AOvVaw1U-TJ8J4ZdaOYg1LAgVYcD&ust=1732112271810000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCIiw5JvL6IkDFQAAAAAdAAAAABAE", Name ="M16-A4", Description = " lightweight, gas-operated, air-cooled, magazine-fed, selective-fire ", Price = 362, DiscountPrice = 20, Category = "Firearm", Color = "Black"}
            };

			HomeVM homeVm = new HomeVM { products = products };

            return View(homeVm);
        }
    }
}