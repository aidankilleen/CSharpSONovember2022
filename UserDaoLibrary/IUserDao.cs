using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDaoLibrary
{
    internal interface IUserDao
    {
        User GetUser(int id);
        List<User> GetUsers();
        User AddUser(User userToAdd);
        User UpdateUser(User userToUpdate);
        void DeleteUser(int id);
        void Close();
    }
}
