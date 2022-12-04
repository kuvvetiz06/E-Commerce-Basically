using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    interface IProductService
    {

        void AddProduct(Product product);

        void DeleteProduct(Product product);

        void UpdateProduct(Product product);

        List<Product> GetAllList();

        Product GetProductByID(int id);


    }
}
