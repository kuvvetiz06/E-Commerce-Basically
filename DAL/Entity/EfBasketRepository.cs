using DAL.Abstract;
using DAL.Concrete;
using DAL.Repositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class EfBasketRepository : GenericRepository<Basket>, IBasketDal
    {
        public List<Basket> GetListWithUserAndProduct(int User)
        {
            using (var Cntx = new Context())
            {
                return Cntx.Baskets.Include(x => x.User).Where(x=>x.UserID == User).Include(x=>x.Product).ToList();
            }
        }
    }
}
