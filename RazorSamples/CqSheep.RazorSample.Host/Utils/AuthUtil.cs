using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CqSheep.RazorSample.Host.Utils
{
    public class AuthCommonUtil
    {
        public static ClaimsIdentity GetClaimsIdentity(string userName,string role = "Administrator")
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,userName),
                new Claim("FullName",userName),
                new Claim(ClaimTypes.Role,role)
            };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            return claimsIdentity;
        }
    }
}
