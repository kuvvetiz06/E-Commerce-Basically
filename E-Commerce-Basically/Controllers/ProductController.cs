using Business.Concrete;
using DAL.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Basically.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        ProductManager Pm = new ProductManager(new EfProductRepository());

        public IActionResult Index()
        {

            return View();
        }

      
        [HttpPost]
        public JsonResult GetProductData()
        {

            var data = Pm.GetAllList();                  

            return Json(new { data });
        }
    }
}
