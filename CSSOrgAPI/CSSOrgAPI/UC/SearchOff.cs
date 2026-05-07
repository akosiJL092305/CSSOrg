using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSSOrgAPI.UC
{
    public partial class SearchOff : UserControl
    {
        public SearchOff()
        {
            InitializeComponent();
        }
        private async Task LoadOfficers()
        {
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetStringAsync("http://localhost:5151/api/officer");
                var data = JsonConvert.DeserializeObject<List<dynamic>>(res);

                dataGridView1.DataSource = data;
            }
        }

        private int selectedOfficerId = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedOfficerId = Convert.ToInt32(row.Cells["id"].Value);

                txtFullName.Text = row.Cells["name"].Value?.ToString();
                txtPosition.Text = row.Cells["position"].Value?.ToString();
                txtEmail.Text = row.Cells["email"].Value?.ToString();
                txtContact.Text = row.Cells["contact"].Value?.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchOff_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim();

            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetStringAsync(
                    $"http://localhost:5151/api/officer/search?key={key}"
                );

                var data = JsonConvert.DeserializeObject<List<dynamic>>(res);
                dataGridView1.DataSource = data;

                // 🔥 AUTO-FILL FIRST RESULT
                if (data.Count > 0)
                {
                    txtFullName.Text = data[0].name;
                    txtPosition.Text = data[0].position;
                    txtEmail.Text = data[0].email;
                    txtContact.Text = data[0].contact;

                    selectedOfficerId = data[0].id;
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (selectedOfficerId == 0)
            {
                MessageBox.Show("Select a record first");
                return;
            }

            var officer = new
            {
                Name = txtFullName.Text,
                Position = txtPosition.Text,
                Email = txtEmail.Text,
                Contact = txtContact.Text
            };

            var json = JsonConvert.SerializeObject(officer);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var res = await client.PutAsync(
                    $"http://localhost:5151/api/officer/update/{selectedOfficerId}",
                    content
                );

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Updated successfully");
                    await LoadOfficers();
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (selectedOfficerId == 0)
            {
                MessageBox.Show("Select a record first");
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes) return;

            using (HttpClient client = new HttpClient())
            {
                var res = await client.DeleteAsync(
                    $"http://localhost:5151/api/officer/delete/{selectedOfficerId}"
                );

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Deleted successfully");

                    // CLEAR FORM
                    txtFullName.Clear();
                    txtPosition.Clear();
                    txtEmail.Clear();
                    txtContact.Clear();

                    selectedOfficerId = 0;

                    await LoadOfficers();
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }
            }
        }
    }
}
