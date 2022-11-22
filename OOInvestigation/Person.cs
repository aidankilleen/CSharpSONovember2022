﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInvestigation
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual void Display()
        {
            Console.WriteLine("Person:");
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
