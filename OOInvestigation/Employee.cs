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
            Console.WriteLine("Employee:");
            //Console.WriteLine(FirstName + " " +  LastName);
            base.Display();
            Console.WriteLine("EmployeeId:"+ EmployeeId);
        }
    }
}
