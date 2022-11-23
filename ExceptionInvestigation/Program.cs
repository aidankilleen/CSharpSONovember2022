namespace ExceptionInvestigation
{

    class AidansException : Exception
    {
        public AidansException(String message)
            :base(message)
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Investigation");

            int a = 100;
            int b = 0;
            int[] list = { 1, 2, 3 };
            int answer;

            string s = null;



            Random rg = new Random();
            int r = rg.Next(5);
            Console.WriteLine($"r={r}");
            try
            {
                switch(r)
                {
                    case 0:
                        answer = a / b;
                        break;
                    case 1:
                        answer = list[3];
                        break;
                    case 2:
                        answer = s.Length;
                        break;
                    case 3:
                        throw new AidansException("Something went wrong");
                    default:
                        // no error
                        answer = 42;
                        break;
                }

            } catch(DivideByZeroException ex)
            {
                Console.WriteLine("Divide by 0");
                answer = 0;
            } catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range");
                answer = list[0];
            } catch(AidansException ex)
            {
                Console.WriteLine("Custom Exception");
                answer = 0;
            }
            catch(Exception ex)
            {
                // every other possible error 
                Console.WriteLine($"Some other exception: {ex.Message}");
                answer = 1;
            }
            Console.WriteLine($"The answer is { answer }");
            Console.WriteLine("Finished");


            Card c = new Card();

            try
            {
                c.Suit = 99;

            } catch(Exception ex)
            {
                c.Suit = 1; // make it a heart by default
            }

            Console.WriteLine(c.Suit);



            /*
            try
            {
                DoSomething();
                DoSomethingElse();

            } catch(NetworkException ex)
            {

            } catch(UserException ex)
            {

            } catch(Exception ex)
            {
                // some other exception 
            }
            */








            /*
            int r = DoSomething();
            if (r == 0)
            {
                // everthing ok
            } else if (r == -1)
            {
                // network error
            } else if (r == -2)
            {
                // user error
            } else if (r == -3)
            {
                // some other errror
            }
            r = DoSomethingElse();
            if (r == 0)
            {
                // everthing ok
            }
            else if (r == -1)
            {
                // network error
            }
            else if (r == -2)
            {
                // user error
            }
            else if (r == -3)
            {
                // some other errror
            }
            */



        }
    }
}