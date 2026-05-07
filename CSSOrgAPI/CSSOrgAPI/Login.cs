using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;


namespace CSSOrgAPI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
       "Are you sure you want to logout?",
       "Confirm Logout",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private static readonly HttpClient client = new HttpClient();
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUserName.Text.Trim();
                string password = txtPass.Text.Trim();

                
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter username and password");
                    return;
                }

                var user = new
                {
                    Username = username,
                    Password = password
                };

                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://localhost:5151/api/auth/login", content);

                if (response.IsSuccessStatusCode)
                {
              
                    MessageBox.Show("Login successful!");

                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();

                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }
        }
    }
}
