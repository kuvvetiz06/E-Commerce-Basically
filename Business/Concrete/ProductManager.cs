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
    public class ProductManager : IProductService
    {
        IProductDal _iProductDal;

        public ProductManager(IProductDal productDal)
        {
            _iProductDal = productDal;
        }

        public void AddProduct(Product product)
        {
            _iProductDal.Insert(product);
        }

        public void DeleteProduct(Product product)
        {
            _iProductDal.Delete(product);
        }

        public List<Product> GetAllList()
        {
            return _iProductDal.GetAllList();
        }

        public Product GetProductByID(int id)
        {
            return _iProductDal.GetByID(id);
        }

        public void UpdateProduct(Product product)
        {
            _iProductDal.Update(product);
        }
    }
}


