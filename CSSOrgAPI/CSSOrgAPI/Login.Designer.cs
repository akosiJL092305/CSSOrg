namespace CSSOrgAPI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUserName = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.BackgroundImage = Properties.Resources._625896700_122277856964037429_577771108949290796_n;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 677);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSlateGray;
            panel1.Location = new Point(676, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 677);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSlateGray;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(txtPass);
            panel3.Controls.Add(txtUserName);
            panel3.Location = new Point(827, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 523);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.dark_blue_login_icon_260nw_2450161919;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(127, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(134, 125);
            panel4.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Location = new Point(93, 427);
            button2.Name = "button2";
            button2.Size = new Size(208, 29);
            button2.TabIndex = 3;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonShadow;
            btnLogin.Location = new Point(93, 376);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(208, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.InactiveCaption;
            txtPass.Location = new Point(93, 256);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(208, 27);
            txtPass.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.InactiveCaption;
            txtUserName.Location = new Point(93, 194);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(208, 27);
            txtUserName.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1356, 675);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Login";
            Text = "Login";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button button2;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUserName;
        private Panel panel4;
    }
}