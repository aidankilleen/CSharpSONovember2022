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

            dao.DeleteUser(3);


            List<User> users = dao.GetUsers();

            foreach(User u in users)
            {
                Console.WriteLine(u);
            }
        }
    }
}
