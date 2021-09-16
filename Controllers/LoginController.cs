using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using E_Commence.Models.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace E_Commence.Controllers
{
    public class LoginController:Controller
    {
        Context c = new Context();
        [HttpGet]
       public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User p)
        {
            var bilgiler = c.Users.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Username)};
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("BeverageIndex", "Admin");
            }
            return View();
        }
    }
}
