using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Card
    {
        public enum SUIT
        {
            HEARTS,
            SPADES,
            DIAMONDS,
            CLUBS
        }

        public enum VALUE
        {
            ONE = 1, TWO, THREE, FOUR, FIVE, SIX, SEVEN, 
            EIGHT, NINE, JACK, QUEEN, KING, ACE
        }


        public SUIT Suit { get; set; }
        public VALUE Value { get; set; }

        public override string ToString()
        {
            return Value.ToString() + " of " + Suit.ToString();
        }
    }
}
