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
            this.lblRemainingCards = new System.Windows.Forms.Label();
            this.dealerHand = new PokerGame.Hand();
            this.playerHand = new PokerGame.Hand();
            this.lblBet = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.ProfilePage = new System.Windows.Forms.TabPage();
            this.menuPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
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
            this.SceneManger.Validated += new System.EventHandler(this.SceneManger_Validated);
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
            this.GamePage.Controls.Add(this.lblRemainingCards);
            this.GamePage.Controls.Add(this.dealerHand);
            this.GamePage.Controls.Add(this.playerHand);
            this.GamePage.Controls.Add(this.lblBet);
            this.GamePage.Controls.Add(this.label6);
            this.GamePage.Controls.Add(this.lblBalance);
            this.GamePage.Controls.Add(this.label4);
            this.GamePage.Controls.Add(this.pictureBox8);
            this.GamePage.Controls.Add(this.pictureBox7);
            this.GamePage.Controls.Add(this.pictureBox6);
            this.GamePage.Controls.Add(this.pictureBox2);
            this.GamePage.Controls.Add(this.label2);
            this.GamePage.Controls.Add(this.label1);
            this.GamePage.Controls.Add(this.btnStand);
            this.GamePage.Controls.Add(this.btnHit);
            this.GamePage.Location = new System.Drawing.Point(4, 24);
            this.GamePage.Name = "GamePage";
            this.GamePage.Padding = new System.Windows.Forms.Padding(3);
            this.GamePage.Size = new System.Drawing.Size(1041, 529);
            this.GamePage.TabIndex = 1;
            this.GamePage.Text = "Game";
            this.GamePage.UseVisualStyleBackColor = true;
            this.GamePage.Enter += new System.EventHandler(this.GamePage_Enter);
            this.GamePage.Validated += new System.EventHandler(this.GamePage_Validated);
            // 
            // lblRemainingCards
            // 
            this.lblRemainingCards.AutoSize = true;
            this.lblRemainingCards.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRemainingCards.Location = new System.Drawing.Point(91, 412);
            this.lblRemainingCards.Name = "lblRemainingCards";
            this.lblRemainingCards.Size = new System.Drawing.Size(24, 27);
            this.lblRemainingCards.TabIndex = 27;
            this.lblRemainingCards.Text = "0";
            // 
            // dealerHand
            // 
            this.dealerHand.Location = new System.Drawing.Point(273, 28);
            this.dealerHand.Name = "dealerHand";
            this.dealerHand.Size = new System.Drawing.Size(500, 190);
            this.dealerHand.TabIndex = 26;
            this.dealerHand.TabStop = false;
            this.dealerHand.Text = "Dealers Hand";
            // 
            // playerHand
            // 
            this.playerHand.Location = new System.Drawing.Point(273, 236);
            this.playerHand.Name = "playerHand";
            this.playerHand.Size = new System.Drawing.Size(500, 190);
            this.playerHand.TabIndex = 25;
            this.playerHand.TabStop = false;
            this.playerHand.Text = "Your Hand";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBet.Location = new System.Drawing.Point(91, 155);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(26, 30);
            this.lblBet.TabIndex = 20;
            this.lblBet.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(77, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 30);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bet:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.Location = new System.Drawing.Point(91, 78);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(26, 30);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 17;
            this.label4.Text = "Balance:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::PokerGame.Properties.Resources.card_back;
            this.pictureBox8.Location = new System.Drawing.Point(60, 219);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 144);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PokerGame.Properties.Resources.card_back;
            this.pictureBox7.Location = new System.Drawing.Point(57, 231);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 144);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PokerGame.Properties.Resources.card_back;
            this.pictureBox6.Location = new System.Drawing.Point(57, 239);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 144);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PokerGame.Properties.Resources.card_back;
            this.pictureBox2.Location = new System.Drawing.Point(56, 245);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 144);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(823, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(823, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(569, 447);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(67, 47);
            this.btnStand.TabIndex = 7;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(409, 447);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(67, 47);
            this.btnHit.TabIndex = 5;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
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
            this.menuPage.Controls.Add(this.label5);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(352, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Scuffed Black Jack";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(443, 235);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 22);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(443, 206);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 22);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(443, 177);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 22);
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
            this.ClientSize = new System.Drawing.Size(1045, 549);
            this.Controls.Add(this.SceneManger);
            this.Name = "Form1";
            this.Text = "Scuffed Black Jack ";
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
        private Button btnStand;
        private Button btnHit;
        private Label label2;
        private Label label1;
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
        private Hand dealerHand;
        private Hand playerHand;
        private Label lblRemainingCards;
        private Label label5;
    }
}