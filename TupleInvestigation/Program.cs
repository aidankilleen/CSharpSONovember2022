namespace TupleInvestigation
{
    class Results
    {
        public int Max { get; set; }
        public int Min { get; set; }
    }

    class Card
    {
        public int Suit { get; set; }
        public int Value { get; set; }

        public Card(int suit, int value)
        {
            Suit = suit;
            Value = value;
        }
    }

    internal class Program
    {
        public static Results DoCalculations(int[] list)
        {
            int max = list.Max(x => x);
            int min = list.Min(x => x);

            Results results = new Results();
            results.Max = max;
            results.Min = min;
            return results;
        }

        public static (int, int) DoListCalculations(int[] list)
        {
            int max = list.Max(x => x);
            int min = list.Min(x => x);

            return (min, max);
        }

        public static (int Min, int Max) DoListAnalysis(int[] list)
        {
            int max = list.Max(x => x);
            int min = list.Min(x => x);

            return (min, max);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tuple Investigation");
            int[] list = { 2, 6, 3, 9, 10, 8, 3, 1 };
            Results answer = DoCalculations(list);
            Console.WriteLine($"The answer is { answer.Min }, { answer.Max }");
            
            (int, int) results = DoListCalculations(list);
            Console.WriteLine($"The answers are { results.Item1 }, { results.Item2 }");
            (int Min, int Max) analysis = DoListAnalysis(list);
            
            Console.WriteLine($"The analysis is { analysis.Min }, { analysis.Max }");


            int a = 100;
            int b = 10;

            Console.WriteLine($"a = {a}, b = {b}");

            (a, b) = (b, a); // swap two variable using a tuple - no need for a third temporary variable

            Console.WriteLine($"a = { a }, b = { b }");



            Card c1 = new Card(1, 1);

            Card c2 = new Card(13, 3);

            Console.WriteLine($"{c1.Suit}, {c1.Value}");
            Console.WriteLine($"{c2.Suit}, {c2.Value}");

            (c1, c2) = (c2, c1);

            Console.WriteLine($"{c1.Suit}, {c1.Value}");
            Console.WriteLine($"{c2.Suit}, {c2.Value}");
            
            (int, double, string) t = (1, 1.1, "one");

            t.Item1 = 10;

            Console.WriteLine(t);




        }
    }
}