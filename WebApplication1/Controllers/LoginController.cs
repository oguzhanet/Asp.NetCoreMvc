using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult Login1()
        {
            return View();
        }

       
        public async Task<IActionResult> Login1(Admin admin)
        {
            var result = context.Admins.FirstOrDefault(x => x.UserName == admin.UserName &&
              x.Password == admin.Password);
            if (result !=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admin.UserName)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login1", "Login");
        }
    }
}
