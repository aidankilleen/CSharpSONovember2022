using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoInvestigation
{
    internal class SqliteUserDao
    {
        public static string connectionString = @"Data Source=C:\work\training\CSharpCSONovember2022\CSharpSONovember2022\users.db";
        public SqliteConnection conn;

        public SqliteUserDao()
        {
            conn = new SqliteConnection(connectionString);
            conn.Open(); 
        }

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
    }
}
