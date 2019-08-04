using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CqSheep.RazorSample.Contact.ViewModels;
using CqSheep.RazorSample.Host.Models;
using CqSheep.RazorSample.Host.Utils;
using CqSheep.RazorSample.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CqSheep.RazorSample.Host.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private IAdminUserService _adminService;
        public AdminController(IAdminUserService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet]
        [Route("Auth")]
        public IActionResult Auth()
        {
            return View();
        }

        [HttpGet]
        [Route("Overview")]
        public IActionResult Overview()
        {
            return View();
        }

        [HttpGet]
        [Route("TableStat")]
        public IActionResult TableStat()
        {
            return View();
        }
        [HttpGet]
        [Route("Login")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
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
            var admin = _adminService.GetUser(model.UserName, model.Password);
            if (admin == null)
            {
                return Redirect("/Admin/Login");
            }

            var claimsIdentity = AuthCommonUtil.GetClaimsIdentity(model.UserName);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), new AuthenticationProperties());
            var returnUrl = HttpContext.Request.Query["ReturnUrl"];
            if (!string.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return Redirect("/Admin/Overview");

        }
        [HttpGet]
        [Route("AddAdmin/{UserName}/{Password}")]
        [AllowAnonymous]
        public bool AddAdminUser(string userName,string password)
        {
            AdminUserVModel vmodel = new AdminUserVModel
            {
                UserName = userName,
                Role = "Administrator"
            };
             _adminService.AddAdminUser(vmodel, password);
            return true;

        }
    }
}