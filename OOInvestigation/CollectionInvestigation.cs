using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInvestigation
{
    internal class CollectionInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection of HR Objects");

            List<Person> team = new List<Person>();

            team.Add(new Person("Alice", "Adams"));
            team.Add(new Employee("Bob", "Byrne", "E1234"));
            team.Add(new Contractor("Carol", "Conway", "CPL"));
            team.Add(new Manager("Danielle", "Davis", "E1111", 22));

            foreach(Person p in team)
            {
                Console.WriteLine(p);
            }

        }
    }
}
