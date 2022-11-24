using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionInvestigation
{
    internal class SortInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sort Investigation");

            int[] list = { 10, 1, 4, 2, 6, 4, 3, 9, 15, 22, 8, 18, 7, 6 };

            List<int> ints = new List<int>(list);

            ints.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("===============================");

            ints.Sort((a, b) => b - a);

            /*            
                        ints.Sort((a, b) =>
                        {
                            Console.WriteLine($"Comparing {a} and {b}");
                            if (a < b)
                            {
                                return -1;
                            }
                            else if (a == b)
                            {
                                return 0;
                            }
                            else
                            {
                                return 1;
                            }
                        });
            */
            ints.ForEach(i => Console.WriteLine(i));





        }
    }
}
