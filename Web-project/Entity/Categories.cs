using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_project.Entity
{
    public class Categories
    {

        public int Id { set; get; }
        public int SortOrder { set; get; }

        public string CategoriesName { set; get; }

        public string CategoriesType { set; get; }

        public string CategoriesSex { set; get; }


        public List<ProductInCategories> ProductInCategories { get; set; }
    }
}
