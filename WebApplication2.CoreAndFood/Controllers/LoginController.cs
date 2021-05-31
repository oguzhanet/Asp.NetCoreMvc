using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication2.CoreAndFood.Models.Entity;

namespace WebApplication2.CoreAndFood.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Admin admin)
        {
            var dataValue = context.Admins.FirstOrDefault(x => x.UserName == admin.UserName
              && x.Password == admin.Password);

            if (dataValue!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admin.UserName)
                };
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Category");
            }
            return View();
        }
    }
}
