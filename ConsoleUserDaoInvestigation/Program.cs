using UserDaoLibrary;

namespace ConsoleUserDaoInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Console User Dao Investigation");
            SqliteUserDao dao = new SqliteUserDao();
            List<User> users = dao.GetUsers();

     

            foreach(User user in users)
            {
                Console.WriteLine(user);
            }
            dao.Close();
        }
    }
}