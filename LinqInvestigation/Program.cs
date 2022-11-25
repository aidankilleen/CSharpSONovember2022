using System.Security.Cryptography;
using UserDaoLibrary;

namespace LinqInvestigation
{

    partial class Record
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Quantity { get; set; }

        public Record(int id, string name, string colour, int quantity)
        {
            Id = id;
            Name = name;
            Colour = colour;
            Quantity = quantity;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq Investigation");

            int[] arr = { 2, 5, 7, 6, 4, 8, 10, 9, 2, 3, 4, 15, 11, 7 };
            List<int> list = new List<int>(arr);

            list.ForEach(i => Console.WriteLine(i));

            // the var keyword
            var i = 10;
            var even = list.FindAll(i => i % 2 == 0);


            // var j;   // you can't create a var variable without initialising it
            // i = "ten";  // the type safety means I can't change the type.

            Console.WriteLine("=============================");
            // very first linq expression
            IEnumerable<int> result = from item in list select item;
            foreach(int item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==============================");
            result = from item in list where item % 2 == 0 select item;
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==============================");
            var evenNumbers = list.Where(i => i % 2 == 0);
            
            foreach (int item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==============================");


            SqliteUserDao dao = new SqliteUserDao();

            var users = dao.GetUsers();
            var activeUsers = from user in users
                                where user.Active == true
                                orderby user.Name descending
                                select user;

            foreach (var user in activeUsers)
            {
                Console.WriteLine(user);
            }


            Console.WriteLine("=====================================");
            var agg = from user in users
                      group user by user.Active into g
                      select new
                      {
                          Active = g.Key,
                          Count = g.Count()
                          
                      };
            foreach (var item in agg)
            {
                Console.WriteLine($"{(item.Active ? "Active:   " : "Inactive:")}\t{ item.Count }");
            }

            dao.Close();


            List<Record> data = new List<Record>()
            {
                new Record (1, "Alice", "red", 100),
                new Record(2, "Bob", "green", 12),
                new Record(3, "Carol", "blue", 14),
                new Record(4, "Dan", "red", 10),
                new Record(5, "Carol", "green", 16),
                new Record(6, "Dan", "blue", 10),
                new Record(7, "Bob", "green", 1),
                new Record(8, "Alice", "green", 20),
                new Record(9, "Bob", "green", 15),
                new Record(10, "Carol", "red", 10),
                new Record(11, "Alice", "red", 10),
                new Record(12, "Bob", "green", 12),
                new Record(13, "Carol", "blue", 14),
                new Record(14, "Dan", "red", 10),
                new Record(15, "Carol", "green", 16),
                new Record(16, "Dan", "blue", 10),
                new Record(17, "Bob", "orange", 1),
                new Record(18, "Alice", "green", 20),
                new Record(19, "Bob", "green", 15),
                new Record(20, "Carol", "red", 10),
                new Record(21, "Eve", "orange", 99), 
                new Record(22, "Fred", "pink", 21)
            };


            var r = from record in data select record;

            foreach(Record record in r)
            {
                Console.WriteLine(record);
            }

            Console.WriteLine("==========================");

            var results = from record in data
                      group record by record.Name into g
                      select new
                      {
                          Name = g.Key,
                          Total = g.Sum(r => r.Quantity), 
                          Count = g.Count()
                      };

            foreach (var res in results)
            {
                Console.WriteLine(res);
            }

            var colourBreakdown = from record in data
                                  group record by record.Colour into g
                                  select new
                                  {
                                      Colour = g.Key,
                                      Total = g.Sum(r => r.Quantity),
                                      Count = g.Count()
                                  };

            foreach (var res in colourBreakdown)
            {
                Console.WriteLine(res);
            }



        }
    }
}