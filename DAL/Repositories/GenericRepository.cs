using DAL.Abstract;
using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var Cntx = new Context();
            try
            {
                Cntx.Add(t);
                Cntx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public List<T> GetAllList()
        {
            using var Cntx = new Context();

            return Cntx.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            using var Cntx = new Context();

            return Cntx.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            using var Cntx = new Context();
            try
            {
                Cntx.Add(t);
                Cntx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Update(T t)
        {
            using var Cntx = new Context();
            try
            {
                
                Cntx.Add(t);
                Cntx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
