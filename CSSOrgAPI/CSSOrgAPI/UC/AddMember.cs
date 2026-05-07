using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSSOrgAPI.UC
{
    public partial class AddMember : UserControl
    {
        private readonly HttpClient client = new HttpClient();
        private readonly string baseUrl = "http://localhost:5151/api/member/";
        public AddMember()
        {
            InitializeComponent();
        }

        private async Task LoadNextId()
        {
            try
            {
                var res = await client.GetAsync(baseUrl + "next-id");

                if (!res.IsSuccessStatusCode)
                    throw new Exception("Failed to get next ID");

                var json = await res.Content.ReadAsStringAsync();
                dynamic data = JsonConvert.DeserializeObject(json);

                lblID.Text = data.nextId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID Error: " + ex.Message);
            }
        }
        private async Task LoadMembers()
        {
            try
            {
                var res = await client.GetAsync(baseUrl + "all");

                if (!res.IsSuccessStatusCode)
                    throw new Exception("Failed to load members");

                var json = await res.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<dynamic>>(json);

                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtFullName.Text.Trim();
                string year = txtYearSection.Text.Trim();
                string address = txtAddress.Text.Trim();
                string contact = txtContact.Text.Trim();

                // 🔒 VALIDATION
                if (string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(year) ||
                    string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(contact))
                {
                    MessageBox.Show("Please fill all fields");
                    return;
                }

                var member = new
                {
                    Name = name,
                    YearSection = year,
                    Address = address,
                    ContactNumber = contact
                };

                var json = JsonConvert.SerializeObject(member);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var res = await client.PostAsync(baseUrl + "add-member", content);

                if (!res.IsSuccessStatusCode)
                {
                    var err = await res.Content.ReadAsStringAsync();
                    throw new Exception(err);
                }

                MessageBox.Show("Member added successfully!");

                // ✅ CLEAR INPUTS
                txtFullName.Clear();
                txtYearSection.Clear();
                txtAddress.Clear();
                txtContact.Clear();

                // ✅ REFRESH EVERYTHING
                await LoadMembers();
                await LoadNextId();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Submit Error: " + ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(key))
                {
                    await LoadMembers(); // reset
                    return;
                }

                var res = await client.GetAsync(baseUrl + "search?key=" + key);

                if (!res.IsSuccessStatusCode)
                    throw new Exception("Search failed");

                var json = await res.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<dynamic>>(json);

                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }

        private async void AddMember_Load(object sender, EventArgs e)
        {
            await LoadNextId();
            await LoadMembers();
        }
    }
}
