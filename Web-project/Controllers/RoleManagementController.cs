using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_project.Controllers
{
    public class RoleManagementController : Controller
    {

        [Route("rolemanagement")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("api/[controller]")]

        public class RoleController : ControllerBase
        {
            private readonly IRoleService _roleService;
            public RoleController(IRoleService roleService)
            {
                _roleService = roleService;
            }
            public async Task<IActionResult> GetAll()
            {
                var roles = await _roleService.GetAll();
                return Ok(roles);
            }
        }
    }
}
