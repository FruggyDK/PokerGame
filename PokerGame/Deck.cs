using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    internal class Deck : Card
    {
        const int NUM_OF_CARDS = 52;
        public List<Card> deck;

        public Deck()
        {
            deck = new List<Card>(NUM_OF_CARDS);
            PopulateDeck();
        }

        private void PopulateDeck()
        {
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck.Add(new Card { Suit = s, Value = v });
                }
            }

            ShuffleDeck();
        }

        private void ShuffleDeck()
        {
            Random rand = new Random();
            for (int i = 0; i < NUM_OF_CARDS; i++)
            {
                int j = rand.Next(0, deck.Count);
                Card tmp = deck[j];
                deck[j] = deck[i];
                deck[i] = tmp;
            }
        }

        public Card DrawCard()
        {
            Card card = deck[deck.Count - 1];
            deck.RemoveAt(deck.Count - 1);
            return card;
        }
    }
}
