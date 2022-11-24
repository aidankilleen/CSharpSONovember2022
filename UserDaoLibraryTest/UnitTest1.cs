using UserDaoLibrary;

namespace UserDaoLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        SqliteUserDao dao = new SqliteUserDao();

        [TestMethod]
        public void TestMethod1()
        {
            int i = 10;
            int j = 20;

            int answer = i + j;

            Assert.AreEqual(30, answer);
        }

        [TestMethod]
        public void TestOpenDao()
        {
            Assert.IsNotNull(dao);
            dao.Close();
        }

        [TestMethod]
        public void TestGetAllUsers()
        {
            List<User> users = dao.GetUsers();
            Assert.IsNotNull(users);
            dao.Close();
        }
        [TestMethod]
        public void TestAddUser()
        {
            User userToAdd = new User(-1, "New", "new.user@gmail.com", false);
            User addedUser = dao.AddUser(userToAdd);
            Assert.AreNotEqual(-1, addedUser.Id);

            dao.DeleteUser(addedUser.Id);
            dao.Close();
        }

        [TestMethod]
        public void TestGetUserNotFound()
        {
            Assert.ThrowsException<UserDaoException>(() =>
            {
                dao.GetUser(9999);
            });
            dao.Close();
        }

        [TestMethod]
        public void TestSqlInjection()
        {
            //SqliteUserDao dao = new SqliteUserDao();
            List<User> users = dao.GetUsers();
            int count = users.Count;

            User u = new User(1,
                "','',0); delete from users;--", 
                "", false);
            User addedUser = dao.AddUser(u);

            users = dao.GetUsers();
            Assert.AreEqual(count + 1, users.Count);
            dao.Close();
        }
    }
}