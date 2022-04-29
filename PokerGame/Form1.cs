namespace PokerGame
{
    public partial class Form1 : Form
    {
        private Deck deck = new Deck();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*var spades = deck.cards.Where(card => card.Suit == Card.SUIT.SPADES).ToList();

            var sum = deck.cards
                .Where(Card => Card.Suit == Card.SUIT.SPADES)
                .Select(Card => ((int)Card.Value))
                .Sum();

            Func<int, bool> isEven = n => n % 2 == 0;
            Func<int, bool> isOdd = n => n % 2 != 0;
            List<int> numbers = new() { 12, 321, 1, 2, 3, 4, 5, 56 };

            List<int> odd = numbers.Where(isOdd).ToList();

            List<int> even = numbers.Where(isEven).ToList();
            string arr = "";

            odd.ForEach(
                n =>
                {
                    arr += (n + ", ").ToString();
                }
            );

            MessageBox.Show(arr);

            MessageBox.Show(spades.ToArray().ToString());
            Player player = new Player();
            //MessageBox.Show(player.address.ToString());
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i <= 12; i++)
                {
                    Card card = deck.DrawCard();
                    GamePage.Controls.Add(card.Show(new Point((10 + 53) * i + 5, 90 * j + 5)));
                    
                }
            }
        }

        private void GamePage_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtUsername + " " + txtPassword);
            if (DatabaseHandler.TestConnection())
            {
                MessageBox.Show("Succesfully connected to database");
            } else
            {
                MessageBox.Show("Could not establish a connection to the database: " + Properties.Settings.Default.Database);
            }
        }
    }
}
