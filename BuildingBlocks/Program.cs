namespace BuildingBlocks
{
    internal class Program
    {
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static int Add(int a, int b)
        {
            //return "the answer is " + (a + b);
            return a + b;
        }

        static void Main(string[] args)
        {
            // building block #6 
            // functions
            int aaa = 10;
            int bbb = 20;

            int result = Add(aaa, bbb);
            Console.WriteLine(result);


            /* This is a comment 
                It is a multi-line comment
             */
            Console.WriteLine("Programming Building Blocks"); // this is also a comment


            // building block #2
            // variables
            int i = 10;
            double d = 1.23456;
            string name = "Aidan";

            // name = 99;
            int answer = (int)(d * 2);
            Console.WriteLine(answer);
            // all variables are objects
            Console.WriteLine(name.ToUpper());


            // building block #3
            // expressions
            int aa = 10;
            int bb = 20;
            int cc = 10;
            int dd = 5;
            int ee = 10;
            answer = (aa * ((bb / cc) + dd)) - ee;  // PEMDAS

            // building block #4
            // list / array

            int[] list = { 1, 3, 2, 5, 8, 10, 4 };

            Console.WriteLine(list[1]);  // array index starts at 0

            Console.WriteLine(list.Length);

            // Console.WriteLine(list[7]);

            string[] names = { "Alice", "Bob", "Carol", "Dan", "Eve" };


            // loops

            // while
            Console.WriteLine("Names: (while loop)");
            int index = 0;
            while (index < names.Length)
            {
                Console.WriteLine(names[index++]);
                //index = index + 1;
            }

            Console.WriteLine("Names: (for loop)");
            // for
            for (index = 0; index < names.Length; index++)
            {
                Console.WriteLine(names[index]);
            }

            Console.WriteLine("Names: (foreach loop)");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }


            // building block #5 
            // conditions

            Random rg = new Random();
            int r = rg.Next(10);
            if ( r <= 3)
            {
                Console.WriteLine("Small number:" + r);
            } else if (r <= 7)
            {
                Console.WriteLine("Medium number:" + r);
            } else
            {
                Console.WriteLine("Large number:" + r);
            }

            switch (r)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Small number:" + r);
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Medium number:" + r);
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Large number:" + r);
                    break;
                default:
                    break;
            }

            // ternary operator

            Console.WriteLine("r = " + r);
            Console.WriteLine("The value is "+ (r < 5 ? "small" : "large"));

            // equivalent to this (7 lines vs 1 line)
            if (r < 5)
            {
                Console.WriteLine("The value is small");
            } else
            {
                Console.WriteLine("The value is large");
            }




        }
    }
}