using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CqSheep.RazorSample.Host.Controllers 
{
    public class AuthController : Controller {
        [HttpPost]
        public IActionResult Login () {
            return View ();
        }
    }
}