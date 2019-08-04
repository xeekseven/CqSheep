using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CqSheep.RazorSample.Host.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CqSheep.RazorSample.Host.Controllers 
{
    [Authorize]
    [Route("[controller]")]
    public class AdminController : Controller {
        [HttpGet]
        [Route("Auth")]
        public IActionResult Auth () {
            return View ();
        }

        [HttpGet]
        [Route("Overview")]
        public IActionResult Overview () {
            return View ();
        }

        [HttpGet]
        [Route("TableStat")]
        public IActionResult TableStat () {
            return View ();
        }
        [HttpGet]
        [Route("Login")]
        [AllowAnonymous]
        public IActionResult Login () {
            return View ();
        }
        [HttpGet]
        [Route("GetData")]
        public JsonResult GetData([FromQuery]string key)
        {
            return new JsonResult(key + "200");
        }
        [HttpPost]
        [Route("PostDataJson")]
        public JsonResult PostDataJson([FromBody]LoginViewModel model)
        {
            string r = model.UserName + model.Password + "-200";
            return new JsonResult(r);
        }
        [HttpPost]
        [Route("PostLogin")]
        [AllowAnonymous]
        public async Task<IActionResult> PostLogin([FromForm]LoginViewModel model)
        {
           if(model.UserName == "xeeksAdmin" && model.Password == "xeeksAdmin950422")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,model.UserName),
                    new Claim("FullName",model.UserName),
                    new Claim(ClaimTypes.Role,"Administrator")
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties();
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                var returnUrl = HttpContext.Request.Query["ReturnUrl"];
                if (!string.IsNullOrWhiteSpace(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                return Redirect("/Admin/Overview");
            }
            return Redirect("/Admin/Login");
        }
    }
}