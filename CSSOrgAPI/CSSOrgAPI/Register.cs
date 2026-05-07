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
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
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

                var response = await client.PostAsync("http://localhost:5151/api/auth/register", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registration successful!");

                    txtUserName.Clear();
                    txtPass.Clear();

                   
                    Login login = new Login();
                    login.Show();
                    this.Hide(); 

                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }
        }
    }
}
