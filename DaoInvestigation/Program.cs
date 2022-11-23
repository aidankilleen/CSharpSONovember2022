namespace DaoInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DAO Investigation");

            InMemoryUserDao dao = new InMemoryUserDao();


            
            User u = new User(5, "Eve", "eve@gmail.com", true);
            dao.AddUser(u);

            dao.DeleteUser(2);

            u.Name = "CHANGED";

            dao.UpdateUser(u);

            User uu = dao.GetUser(3);
            Console.WriteLine(uu);

            List<User> users = dao.GetUsers();

            foreach(User user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}