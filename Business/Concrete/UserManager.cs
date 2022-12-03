using Business.Abstract;
using DAL.Abstract;
using DAL.Entity;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddUser(User user)
        {
            _userDal.Insert(user);
        }

        public void DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAllList()
        {
            return _userDal.GetAllList();
        }

        public User GetUserByID(int id)
        {
            return _userDal.GetByID(id);
        }

        public void UpdateUser(User user)
        {
            _userDal.Update(user);
        }
    }
}
