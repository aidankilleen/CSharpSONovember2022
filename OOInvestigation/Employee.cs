using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInvestigation
{
    internal class Employee : Person
    {
        public string EmployeeId { get; set; }

        public Employee(string firstName, 
                string lastName, 
                string employeeId)
            :base(firstName, lastName)
        {
            //this.FirstName = firstName;
            //this.LastName = lastName;
            this.EmployeeId = employeeId;
        }
        public override void Display()
        {
            //Console.WriteLine(_id);
            Console.WriteLine(ToString());
        }

        public override string? ToString()
        {
            return $"Employee:\n{base.ToString()}\nEmployeeId:{EmployeeId}";
        }
    }
}
