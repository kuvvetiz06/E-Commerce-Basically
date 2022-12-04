using Business.Concrete;
using Business.ValidRules;
using DAL.Entity;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Basically.Controllers
{
    public class UserController : Controller
    {
        UserManager Um = new UserManager(new EfUserRepository());


        public IActionResult Index()
        {
            var UserList = Um.GetAllList();

            return View(UserList);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(User u)
        {
            UserValidator UserValid = new UserValidator();
            ValidationResult Result = UserValid.Validate(u);
            if (Result.IsValid)
            {
                Um.AddUser(u);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in Result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
