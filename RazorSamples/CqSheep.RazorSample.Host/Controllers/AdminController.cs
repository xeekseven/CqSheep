using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CqSheep.RazorSample.Host.Controllers {
    public class AdminController : Controller {
        [HttpGet]
        public IActionResult Auth () {
            return View ();
        }

        [HttpGet]
        public IActionResult Overview () {
            return View ();
        }
    }
}