using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInvestigation
{
    internal class Contractor : Person
    {
        public string Agency { get; set; }

        public Contractor(string firstName, 
                string lastName, string agency)
            : base(firstName, lastName)
        {
            Agency = agency;
        }

        public override void Display()
        {
            Console.WriteLine("Contractor:");
            base.Display();
            Console.WriteLine("Agency:" + Agency);
        }
    }
}
