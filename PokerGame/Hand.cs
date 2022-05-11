namespace PokerGame
{
    internal class Hand : GroupBox
    {
        public List<Card> cards;
        public int score;

        public Hand()
        {
            cards = new List<Card>();
            EvaluateScore();
            this.BackColor = Color.LightGray;
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void ClearHand()
        {
            cards.Clear();
            this.Controls.Clear();
        }

        public int EvaluateScore()
        {
            score = 0;
            foreach (Card card in cards)
            {
                if (card.revealed == true)
                {
                    switch (card.Value)
                    {
                        case Card.VALUE.ACE:
                            score += 11;
                            break;
                        case Card.VALUE.JACK:
                            score += 10;
                            break;
                        case Card.VALUE.KING:
                            score += 10;
                            break;
                        case Card.VALUE.QUEEN:
                            score += 10;
                            break;
                        default:
                            score += (int)card.Value;
                            break;
                    }
                }
            }

            int aceCount = cards.Where(card => card.Value == Card.VALUE.ACE).Count();

            while (aceCount > 0)
            {
                if (score > 21)
                {
                    score -= 10;
                    aceCount--;
                }
            }

            return score;
        }

        public void RevealAll()
        {
            cards.ForEach(
                card =>
                {
                    if (card.revealed == false)
                    {
                        card.revealed = true;
                    }
                }
            );

            Redraw();
            EvaluateScore();
        }

        public void Draw()
        {
            int spacing = 20;
            int cardCount = cards.Count;
            foreach (Card card in cards)
            {
                int index = cards.IndexOf(card);
                PictureBox cardSprite = card.Sprite();
                if (cardCount <= 4)
                {
                    this.Controls.Add(
                        card.ShowAt(new Point((cardSprite.Width + spacing) * index + spacing, 30))
                    );
                }
            }
        }

        public new void Update()
        {
            if (cards.Count != this.Controls.Count)
            {
                Redraw();
            }
            EvaluateScore();
        }

        public void Redraw()
        {
            // Forces redraw
            this.Controls.Clear();
            Draw();
        }
    }
}
