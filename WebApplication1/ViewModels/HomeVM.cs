using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
	public class HomeVM
	{
		public List<Product> products { get; set; }
		public List<Category> categories { get; set; }
		public List<ProductImage> productImages { get; set; }
		public List<Slide> Slides { get; set; }
	}
}