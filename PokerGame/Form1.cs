namespace PokerGame
{
    public partial class Form1 : Form
    {
        private Deck deck = new Deck(1);
        private User user;
        bool hasBetted = true;
        int bet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SceneManger.SelectedIndex = 0;
            btnHit.Enabled = false;
            btnStand.Enabled = false;
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
            GetBetFromUser();
            if (hasBetted == true)
            {
                DealCards();
            }
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

        private void btnStand_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            DealerLogic();

            // TODO: fix dealer logic

            // run dealer logic
        }

        public void DealerLogic()
        {
            dealerHand.RevealAll();

            while (dealerHand.score < 17)
            {
                // Keep on drawing
                dealerHand.AddCard(deck.DrawCard());
                dealerHand.Update();
            }
            UpdateScore();
        }

        private void GamePage_Enter(object sender, EventArgs e)
        {
            if (this.Created == true) { }
        }

        private void GetBetFromUser()
        {
            BetForm betForm = new BetForm(user.chip_balance);
            betForm.BringToFront();
            betForm.StartPosition = FormStartPosition.CenterParent;
            var result = betForm.ShowDialog(this.ActiveControl);
            if (result == DialogResult.OK)
            {
                bet = betForm.bet;
                user.chip_balance -= bet;
                lblBalance.Text = user.chip_balance.ToString();
                lblBet.Text = bet.ToString();
                hasBetted = true;
                btnStand.Enabled = true;
                btnHit.Enabled = true;
            }
        }

        private void SceneManger_Validated(object sender, EventArgs e)
        {
            //GetBetFromUser();
        }

        private void GamePage_Validated(object sender, EventArgs e)
        {
            //GetBetFromUser();
        }

        public void DealCards()
        {
            /* TODO: deal 1 card and then switch, rather than
             * dealing two cards to each entity. */
            GiveDealerCards();
            for (int i = 0; i < 2; i++)
            {
                playerHand.AddCard(deck.DrawCard());
            }
            playerHand.Update();
            UpdateScore();
        }
    }
}
