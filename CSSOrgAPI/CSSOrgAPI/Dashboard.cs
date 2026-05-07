using CSSOrgAPI.UC;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSSOrgAPI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panelMain.Controls.Clear();

            AddMember add = new AddMember();
            add.Dock = DockStyle.Fill;

            panelMain.Controls.Add(add);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            Officer off = new Officer();
            off.Dock = DockStyle.Fill;

            panelMain.Controls.Add(off);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            SearchMem search = new SearchMem();
            search.Dock = DockStyle.Fill;

            panelMain.Controls.Add(search);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            SearchOff search = new SearchOff();
            search.Dock = DockStyle.Fill;

            panelMain.Controls.Add(search);
        }
    }
}
