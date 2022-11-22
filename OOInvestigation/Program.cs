namespace OOInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OO Investigation");


            Person p = new Person("Aidan", "Killeen");
            p.Display();

            Employee e = new Employee("Alice", 
                                    "Adams", 
                                      "E12345");
            e.Display();


            Contractor c = new Contractor("Bob", "Byrne",
                        "CPL");
            c.Display();

            Manager m = new Manager("Carol", "Conway",
                                "E1111", 12);

            m.Display();




            // Abstraction (the ability to create an object)


            /* Encapsulation (public & private keywords - 
             * the ability to protect the elements of the object
             * from the outside world)
             */

            // Inheritance

            // Polymorphism

        }
    }
}