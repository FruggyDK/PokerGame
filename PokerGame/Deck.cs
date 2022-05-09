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
        public List<Card> cards;

        public Deck()
        {
            cards = new List<Card>(NUM_OF_CARDS);
            PopulateDeck();
        }

        private void PopulateDeck()
        {
            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach (VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    cards.Add(
                        new Card
                        {
                            Suit = s,
                            Value = v,
                            revealed = false
                        }
                    );
                }
            }

            ShuffleDeck();
        }

        private void ShuffleDeck()
        {
            Random rand = new Random();
            for (int i = 0; i < NUM_OF_CARDS; i++)
            {
                int j = rand.Next(0, cards.Count);
                Card tmp = cards[j];
                cards[j] = cards[i];
                cards[i] = tmp;
            }
        }

        public Card DrawCard()
        {
            if (cards.Count != 0)
            {
                Card card = cards[cards.Count - 1];
                cards.RemoveAt(cards.Count - 1);
                card.revealed = true;
                return card;
            }
            else
            {
                MessageBox.Show("No more cards to draw!");
                throw new Exception("NoMoreCardsInDeck");
            }
        }

        public Card DrawCardFaceDown()
        {
            Card card = DrawCard();
            card.revealed = false;
            return card;
        }

        public List<Card> DrawCards(int amount)
        {
            List<Card> cards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                cards.Add(DrawCard());
            }
            return cards;
        }
    }
}
