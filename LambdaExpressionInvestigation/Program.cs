namespace LambdaExpressionInvestigation
{
    internal class Program
    {
        static bool IsEven(int i)
        {
            return i % 2 == 0;
        }
        static bool IsOdd(int i)
        {
            return i % 2 == 1;
        }

        delegate bool CheckFunction(int i);

        static void ProcessList(int[] list, CheckFunction checkFunction)
        {
            foreach(int i in list)
            {
                if (checkFunction(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression Investigation");
            int[] list = { 1, 5, 4, 8, 7, 2, 9, 3, 12 };
            Console.WriteLine("IsEven:");
            ProcessList(list, IsEven);

            Console.WriteLine("IsOdd:");
            ProcessList(list, IsOdd);

            Console.WriteLine("Lambda:");

            ProcessList(list, (i) =>
            {
                if (i % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            Console.WriteLine("Lambda (simplify if logic):");

            ProcessList(list, (i) =>
            {
                return i % 2 == 0;
            });


            Console.WriteLine("Lambda (leave out brackets if single parameter):");

            ProcessList(list, i =>
            {
                return i % 2 == 0;
            });

            Console.WriteLine("Lambda (if function is a single line leave out {} and return and ;):");
            ProcessList(list, i => i % 2 == 0);






        }
    }
}