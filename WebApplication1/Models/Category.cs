﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        //relational
        public List<Product> products { get; set; }
    }
}
