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
    public partial class SearchMem : UserControl
    {
        public SearchMem()
        {
            InitializeComponent();
        }
        private async Task LoadMembers()
        {
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetStringAsync("http://localhost:5151/api/member/all");
                var data = JsonConvert.DeserializeObject<DataTable>(res);

                dataGridView1.DataSource = data;
            }
        }
        private void SearchMem_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                lblID.Text = row.Cells["id"].Value.ToString();
                txtFullName.Text = row.Cells["name"].Value.ToString();
                txtYearSection.Text = row.Cells["yearSection"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtContact.Text = row.Cells["contact"].Value.ToString();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim();

            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetStringAsync($"http://localhost:5151/api/member/search?key={key}");
                var data = JsonConvert.DeserializeObject<DataTable>(res);

                dataGridView1.DataSource = data;

                // 🔥 AUTO FILL FIRST RESULT
                if (data.Rows.Count > 0)
                {
                    var row = data.Rows[0];

                    lblID.Text = row["id"].ToString();
                    txtFullName.Text = row["name"].ToString();
                    txtYearSection.Text = row["yearSection"].ToString();
                    txtAddress.Text = row["address"].ToString();
                    txtContact.Text = row["contact"].ToString();
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblID.Text)) return;

            var member = new
            {
                Name = txtFullName.Text,
                YearSection = txtYearSection.Text,
                Address = txtAddress.Text,
                ContactNumber = txtContact.Text
            };

            var json = JsonConvert.SerializeObject(member);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var res = await client.PutAsync(
                    $"http://localhost:5151/api/member/update/{lblID.Text}",
                    content
                );

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Updated successfully");
                    await LoadMembers();
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblID.Text)) return;

            var confirm = MessageBox.Show("Delete this member?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                using (HttpClient client = new HttpClient())
                {
                    var res = await client.DeleteAsync(
                        $"http://localhost:5151/api/member/delete/{lblID.Text}"
                    );

                    if (res.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Deleted successfully");

                        // CLEAR FORM
                        lblID.Text = "";
                        txtFullName.Clear();
                        txtYearSection.Clear();
                        txtAddress.Clear();
                        txtContact.Clear();

                        await LoadMembers();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed");
                    }
                }
            }
        }
    }
}
