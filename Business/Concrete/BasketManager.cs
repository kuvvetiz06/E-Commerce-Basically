using Business.Abstract;
using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void AddBasket(Basket basket)
        {
            _basketDal.Insert(basket);
        }

        public void DeleteBasket(Basket basket)
        {
            _basketDal.Delete(basket);
        }

        public List<Basket> GetAllList()
        {
            return _basketDal.GetAllList();
        }

        public List<Basket> IncludeBasketList(int User)
        {
            return _basketDal.GetListWithUserAndProduct(User);
        }
 

        public Basket GetBasketByID(int id)
        {
            return _basketDal.GetByID(id);
        }

        public List<Basket> GetBasketListByUserID(int id)
        {
            return _basketDal.GetAllList(x => x.UserID == id);
        }

        public void UpdateBasket(Basket basket)
        {
            _basketDal.Update(basket);
        }
    }
}
