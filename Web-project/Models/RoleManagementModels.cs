using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_project.Models
{
    public class RoleManagementModels
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }
    }
}
