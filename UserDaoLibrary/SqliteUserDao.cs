using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDaoLibrary
{
    /// <summary>
    /// Class <c>SqliteUserDao</c> used to read and write <c>User</c> objects
    /// to a database.
    /// NB: Please call 
    /// <c>dao.Close()</c> 
    /// to close the dataabase connection.
    /// </summary>
    internal class SqliteUserDao : IUserDao
    {
        public static string connectionString = @"Data Source=C:\work\training\CSharpCSONovember2022\CSharpSONovember2022\users.db";
        public SqliteConnection conn;

        public SqliteUserDao()
        {
            conn = new SqliteConnection(connectionString);
            conn.Open(); 
        }

        /// <summary>
        /// This function retrieves a User Object
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="UserDaoException"></exception>
        public User GetUser(int id)
        {
            User user = null;

            string sql = $"SELECT * FROM users WHERE id={ id }";

            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            SqliteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                string name = rdr.GetString(rdr.GetOrdinal("name"));
                string email = rdr.GetString(rdr.GetOrdinal("email"));
                bool active = rdr.GetBoolean(rdr.GetOrdinal("active"));

                user = new User(id, name, email, active);
            } else
            {
                // throw user not found exception
                throw new UserDaoException($"User not found {id}");
            }
            return user;
        }
        /// <summary>
        /// GetUsers()
        /// 
        /// </summary>
        /// <returns>A List of all Users from the database</returns>
        public List<User>GetUsers() {

            List<User> users = new List<User>();
            string sql = "SELECT * FROM users";
            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            SqliteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                string name = rdr.GetString(rdr.GetOrdinal("name"));
                string email = rdr.GetString(rdr.GetOrdinal("email"));
                bool active = rdr.GetBoolean(rdr.GetOrdinal("active"));

                User u = new User(id, name, email, active);
                users.Add(u);
            }
            rdr.Close();
            return users;
        }

        public void DeleteUser(int id)
        {
            string sql = $"DELETE FROM users WHERE id = {id}";

            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public User UpdateUser(User userToUpdate)
        {
            string sql = $@"UPDATE users 
                                SET name='{ userToUpdate.Name }', 
                                    email='{ userToUpdate.Email  }', 
                                    active={(userToUpdate.Active ? 1 : 0)} 
                                WHERE id={ userToUpdate.Id }";

            SqliteCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            return userToUpdate;
        }
        // suffers from SQL Injection
        public User AddUserOriginal(User userToAdd)
        {
            string sql = $@"INSERT INTO users(name, email, active) VALUES('{userToAdd.Name}','{userToAdd.Email}', {(userToAdd.Active ? 1 : 0)})";

            Console.WriteLine(sql);
            SqliteCommand cmd = conn.CreateCommand();

            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            cmd = conn.CreateCommand();
            sql = "SELECT last_insert_rowid()";
            cmd.CommandText = sql;
            SqliteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                userToAdd.Id = rdr.GetInt32(0);
            }
            return userToAdd;
        }


        public User AddUser(User userToAdd)
        {
            string sql = $@"INSERT INTO users(name, email, active) VALUES(@name, @email, @active)";

            Console.WriteLine(sql);
            SqliteCommand cmd = conn.CreateCommand();

            cmd.CommandText = sql;

            cmd.Parameters.Add(new SqliteParameter("@name", userToAdd.Name));
            cmd.Parameters.Add(new SqliteParameter("@email", userToAdd.Email));
            cmd.Parameters.Add(new SqliteParameter("@active", userToAdd.Active ? 1 : 0));

            cmd.Prepare();
            cmd.ExecuteNonQuery();

            cmd = conn.CreateCommand();
            sql = "SELECT last_insert_rowid()";
            cmd.CommandText = sql;
            SqliteDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                userToAdd.Id = rdr.GetInt32(0);
            }
            return userToAdd;
        }

        public void Close()
        {
            conn.Close();
        }
    }
}
