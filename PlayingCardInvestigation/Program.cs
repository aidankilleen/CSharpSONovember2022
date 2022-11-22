namespace PlayingCardInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Playing Card Investigation");

            Card c = new Card(1, 1);
            c.Display(); // AH

            c = new Card(2, 2);
            c.Display();

            c = new Card(4, 13);
            c.Display();

            c = new Card(3, 12);
            c.Display();

            Console.WriteLine("All cards:"); 
            for(int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    c = new Card(suit, value);
                    c.Display();
                }
            }


            c = new Card(99, 99);

            c.Display();




        }
    }
}