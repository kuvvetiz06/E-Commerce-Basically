using Business.Concrete;
using DAL.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using DAL.Concrete;
using Entity.Concrete;

namespace E_Commerce_Basically.Controllers
{
    [Authorize]
    public class BasketController : Controller
    {
        BasketManager Bm = new BasketManager(new EfBasketRepository());


        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetBasketListUserByID()
        {

            var GetLoginUser = User.Identity.Name;

            Context Cntx = new Context();

            int UserID = Cntx.Users.SingleOrDefault(x => x.Username == GetLoginUser).UserID;

            var data = Bm.IncludeBasketList(UserID);

            return Json(new { data });
        }

        [HttpPost]
        public IActionResult AddBasketItem(int id)
        {
            try
            {
                var GetLoginUser = User.Identity.Name;

                Context Cntx = new Context();

                int UserID = Cntx.Users.SingleOrDefault(x => x.Username == GetLoginUser).UserID;

                Basket AddItem = new Basket();
                AddItem.ProductID = id;
                AddItem.UserID = UserID;
                AddItem.Status = true;

                Bm.AddBasket(AddItem);

                return Json(new { Status = true });
            }
            catch (Exception Ex)
            {

                return Json(new { Status = false, Message = Ex.Message });
            }
            
        }
    }


}
