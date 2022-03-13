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

            foreach (Card card in deck.deck)
            {
                listView1.Items.Add(card.ToString());
            }

            Player player = new Player();
            //MessageBox.Show(player.address.ToString());
            

        }
    }
}