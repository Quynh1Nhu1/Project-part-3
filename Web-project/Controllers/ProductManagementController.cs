﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_project.Controllers
{
    public class ProductManagementController : Controller
    {
        [Route("admin/productmanagement")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
