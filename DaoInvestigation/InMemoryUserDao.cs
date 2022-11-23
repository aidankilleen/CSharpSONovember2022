using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoInvestigation
{
    internal class InMemoryUserDao : IUserDao
    {
        List<User> users = new List<User>();

        public InMemoryUserDao()
        {
            users.Add(new User(1, "Alice", "alice@gmail.com", true));
            users.Add(new User(2, "Bob", "bob@gmail.com", false));
            users.Add(new User(3, "Carol", "carol@gmail.com", true));
            users.Add(new User(4, "Dan", "dan@gmail.com", true));
        }

        public User GetUser(int id)
        {
            try
            {
                int index = FindUser(id);
                return users[index];

            } catch (Exception ex)
            {
                throw new UserDaoException($"User not found {id}");
            }
        }
        public List<User> GetUsers()
        {
            return users;
        }
        // Add User
        public User AddUser(User userToAdd)
        {
            users.Add(userToAdd);
            return userToAdd;
        }

        // Update User
        public User UpdateUser(User userToUpdate)
        {
            int index = FindUser(userToUpdate.Id);
            if (index != -1)
            {
                users[index] = userToUpdate;
            }
            return userToUpdate;
        }

        public int FindUser(int id)
        {
            int index = -1;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == id)
                {
                    index = i;
                }
            }
            return index;
        }
        // Delete User
        public void DeleteUser(int id)
        {
            int index = FindUser(id);
            if (index != -1)
            {
                users.RemoveAt(index);
            }
        }
        public void Close()
        {
            users.Clear();
        }
    }
}
