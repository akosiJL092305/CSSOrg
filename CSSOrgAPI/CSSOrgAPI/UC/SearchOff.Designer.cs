namespace CSSOrgAPI.UC
{
    partial class SearchOff
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
            button2 = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button3 = new Button();
            label1 = new Label();
            txtFullName = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtPosition = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(365, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 615);
            panel1.TabIndex = 7;
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
            // txtSearch
            // 
            txtSearch.Location = new Point(3, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(508, 27);
            txtSearch.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(695, 496);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtFullName);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtPosition);
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 674);
            panel2.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(40, 573);
            button3.Name = "button3";
            button3.Size = new Size(277, 55);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(29, 120);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 12;
            label1.Text = "Full Name:";
            label1.Click += label1_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(132, 113);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(185, 27);
            txtFullName.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(40, 512);
            button1.Name = "button1";
            button1.Size = new Size(277, 55);
            button1.TabIndex = 10;
            button1.Text = "Update";
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
            label4.Location = new Point(29, 324);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 220);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Position:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(132, 423);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(185, 27);
            txtContact.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(185, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(132, 213);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(185, 27);
            txtPosition.TabIndex = 0;
            // 
            // SearchOff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "SearchOff";
            Size = new Size(1069, 677);
            Load += SearchOff_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private TextBox txtSearch;
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
        private TextBox txtPosition;
        private Button button3;
    }
}
