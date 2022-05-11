namespace PokerGame
{
    public partial class Form1 : Form
    {
        // TODO: retrive the following two values from settings
        private const int numberOfDecks = 1;
        private const int defaultChipBalance = 1000;

        private Deck deck = new Deck(1);
        private User user;
        bool hasBetted = true;
        int bet;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // quick and dirty fix for hiding headers for each tabpage
            SceneControl.Appearance = TabAppearance.FlatButtons;
            SceneControl.ItemSize = new Size(0, 1);
            SceneControl.SizeMode = TabSizeMode.Fixed;
            foreach (TabPage tab in SceneControl.TabPages)
            {
                tab.Text = string.Empty;
            }

            SceneControl.SelectedIndex = 0;
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
            if (playerHand.cards.Count == 4)
            {
                MessageBox.Show("No mooooore caaaards foor u");
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
                user.SyncWithDatabase();
                SceneControl.SelectTab(menuPage);
            }
            else if (user_id == -1)
            {
                MessageBox.Show("Couldn't login. Please try again");
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Handle logout?
            SceneControl.SelectTab(LoginPage);
        }

        private void SceneManger_Selected(object sender, TabControlEventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SceneControl.SelectTab(GamePage);
            Play();
        }

        public void Play()
        {
            GetBetFromUser();
            if (hasBetted == true)
            {
                DealCards();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet...");
            //SceneManger.SelectTab(ProfilePage);
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

            // Find winner
            FindWinner();
        }

        public void FindWinner()
        {
            if (playerHand.score <= 21)
            {
                if (playerHand.score > dealerHand.score)
                {
                    MessageBox.Show("Player win");
                    user.chip_balance += 2 * bet;
                }
                else if (playerHand.score < dealerHand.score && dealerHand.score < 21)
                {
                    MessageBox.Show("Dealer win");
                }
                else if (playerHand.score == dealerHand.score)
                {
                    MessageBox.Show("Draw");
                    user.chip_balance += bet;
                }
                else if (dealerHand.score > 21)
                {
                    MessageBox.Show("Dealer goes bust");
                    MessageBox.Show("Player wins");
                    user.chip_balance += 2 * bet;
                }
            }
            else
            {
                // Player goes bust and loses bet
                MessageBox.Show("Player goes bust. House wins");
                bet = 0;
            }

            // Sync user with database
            user.SyncWithDatabase();

            // ask for replay
            var result = MessageBox.Show(
                "Do you want to replay?",
                "Play again?",
                MessageBoxButtons.YesNo
            );
            if (result == DialogResult.Yes)
            {
                resetRound();
                Play();
            }
            else
            {
                SceneControl.SelectTab(menuPage);
            }
        }

        public void resetRound()
        {
            playerHand.ClearHand();
            dealerHand.ClearHand();
            lblBalance.Text = user.chip_balance.ToString();
            bet = 0;
            lblBet.Text = bet.ToString();
            hasBetted = false;
            UpdateScore();

            if (deck.cards.Count <= 10)
            {
                deck.cards.Clear();
                deck = new Deck(1);
            }
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

        private void txtUsername_TextChanged(object sender, EventArgs e) { }

        private void txtPassword_TextChanged(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(defaultChipBalance);
            registerForm.ShowDialog(this.ActiveControl);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SceneControl.SelectTab(menuPage);
        }
    }
}
