using System;
using System.Collections.Generic;
using System.Text;

namespace Web_project.Entity
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }

        public string CategoryName { set; get; }

        public string CategoryType { set; get; }

        public string CategorySex { set; get; }

        //public bool IsShowOnHome { set; get; }
        //public int? ParentId { set; get; }
        //public Status Status { set; get; }

        public List<ProductInCategory> ProductInCategories { get; set; }

        //public List<CategoryTranslation> CategoryTranslations { get; set; }

    }
}
