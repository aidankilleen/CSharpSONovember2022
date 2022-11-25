// See https://aka.ms/new-console-template for more information
using UserDaoLibrary;

Console.WriteLine("Top Level Investigation");

SqliteUserDao dao = new SqliteUserDao();
var users = dao.GetUsers();
users.ForEach(u => Console.WriteLine(u));
dao.Close();


