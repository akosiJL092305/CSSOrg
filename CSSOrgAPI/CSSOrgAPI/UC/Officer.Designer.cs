namespace CSSOrgAPI.UC
{
    partial class Officer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cmbSearch = new ComboBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            cmbPosition = new ComboBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtFullName = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbSearch);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(365, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 672);
            panel1.TabIndex = 5;
            // 
            // cmbSearch
            // 
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Items.AddRange(new object[] { "President", "Vice President", "Secretary", "Auditor", "P.I.O", "Sergeant at Arms 1", "Sergeant at Arms 2", "Sergeant at Arms 3" });
            cmbSearch.Location = new Point(3, 112);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(508, 28);
            cmbSearch.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(517, 107);
            button2.Name = "button2";
            button2.Size = new Size(180, 33);
            button2.TabIndex = 11;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(695, 496);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbPosition);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtFullName);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtEmail);
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 674);
            panel2.TabIndex = 4;
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Items.AddRange(new object[] { "President", "Vice President", "Secretary", "Auditor", "P.I.O", "Sergeant at Arms 1", "Sergeant at Arms 2", "Sergeant at Arms 3" });
            cmbPosition.Location = new Point(144, 278);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(173, 28);
            cmbPosition.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(120, 117);
            button3.Name = "button3";
            button3.Size = new Size(107, 30);
            button3.TabIndex = 13;
            button3.Text = "Browse";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(120, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 99);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(29, 215);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 12;
            label1.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(144, 212);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(173, 27);
            txtFullName.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(40, 512);
            button1.Name = "button1";
            button1.Size = new Size(277, 55);
            button1.TabIndex = 10;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 426);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 9;
            label6.Text = "Contact:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 361);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 286);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Position:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(144, 423);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(173, 27);
            txtContact.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 354);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(173, 27);
            txtEmail.TabIndex = 2;
            // 
            // Officer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Officer";
            Size = new Size(1072, 677);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private TextBox txtFullName;
        private Button button1;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txtContact;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
        private Button button3;
        private ComboBox cmbSearch;
        private ComboBox cmbPosition;
    }
}
