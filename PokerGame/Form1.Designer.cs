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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDealerCards = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbPlayerCards = new System.Windows.Forms.GroupBox();
            this.ProfilePage = new System.Windows.Forms.TabPage();
            this.SceneManger.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.GamePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SceneManger
            // 
            this.SceneManger.Controls.Add(this.LoginPage);
            this.SceneManger.Controls.Add(this.GamePage);
            this.SceneManger.Controls.Add(this.ProfilePage);
            this.SceneManger.Location = new System.Drawing.Point(12, 12);
            this.SceneManger.Name = "SceneManger";
            this.SceneManger.SelectedIndex = 0;
            this.SceneManger.Size = new System.Drawing.Size(768, 427);
            this.SceneManger.TabIndex = 6;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.btnLogin);
            this.LoginPage.Controls.Add(this.txtPassword);
            this.LoginPage.Controls.Add(this.txtUsername);
            this.LoginPage.Location = new System.Drawing.Point(4, 24);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(760, 399);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "Login";
            this.LoginPage.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(285, 215);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(271, 166);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(271, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GamePage
            // 
            this.GamePage.Controls.Add(this.label2);
            this.GamePage.Controls.Add(this.label1);
            this.GamePage.Controls.Add(this.gbDealerCards);
            this.GamePage.Controls.Add(this.button2);
            this.GamePage.Controls.Add(this.button1);
            this.GamePage.Controls.Add(this.gbPlayerCards);
            this.GamePage.Location = new System.Drawing.Point(4, 24);
            this.GamePage.Name = "GamePage";
            this.GamePage.Padding = new System.Windows.Forms.Padding(3);
            this.GamePage.Size = new System.Drawing.Size(760, 399);
            this.GamePage.TabIndex = 1;
            this.GamePage.Text = "Game";
            this.GamePage.UseVisualStyleBackColor = true;
            this.GamePage.Click += new System.EventHandler(this.GamePage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // gbDealerCards
            // 
            this.gbDealerCards.BackColor = System.Drawing.Color.LightGray;
            this.gbDealerCards.Location = new System.Drawing.Point(218, 63);
            this.gbDealerCards.Name = "gbDealerCards";
            this.gbDealerCards.Size = new System.Drawing.Size(296, 128);
            this.gbDealerCards.TabIndex = 8;
            this.gbDealerCards.TabStop = false;
            this.gbDealerCards.Text = "Dealers Cards:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "Stand";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 215);
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
            this.gbPlayerCards.Location = new System.Drawing.Point(218, 215);
            this.gbPlayerCards.Name = "gbPlayerCards";
            this.gbPlayerCards.Size = new System.Drawing.Size(296, 128);
            this.gbPlayerCards.TabIndex = 6;
            this.gbPlayerCards.TabStop = false;
            this.gbPlayerCards.Text = "Your Cards:";
            this.gbPlayerCards.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ProfilePage
            // 
            this.ProfilePage.Location = new System.Drawing.Point(4, 24);
            this.ProfilePage.Name = "ProfilePage";
            this.ProfilePage.Padding = new System.Windows.Forms.Padding(3);
            this.ProfilePage.Size = new System.Drawing.Size(760, 399);
            this.ProfilePage.TabIndex = 2;
            this.ProfilePage.Text = "Profile";
            this.ProfilePage.UseVisualStyleBackColor = true;
            this.ProfilePage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(792, 451);
            this.Controls.Add(this.SceneManger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SceneManger.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.GamePage.ResumeLayout(false);
            this.GamePage.PerformLayout();
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
    }
}