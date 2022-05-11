namespace PokerGame
{
    public partial class RegisterForm : Form
    {
        private int defaultChipBalance;

        public RegisterForm(int defaultChipBalance)
        {
            InitializeComponent();
            this.defaultChipBalance = defaultChipBalance;
        }

        private void RegisterForm_Load(object sender, EventArgs e) { }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            //TODO: add checks

            long userId = DatabaseHandler.CreateUser(defaultChipBalance);
            bool result = DatabaseHandler.CreateLogin(username, password, userId);
            if (result == true)
            {
                MessageBox.Show("Succesfully created account");
            }
        }
    }
}
