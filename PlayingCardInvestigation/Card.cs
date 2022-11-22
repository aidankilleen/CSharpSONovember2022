using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardInvestigation
{
    internal class Card
    {
        // member variables (properties)
        public int Suit;  // 1=H, 2=S, 3=D, 4=C
        public int Value; // 1=A, 2=2, 3=3, 4=4, ..., 10=10, 11=J, 12=Q, 13=K

        // member functions

        // constructor(s)
        public Card()
        {
        }
        public Card(int suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        // other functions / methods
        public void Display()
        {
            string card = "";
            // value
            switch(Value)
            {
                case 1:
                    card += " A";
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    card += " " + Value;
                    break;
                case 11:
                    card += " J";
                    break;
                case 12:
                    card += " Q";
                    break;
                case 13:
                    card += " K";
                    break;
                default:
                    card += " ?";
                    break;
            }
            // suit
            if (Suit == 1)
            {
                card = card + "H ";
            } else if (Suit == 2)
            {
                card += "S ";
            } else if (Suit ==3)
            {
                card += "D ";
            } else if (Suit == 4)
            {
                card += "C ";
            } else
            {
                card += "? ";
            }
            Console.Write(card);
        }
    }
}
