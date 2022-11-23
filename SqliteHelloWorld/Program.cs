using Microsoft.Data.Sqlite;

namespace SqliteHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sqlite Hello World");
            string connectionString = @"Data Source=C:\work\training\CSharpCSONovember2022\CSharpSONovember2022\users.db";

            SqliteConnection conn = new SqliteConnection(connectionString);
            conn.Open();

            // insert
            SqliteCommand cmd = conn.CreateCommand();

            string sql = @"INSERT INTO users (name, email, active) 
                           VALUES('NEW USER', 'new.user@gmail.com', 0)";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            // what is the id of the new user????
            cmd = conn.CreateCommand();
            sql = "SELECT last_insert_rowid()";
            cmd.CommandText = sql;
            var newId = cmd.ExecuteScalar();

            Console.WriteLine($"Last Id: { newId }");




            // update
            cmd = conn.CreateCommand();
            sql = @"UPDATE users SET name='CHANGED' WHERE id=6";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            // delete
            cmd = conn.CreateCommand();
            sql = @"DELETE FROM users WHERE id>7";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            // query
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM users";
            SqliteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                int id = rdr.GetInt32(rdr.GetOrdinal("id"));
                string name = rdr.GetString(rdr.GetOrdinal("name"));
                string email = rdr.GetString(rdr.GetOrdinal("email"));
                bool active = rdr.GetBoolean(rdr.GetOrdinal("active"));

                Console.WriteLine($"{ id } { name } { email } {(active ? "Active" : "Inactive")}");
            }
            rdr.Close();
            conn.Close();

        }
    }
}