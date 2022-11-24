using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionInvestigation
{
    internal class ListProcessingInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Processing Investigation");

            List<string> names = new List<string>();

            names.Add("Alice");
            names.Add("Bob");
            names.Add("Carol");
            names.Add("Dan");
            names.Add("Eve");

            names.ForEach(name => Console.WriteLine(name));
            
            int index = names.FindIndex(name => name.Equals("Carol"));

            Console.WriteLine(index);
            List<string> result = names.FindAll(name => name.Length > 3);

            result.ForEach(name => Console.WriteLine(name));


        }
    }
}
