using Business.Concrete;
using DAL.Concrete;
using DAL.Entity;
using E_Commerce_Basically.Models;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace E_Commerce_Basically.Controllers
{
    public class HomeController : Controller
    {

        UserManager Um = new UserManager(new EfUserRepository());

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(User s)
        {
            Context Cnt = new Context();

            var UserCheck = Cnt.Users.SingleOrDefault(x => x.Username == s.Username && x.Password == s.Password);

            if (UserCheck != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, UserCheck.Username)
                };
                var UserIdentity = new ClaimsIdentity(claims, "s");
                ClaimsPrincipal principal = new ClaimsPrincipal(UserIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View();
            }

            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
