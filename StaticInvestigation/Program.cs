namespace StaticInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Investigation");
            Message m1 = new Message("M1", "this is m1");
            Console.WriteLine(Message.Count);
            Message m2 = new Message("M2", "this is m2");
            Console.WriteLine(Message.Count);



            //Console.WriteLine
            //Program.Main()

            //Console.WriteLine()
            //String.Format()

            string n = "99";

            //int v = (int)n;

            int v = int.Parse(n);
            Console.WriteLine(v);

            //v = int.Parse("ninety nine");


            double d = double.Parse("1.2345");
            Console.WriteLine(d);

            Console.WriteLine($"Max int:{int.MaxValue}");

            Console.WriteLine($"Max short: {short.MaxValue}");

            Console.WriteLine(Math.Sqrt(32768));

            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);


            Console.Beep();





        }
    }
}