namespace StringInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Investigation");

            string message = "This is a string";

            int a = 10;
            int b = 20;
            int answer = a + b;

            // concatenation
            message = "" + a + " + " + b + " = " + answer;

            Console.WriteLine(message);

            // interpolation / substitution
            message = String.Format("{0} + {1} = {2}", a, b, answer);

            Console.WriteLine(message);

            // Console.Writeline using String.Format

            Console.WriteLine("{0} + {1} = {2}", a, b, answer );

            // special sequence of chars

            Console.WriteLine("This \n is \n spread \n over \n multiple \n lines");

            //  \t - tab
            //  \\ - \ character
            string url = "c:\\my documents\\aidan\\file.txt";

            Console.WriteLine(url);

            Console.WriteLine("press the \"red\" button");


            // raw string

            string filename = @"c:\my documents\aidan\file.txt";

            Console.WriteLine(filename);

            // raw strings can span lines
            string multiline = @"
                                this
string
spans
multiple
lines
";

            Console.WriteLine(multiline);

            // interpolated string
            string name = "Aidan";
            message = $"Welcome { name }"; 

            Console.WriteLine(message);

            message = $"{ a } + { b } = { answer }";

            Console.WriteLine(message);

            // note you can put an expression in the token position
            message = $"{ a } + { b } = { a + b }";

            Console.WriteLine(message);

            Random rg = new Random();

            int r = rg.Next(10);

            message = $"the value is {r}, it is { (r < 5 ? "small" : "large") }";

            Console.WriteLine(message);

            // you combine raw and interpolated strings

            message = @$"
   { a }
 + { b }
---------
   { a + b }
";
            Console.WriteLine(message);












        }
    }
}