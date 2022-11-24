using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDaoLibrary;

namespace LambdaExpressionInvestigation
{
    internal class LinqFunctionsInvestigation
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Linq Functions Investigation");
            SqliteUserDao dao = new SqliteUserDao();

            List<User> users = dao.GetUsers();

            List<User> activeUsers = users.FindAll(user => user.Active);

            activeUsers.ForEach(user => Console.WriteLine(user));

            Console.WriteLine($"There are { activeUsers.Count } active users in the system");


            /*
            users.ForEach(user => Console.WriteLine(user));
            result = users..Select(user =>
            {
                if (user.Active)
                {
                    return user;
                }
            });
            */
        }
    }
}
