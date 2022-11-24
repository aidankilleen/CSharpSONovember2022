using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDaoLibrary;

namespace LambdaExpressionInvestigation
{
    internal class ListOfObjectsProcessingInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Of Objects");

            SqliteUserDao dao = new SqliteUserDao();

            List<User> users = dao.GetUsers();

            users.ForEach(user => Console.WriteLine(user));
            Console.WriteLine("====================================");

            List<User> activeUsers = users.FindAll(user => user.Active);

            activeUsers.ForEach(user => Console.WriteLine(user));

            dao.Close();




        }
    }
}
