using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerGame
{
    public partial class BetForm : Form
    {
        private int balance;
        public int bet { get; set; }

        public BetForm(int balance)
        {
            InitializeComponent();
            this.balance = balance;
            lblBalance.Text = balance.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBet.Text == String.Empty)
            {
                MessageBox.Show("You must enter a bet");
            }
            else
            {
                bet = int.Parse(txtBet.Text);
                if (bet > balance)
                {
                    MessageBox.Show("Insufficient amount of chips; Lower your bet");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
