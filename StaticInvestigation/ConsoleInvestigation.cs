using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInvestigation
{
    internal class ConsoleInvestigation
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            
            Console.WriteLine("Console Investigation");

            //Console.Beep();

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Welcome, {name}");

            Console.WriteLine(Console.BackgroundColor);


        }
    }
}
