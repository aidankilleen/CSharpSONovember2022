using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionInvestigation
{
    internal class Card
    {
        private int _suit;  // 1 = H, 2 = S, 3 = D, 4 = C
        public int Suit
        {
            get
            {
                return _suit;
            }
            set
            {
                if (value < 1 || value > 4)
                {
                    throw new InvalidDataException($"Invalid value for suit : {value}");
                } else
                {
                    _suit = value;
                }
            }
        }
    }
}
