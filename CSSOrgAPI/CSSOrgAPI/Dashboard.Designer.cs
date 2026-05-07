namespace CSSOrgAPI
{
    partial class Dashboard
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
            panel1 = new Panel();
            button6 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            panelMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 677);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.AppWorkspace;
            button6.Location = new Point(41, 389);
            button6.Name = "button6";
            button6.Size = new Size(203, 43);
            button6.TabIndex = 5;
            button6.Text = "Search Member";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources._625896700_122277856964037429_577771108949290796_n;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 202);
            panel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(41, 310);
            button2.Name = "button2";
            button2.Size = new Size(203, 43);
            button2.TabIndex = 1;
            button2.Text = "Add Member";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.Location = new Point(41, 607);
            button5.Name = "button5";
            button5.Size = new Size(203, 43);
            button5.TabIndex = 4;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.Location = new Point(41, 534);
            button4.Name = "button4";
            button4.Size = new Size(203, 43);
            button4.TabIndex = 3;
            button4.Text = "Officers";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Location = new Point(41, 462);
            button3.Name = "button3";
            button3.Size = new Size(203, 43);
            button3.TabIndex = 2;
            button3.Text = "Search Officer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(41, 232);
            button1.Name = "button1";
            button1.Size = new Size(203, 43);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.ControlDarkDark;
            panelMain.Location = new Point(284, -1);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1072, 677);
            panelMain.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 675);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMain;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Panel panel2;
        private Button button6;
    }
}