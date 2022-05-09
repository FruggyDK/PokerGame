namespace PokerGame
{
    public partial class Form1 : Form
    {
        private Deck deck = new Deck();
        private List<Card> DealerHand = new List<Card>();
        private User user;
        bool hasBetted = true;
        Hand playerHand = new Hand();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerHand.Location = new Point(229, 232);
            playerHand.Text = "Your Cards:";
            playerHand.Size = new Size(539, 190);
            playerHand.BackColor = Color.LightGray;
            playerHand.BringToFront();
            GamePage.Controls.Add(playerHand);
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 3; i++)
            {
                Card card = deck.DrawCardFaceDown();
                MessageBox.Show(card.ToString());
                cards.Add(card);
            }

            playerHand.cards = cards;
            MessageBox.Show(playerHand.cards.Count.ToString());
            playerHand.Draw();
            SceneManger.SelectedIndex = 1;
            if (hasBetted)
            {
                for (int i = 1; i <= 2; i++)
                {
                    Card card = deck.DrawCard();
                    AddCardToGroupBox(gbPlayerCards, card);
                }
            }
        }

        private void AddCardToGroupBox(GroupBox groupBox, Card card)
        {
            if (groupBox == gbDealerCards)
            {
                DealerHand.Add(card);
            }
            int spacing = 15;
            int cardCount = groupBox.Controls.Count;
            PictureBox cardSprite = card.Sprite();
            // DEBUG
            MessageBox.Show(card.ToString());
            if (cardCount < 4)
            {
                groupBox.Controls.Add(
                    card.ShowAt(new Point((cardSprite.Width + spacing) * cardCount + spacing, 30))
                );
            }
        }

        private void UpdateScore()
        {
            // Update players score
            int playerScore = CalculateScoreOfHand(gbPlayerCards);
            label1.Text = playerScore.ToString();
            int dealerScore = CalculateScoreOfHand(gbDealerCards);
            label2.Text = dealerScore.ToString();
        }

        private void RevealAllCardsInHand(GroupBox hand)
        {
            foreach (PictureBox card in hand.Controls)
            {
                BetterTags tags = (BetterTags)card.Tag;
                if ((bool)tags.Get("Revealed") == false)
                {
                    int index = gbDealerCards.Controls.IndexOf(card);
                    DealerHand[index].revealed = true;
                    Point location = hand.Controls[index].Location;
                    hand.Controls.RemoveAt(index);
                    hand.Controls.Add(DealerHand[index].ShowAt(location));
                }
            }
        }

        private int CalculateScoreOfHand(GroupBox hand)
        {
            int score = 0;
            foreach (PictureBox card in hand.Controls)
            {
                BetterTags tags = (BetterTags)card.Tag;
                Card.VALUE value = (Card.VALUE)tags.Get("Value");
                bool revealed = (bool)tags.Get("Revealed");
                if (revealed == true)
                {
                    switch (value)
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
                            score += (int)value;
                            break;
                    }

                    // Handle ACE cases

                    int aceCount = DealerHand.Where(card => card.Value == Card.VALUE.ACE).Count();
                    MessageBox.Show(aceCount.ToString());
                }
            }

            return score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card card = deck.DrawCard();
            playerHand.AddCard(card);
            playerHand.Draw();
            playerHand.Update();

            if (gbPlayerCards.Controls.Count < 4)
            {
                AddCardToGroupBox(gbPlayerCards, card);
            }
            else
            {
                AddCardToGroupBox(gbDealerCards, card);
            }

            gbPlayerCards.BackColor = Color.White;

            UpdateScore();

            /*for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i <= 12; i++)
                {
                    Card card = deck.DrawCard();
                    GamePage.Controls.Add(card.Show(new Point((10 + 53) * i + 5, 90 * j + 5)));
                    
                }
            }*/
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            long user_id = DatabaseHandler.Login(username, password);
            if (user_id != -1)
            {
                user = new User(user_id, username);
                label3.Text = "Nice to see you, " + username + "!";
                lblBalance.Text = user.chip_balance.ToString();
                MessageBox.Show(user.chip_balance.ToString());
                user.chip_balance = 9999;
                user.SyncWithDatabase();
                SceneManger.SelectTab(menuPage);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbDealerCards.Controls.Clear();
            gbPlayerCards.Controls.Clear();
            label1.Text = "0";
            label2.Text = "0";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Handle logout?
            SceneManger.SelectTab(LoginPage);
        }

        private void SceneManger_Selected(object sender, TabControlEventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SceneManger.SelectTab(GamePage);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            SceneManger.SelectTab(ProfilePage);
        }

        public void GiveDealerCards()
        {
            Card card1 = deck.DrawCard();
            Card card2 = deck.DrawCardFaceDown();
            AddCardToGroupBox(gbDealerCards, card1);
            AddCardToGroupBox(gbDealerCards, card2);
        }

        private void GamePage_Click(object sender, EventArgs e) { }

        private void pictureBox4_Click(object sender, EventArgs e) { }

        private void pictureBox7_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void button5_Click(object sender, EventArgs e)
        {
            playerHand.RevealAll();
            label1.Text = playerHand.EvaluateScore().ToString();
        }
    }
}
