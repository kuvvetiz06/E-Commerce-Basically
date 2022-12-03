using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        void AddUser(User user);

        void DeleteUser(User user);

        void UpdateUser(User user);

        List<User> GetAllList();

        User GetUserByID(int id);
    }
}
