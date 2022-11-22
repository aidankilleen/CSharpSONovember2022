using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardInvestigation
{
    internal class Deck
    {
        // member variables
        private Card[] cards = new Card[52];
        private int nextCard = 0;

        // member functions
        // constructor(s)
        public Deck()
        {
            // create one of each card
            int count = 0;
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards[count++] = new Card(suit, value);
                }
            }
        }
        public void Display()
        {
            for(int i=0; i< cards.Length; i++)
            {
                cards[i].Display();

                if ( i == 12 || i == 25 || i== 38 || i == 51)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public Card Deal()
        {
            // deal the next card from the deck
            return cards[nextCard++];
        }

        // other methods

        static void Main(string[] args)
        {
            Console.WriteLine("Deck Investigation");

            Deck deck = new Deck();
            deck.Display();

            // deck.Shuffle();





            Card c = deck.Deal();
            c.Display();

            c = deck.Deal();
            c.Display();

            c = deck.Deal();
            c.Display();





        }
    }
}
