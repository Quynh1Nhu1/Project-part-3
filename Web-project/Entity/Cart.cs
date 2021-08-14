using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_project.Entity
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Price { set; get; }
        public Guid UserId { get; set; }
        public Products Product { get; set; }
        public DateTime DateCreated { get; set; }
        public AppUsers AppUser { get; set; }
    }
}
