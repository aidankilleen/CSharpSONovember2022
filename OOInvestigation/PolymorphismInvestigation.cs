using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInvestigation
{
    internal class PolymorphismInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism investigation");

            Person[] people = {
                new Person("Alice", "Adams"),
                new Employee("Bob", "Byrne", "E1234"),
                new Contractor("Carol", "Conway", "CPL"),
                new Manager("Danielle", "Dunne", "E1111", 15)
            };

            foreach(Person p in people)
            {
                p.Display();
            }



        }
    }
}
