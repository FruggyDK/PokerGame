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
            ACE = 1,
            TWO,
            THREE,
            FOUR,
            FIVE,
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK,
            QUEEN,
            KING,
        }

        public SUIT Suit { get; set; }
        public VALUE Value { get; set; }

        public bool revealed { get; set; }

        public override string ToString()
        {
            return Value.ToString() + " of " + Suit.ToString();
        }

        public PictureBox Sprite()
        {
            string filename;
            if (revealed == false)
            {
                filename = "card_back";
            }
            else
            {
                string suit = this.Suit.ToString()[0].ToString();
                int value = (int)this.Value;
                string cardValue = value.ToString();

                filename = "_" + cardValue + suit;
            }

            Image img = (Image)Properties.Resources.ResourceManager.GetObject(filename);

            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                Image = img,
                Name = this.ToString(),
            };
            pictureBox.Click += Card_click;
            return pictureBox;
        }

        public PictureBox ShowAt(Point location)
        {
            PictureBox sprite = Sprite();
            sprite.Location = location;
            return sprite;
        }

        private void Card_click(object sender, EventArgs e)
        {
            MessageBox.Show(((PictureBox)sender).Name);
        }
    }
}
