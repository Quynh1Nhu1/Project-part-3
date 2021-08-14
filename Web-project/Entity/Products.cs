using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_project.Entity
{
    public class Products
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public string ProductDecription { get; set; }
        public int ProductPrice { get; set; }
        public string ProductBrand { get; set; }
        public string ProductProductCode { get; set; }
        public string ProductSize { get; set; }
        public string ProductColor { get; set; }
        public DateTime ProductDateUpload { get; set; }

        public List<ProductInCategories> ProductInCategories { get; set; }
    }
}
