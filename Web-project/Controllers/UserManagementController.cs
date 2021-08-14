using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_project.Controllers
{
    public class UserManagementController : Controller
    {
        [Route("admin/usermanagement")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
