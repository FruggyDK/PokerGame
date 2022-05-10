namespace PokerGame
{
    public partial class Form1 : Form
    {
        private Deck deck = new Deck(1);
        private User user;
        bool hasBetted = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SceneManger.SelectedIndex = 1;
            GiveDealerCards();
            if (hasBetted)
            {
                // Game logic
            }
        }

        private void UpdateScore()
        {
            // Update players score
            label1.Text = playerHand.EvaluateScore().ToString();
            label2.Text = dealerHand.EvaluateScore().ToString();
            lblRemainingCards.Text = deck.cards.Count.ToString();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (playerHand.score > 21)
            {
                MessageBox.Show("BUST!!");
            }
            else if (playerHand.score == 21)
            {
                MessageBox.Show("Blackjack!");
            }
            else
            {
                playerHand.AddCard(deck.DrawCard());
                playerHand.Update();
                UpdateScore();
            }
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
            label1.Text = "0";
            label2.Text = "0";
            playerHand.ClearHand();
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
            dealerHand.AddCard(deck.DrawCardFaceDown());
            dealerHand.AddCard(deck.DrawCard());
            dealerHand.Update();
            UpdateScore();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DealerLogic();

            // TODO: fix dealer logic

            // run dealer logic
        }

        public void DealerLogic()
        {
            dealerHand.RevealAll();
            label2.Text = dealerHand.EvaluateScore().ToString();

            while (dealerHand.EvaluateScore() <= 17)
            {
                // Keep on drawing
                dealerHand.AddCard(deck.DrawCard());
                dealerHand.Update();
            }
        }
    }
}
