using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInvestigation
{
    internal class Message
    {
        // properties
        public string Title { get; set; }

        public string Text { get; set; }

        // member variables (fields)
        private int _numberOfDays = 10;

        public int NumberOfDays
        {
            get
            {
                Console.WriteLine("get called");
                return _numberOfDays;
            }
            set 
            {
                Console.WriteLine("set called");
                if (value >= 0)
                {
                    _numberOfDays = value;
                } else
                {
                    Console.WriteLine("invalid value");
                }
            }
        }




        /*
        public int getNumberOfDays()
        {
            return numberOfDays;
        }
        public void setNumberOfDays(int numberOfDays)
        {
            if (numberOfDays >= 0)
            {
                this.numberOfDays = numberOfDays;

            } else
            {
                Console.WriteLine("Error!!!");
            }
        }
        */
        // member functions (methods)
        // constructor(s)
        public Message()
        {
            Title = "Test Message";
            Text = "This is a test";
            NumberOfDays = 99;
        }
        public Message(string title, string text)
        {
            this.Title = title;
            this.Text = text;
        }
        public Message(string title, 
                       string text, 
                       int numberOfDays)
        {
            this.Title = title;
            this.Text = text;
            this.NumberOfDays = numberOfDays;
        }

        // other functions
        public void Display()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Text);
        }
    }
}
