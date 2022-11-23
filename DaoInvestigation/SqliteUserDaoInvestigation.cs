using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoInvestigation
{
    internal class SqliteUserDaoInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sqlite User Dao Investigation");
            SqliteUserDao dao = new SqliteUserDao();


            User newUser = new User(-1, "NEW", "new.user@gmail.com", false);
            User addedUser = dao.AddUser(newUser);
            Console.WriteLine(addedUser); // should include the id

            dao.DeleteUser(3);

            User userToUpdate = new User(5, "UPDATED", "updated@gmail.com", true);

            dao.UpdateUser(userToUpdate);

            List<User> users = dao.GetUsers();

            foreach(User u in users)
            {
                Console.WriteLine(u);
            }
        }
    }
}
