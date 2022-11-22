using System.Collections;
using System.Collections.Generic;

namespace CollectionInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection Investigation");

            string[] names =
            {
                "Alice",
                "Bob",
                "Carol",
                "Dan"
            };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Length);


            ArrayList al = new ArrayList();

            al.Add("Alice");
            al.Add("Bob");
            al.Add("Carol");
            al.Add("Dan");
            //al.Add(99);
            //al.Add(new DateOnly());

            foreach(string name in al)
            {
                Console.WriteLine(name);
            }

            ArrayList users = new ArrayList();

            // note initialiser seems to bypass the constructor and sets the properties directly
            users.Add(new User { Id = 1, Name = "Alice", Email = "alice@gmail.com", Active = false });
            users.Add(new User { Id = 2, Name = "Bob", Email = "bob@gmail.com", Active = true });
            users.Add(new User { Id = 3, Name = "Carol", Email = "carol@gmail.com", Active = true });
            users.Add(new User { Id = 4, Name = "Dan", Email = "dan@gmail.com", Active = false });
            // users.Add("Eve");

            foreach (User u in users)
            {
                Console.WriteLine(u.Name);
            }

            // ArrayList has the features we need
            //  EXCEPT type safety.


            List<User> userList = new List<User>();

            userList.Add(new User { Id = 5, Name = "Eve", Email = "eve@gmail.com", Active = false });
            userList.Add(new User { Id = 6, Name = "Fred", Email = "fred@gmail.com", Active = true });
            userList.Add(new User { Id = 7, Name = "Ger", Email = "ger@gmail.com", Active = true });

            // userList.Add(123);

            foreach(User u in userList)
            {
                Console.WriteLine(u.Name);
            }



            






        }
    }
}