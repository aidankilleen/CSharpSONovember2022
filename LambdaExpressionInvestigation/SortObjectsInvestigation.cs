using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDaoLibrary;

namespace LambdaExpressionInvestigation
{
    internal class SortObjectsInvestigation
    {
        static void Main(string[] args)
        {
            SqliteUserDao dao = new SqliteUserDao();

            List<User> users = dao.GetUsers();

            users.ForEach(u => Console.WriteLine(u));
            Console.WriteLine("==========================");
            users.Sort((u1, u2) => u2.Name.CompareTo(u1.Name));
            users.ForEach(u => Console.WriteLine(u));
            
            
            


            dao.Close();
        }
    }
}
