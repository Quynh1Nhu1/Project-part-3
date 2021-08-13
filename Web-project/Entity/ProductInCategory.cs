using System;
using System.Collections.Generic;
using System.Text;

namespace Web_project.Entity
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }

        public Products Product { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        
    }
}
