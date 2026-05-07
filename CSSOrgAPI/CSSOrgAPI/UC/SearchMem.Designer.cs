namespace CSSOrgAPI.UC
{
    partial class SearchMem
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
            panel2 = new Panel();
            button3 = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblID = new Label();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            txtYearSection = new TextBox();
            label1 = new Label();
            txtFullName = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblID);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtYearSection);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtFullName);
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 674);
            panel2.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(40, 560);
            button3.Name = "button3";
            button3.Size = new Size(277, 55);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(40, 499);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 340);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 8;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 262);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 7;
            label4.Text = "Year & Section:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 182);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "Full Name";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(144, 113);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 5;
            lblID.Text = "ID";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(144, 423);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(173, 27);
            txtContact.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(144, 337);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(173, 27);
            txtAddress.TabIndex = 3;
            // 
            // txtYearSection
            // 
            txtYearSection.Location = new Point(144, 255);
            txtYearSection.Name = "txtYearSection";
            txtYearSection.Size = new Size(173, 27);
            txtYearSection.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 113);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Member ID:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(144, 179);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(173, 27);
            txtFullName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(365, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 623);
            panel1.TabIndex = 9;
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
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SearchMem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SearchMem";
            Size = new Size(1069, 677);
            Load += SearchMem_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button3;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblID;
        private TextBox txtContact;
        private TextBox txtAddress;
        private TextBox txtYearSection;
        private Label label1;
        private TextBox txtFullName;
        private Panel panel1;
        private Button button2;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
    }
}
