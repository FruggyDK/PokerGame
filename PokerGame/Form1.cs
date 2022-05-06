namespace PokerGame
{
    public partial class Form1 : Form
    {
        private Deck deck = new Deck();
        private User user;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SceneManger.SelectedIndex = 1;
        }

        private void AddCardToGroupBox(GroupBox groupBox, Card card)
        {
            int spacing = 15;
            int cardCount = groupBox.Controls.Count;
            PictureBox cardSprite = card.Sprite();
            // DEBUG
            MessageBox.Show(card.ToString());
            if (cardCount < 4)
            {
                groupBox.Controls.Add(
                    card.Show(new Point((cardSprite.Width + spacing) * cardCount + spacing, 30))
                );
            }
        }

        private void UpdateScore()
        {
            // Update players score
            int playerScore = CalculateScoreOfHand(gbPlayerCards);
            label1.Text = playerScore.ToString();
        }

        private int CalculateScoreOfHand(GroupBox hand)
        {
            int score = 0;
            foreach (PictureBox card in gbPlayerCards.Controls)
            {
                switch (card.Tag)
                {
                    case Card.VALUE.ACE:
                        score += 10;
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
                        score += (int)card.Tag;
                        break;
                }
            }

            return score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card card = deck.DrawCard();

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

        private void GamePage_Click(object sender, EventArgs e) { }

        private void pictureBox4_Click(object sender, EventArgs e) { }

        private void pictureBox7_Click(object sender, EventArgs e) { }
    }
}
