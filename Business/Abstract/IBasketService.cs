using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    interface IBasketService
    {
        void AddBasket(Basket basket);

        void DeleteBasket(Basket basket);

        void UpdateBasket(Basket basket);

        List<Basket> GetAllList();
     


        Basket GetBasketByID(int id);
    }
}
