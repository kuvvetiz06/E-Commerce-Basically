using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Basically.Controllers
{
    public class BasketController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
