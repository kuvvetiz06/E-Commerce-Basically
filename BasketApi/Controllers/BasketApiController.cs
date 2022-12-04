using Business.Concrete;
using DAL.Concrete;
using DAL.Entity;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BasketApiController : ControllerBase
    {
        BasketManager Bm = new BasketManager(new EfBasketRepository());

       
        [HttpGet("BasketList")]
        public IActionResult BasketList()
        {
            var List = Bm.GetAllList();

            return Ok(List);
        }
    }
}
