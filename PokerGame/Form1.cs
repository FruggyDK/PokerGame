namespace PokerGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Deck deck = new Deck();

            /*foreach (Card card in deck.deck)
            {
                listView1.Items.Add(card.ToString());
            }
            */
            int i = 0;
            deck.cards.ForEach(
                Card =>
                {
                    this.Controls.Add(Card.Show());
                    Card.Show().Location = new Point(i, i);
                    i++;
                }
            );


            this.Controls.Add(deck.cards[0].Show());
            deck.cards[0].Show().Location = new Point(0, 0);


            var spades = deck.cards.Where(card => card.Suit == Card.SUIT.SPADES).ToList();

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


        }
    }
}
