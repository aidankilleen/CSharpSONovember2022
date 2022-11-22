namespace PlayingCardInvestigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Playing Card Investigation");

            Card c = new Card(Suits.Heart, 1);
            c.Display(); // AH

            c = new Card(Suits.Diamond, 2);
            c.Display();

            c = new Card(Suits.Spade, 13);
            c.Display();

            c = new Card(Suits.Club, 12);
            c.Display();

            Console.WriteLine("All cards:"); 
            for(int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    c = new Card((Suits)suit, value);
                    c.Display();
                }
            }







        }
    }
}