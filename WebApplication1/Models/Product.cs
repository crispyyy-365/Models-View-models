namespace WebApplication1.Models
{
    public class Product : BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int DiscountPrice { get; set; }
        public string Color { get; set; }

        //relational

        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}