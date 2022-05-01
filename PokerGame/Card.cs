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
            TWO = 2,
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
            ACE
        }

        public SUIT Suit { get; set; }
        public VALUE Value { get; set; }

        public override string ToString()
        {
            return Value.ToString() + " of " + Suit.ToString();
        }

        public PictureBox Sprite()
        {
            string pictureCards = "JQKA";
            string suit = this.Suit.ToString()[0].ToString();
            int value = (int)this.Value;
            string cardValue = value.ToString();

            if (value > 10)
            {
                cardValue = pictureCards[value - 11].ToString();
            }
            string filename = suit + cardValue;
            Image img = (Image)Properties.Resources.ResourceManager.GetObject(filename);
            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                Image = img,
                Name = this.ToString()
            };
            pictureBox.Click += Card_click;
            return pictureBox;
        }

        public PictureBox Show(Point location)
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
