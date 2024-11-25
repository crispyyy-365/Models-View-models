using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
    {
        public AppDbContext _context;
        
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVm = new HomeVM()
            {
                products = await _context.Products
                .Where(p => p.IsDeleted == false)
                .Take(4)
                .Include(x => x.Category)
                .ToListAsync()
            };

            return View(homeVm);
        }
    }
}