using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProductImage : BaseEntity
    {
        public string Image { get; set; }
        public bool? IsPrimary { get; set; }

        //relational
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
