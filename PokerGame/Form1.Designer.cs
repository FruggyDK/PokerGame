namespace PokerGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SceneManger = new System.Windows.Forms.TabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.GamePage = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDealerCards = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPlayerCards = new System.Windows.Forms.GroupBox();
            this.ProfilePage = new System.Windows.Forms.TabPage();
            this.menuPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SceneManger.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.GamePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SceneManger
            // 
            this.SceneManger.Controls.Add(this.LoginPage);
            this.SceneManger.Controls.Add(this.GamePage);
            this.SceneManger.Controls.Add(this.ProfilePage);
            this.SceneManger.Controls.Add(this.menuPage);
            this.SceneManger.Location = new System.Drawing.Point(1, -2);
            this.SceneManger.Name = "SceneManger";
            this.SceneManger.SelectedIndex = 0;
            this.SceneManger.Size = new System.Drawing.Size(1049, 557);
            this.SceneManger.TabIndex = 6;
            this.SceneManger.Selected += new System.Windows.Forms.TabControlEventHandler(this.SceneManger_Selected);
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.btnLogin);
            this.LoginPage.Controls.Add(this.txtPassword);
            this.LoginPage.Controls.Add(this.txtUsername);
            this.LoginPage.Location = new System.Drawing.Point(4, 24);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(1041, 529);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Login";
            this.LoginPage.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(307, 217);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(293, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(293, 127);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // GamePage
            // 
            this.GamePage.Controls.Add(this.button5);
            this.GamePage.Controls.Add(this.button4);
            this.GamePage.Controls.Add(this.textBox1);
            this.GamePage.Controls.Add(this.richTextBox1);
            this.GamePage.Controls.Add(this.lblBet);
            this.GamePage.Controls.Add(this.label6);
            this.GamePage.Controls.Add(this.lblBalance);
            this.GamePage.Controls.Add(this.label4);
            this.GamePage.Controls.Add(this.pictureBox8);
            this.GamePage.Controls.Add(this.pictureBox7);
            this.GamePage.Controls.Add(this.pictureBox6);
            this.GamePage.Controls.Add(this.pictureBox2);
            this.GamePage.Controls.Add(this.button3);
            this.GamePage.Controls.Add(this.label2);
            this.GamePage.Controls.Add(this.label1);
            this.GamePage.Controls.Add(this.gbDealerCards);
            this.GamePage.Controls.Add(this.button2);
            this.GamePage.Controls.Add(this.button1);
            this.GamePage.Controls.Add(this.gbPlayerCards);
            this.GamePage.Location = new System.Drawing.Point(4, 24);
            this.GamePage.Name = "GamePage";
            this.GamePage.Padding = new System.Windows.Forms.Padding(3);
            this.GamePage.Size = new System.Drawing.Size(1041, 529);
            this.GamePage.TabIndex = 1;
            this.GamePage.Text = "Game";
            this.GamePage.UseVisualStyleBackColor = true;
            this.GamePage.Click += new System.EventHandler(this.GamePage_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(720, 447);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 47);
            this.button5.TabIndex = 24;
            this.button5.Text = "Reveal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(960, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 26);
            this.button4.TabIndex = 23;
            this.button4.Text = "Send";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(797, 408);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 23);
            this.textBox1.TabIndex = 22;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(797, 248);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(206, 154);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(77, 131);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(13, 15);
            this.lblBet.TabIndex = 20;
            this.lblBet.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bet:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(77, 78);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(13, 15);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Balance:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::PokerGame.Properties.Resources.card_back;
            this.pictureBox8.Location = new System.Drawing.Point(59, 206);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 144);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PokerGame.Properties.Resources.card_back;
            this.pictureBox7.Location = new System.Drawing.Point(56, 218);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 144);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PokerGame.Properties.Resources.card_back;
            this.pictureBox6.Location = new System.Drawing.Point(56, 226);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 144);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PokerGame.Properties.Resources.card_back;
            this.pictureBox2.Location = new System.Drawing.Point(55, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(869, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(869, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbDealerCards
            // 
            this.gbDealerCards.BackColor = System.Drawing.Color.LightGray;
            this.gbDealerCards.Location = new System.Drawing.Point(229, 20);
            this.gbDealerCards.Name = "gbDealerCards";
            this.gbDealerCards.Size = new System.Drawing.Size(539, 190);
            this.gbDealerCards.TabIndex = 8;
            this.gbDealerCards.TabStop = false;
            this.gbDealerCards.Text = "Dealers Cards:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Stand";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbPlayerCards
            // 
            this.gbPlayerCards.BackColor = System.Drawing.Color.LightGray;
            this.gbPlayerCards.Location = new System.Drawing.Point(229, 232);
            this.gbPlayerCards.Name = "gbPlayerCards";
            this.gbPlayerCards.Size = new System.Drawing.Size(539, 190);
            this.gbPlayerCards.TabIndex = 6;
            this.gbPlayerCards.TabStop = false;
            this.gbPlayerCards.Text = "Your Cards:";
            this.gbPlayerCards.Visible = false;
            // 
            // ProfilePage
            // 
            this.ProfilePage.Location = new System.Drawing.Point(4, 24);
            this.ProfilePage.Name = "ProfilePage";
            this.ProfilePage.Padding = new System.Windows.Forms.Padding(3);
            this.ProfilePage.Size = new System.Drawing.Size(1041, 529);
            this.ProfilePage.TabIndex = 2;
            this.ProfilePage.Text = "Profile";
            this.ProfilePage.UseVisualStyleBackColor = true;
            // 
            // menuPage
            // 
            this.menuPage.Controls.Add(this.label3);
            this.menuPage.Controls.Add(this.btnLogout);
            this.menuPage.Controls.Add(this.btnProfile);
            this.menuPage.Controls.Add(this.btnPlay);
            this.menuPage.Location = new System.Drawing.Point(4, 24);
            this.menuPage.Name = "menuPage";
            this.menuPage.Padding = new System.Windows.Forms.Padding(3);
            this.menuPage.Size = new System.Drawing.Size(1041, 529);
            this.menuPage.TabIndex = 3;
            this.menuPage.Text = "Menu";
            this.menuPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(309, 224);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(309, 195);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(309, 166);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1078, 559);
            this.Controls.Add(this.SceneManger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SceneManger.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.GamePage.ResumeLayout(false);
            this.GamePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuPage.ResumeLayout(false);
            this.menuPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl SceneManger;
        private TabPage LoginPage;
        private TabPage ProfilePage;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private TabPage GamePage;
        private Button button2;
        private Button button1;
        private GroupBox gbPlayerCards;
        private GroupBox gbDealerCards;
        private Label label2;
        private Label label1;
        private Button button3;
        private TabPage menuPage;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnPlay;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Label label4;
        private PictureBox pictureBox8;
        private Label lblBalance;
        private Label lblBet;
        private Label label6;
        private Button button4;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Button button5;
    }
}