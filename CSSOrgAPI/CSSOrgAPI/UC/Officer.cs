using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;


namespace CSSOrgAPI.UC
{
    public partial class Officer : UserControl
    {
        public Officer()
        {
            InitializeComponent();
        }
        string selectedImagePath = "";
        private async Task LoadOfficers()
        {
            using (HttpClient client = new HttpClient())
            {
                var res = await client.GetStringAsync("http://localhost:5151/api/officer/all");

                var data = JsonConvert.DeserializeObject<DataTable>(res);

                dataGridView1.DataSource = data;
            }
        }
        private void ClearForm()
        {
            txtFullName.Clear();
            cmbPosition.SelectedIndex = -1;
            txtEmail.Clear();
            txtContact.Clear();
            pictureBox1.Image = null;

            selectedImagePath = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dialog.FileName;

                pictureBox1.Image = Image.FromFile(selectedImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    MultipartFormDataContent form = new MultipartFormDataContent();

                    form.Add(new StringContent(txtFullName.Text), "Name");
                    form.Add(new StringContent(cmbPosition.Text), "Position");
                    form.Add(new StringContent(txtEmail.Text), "Email");
                    form.Add(new StringContent(txtContact.Text), "Contact");


                    if (!string.IsNullOrEmpty(selectedImagePath))
                    {
                        var fileStream = File.OpenRead(selectedImagePath);
                        var fileContent = new StreamContent(fileStream);
                        fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

                        form.Add(fileContent, "Image", Path.GetFileName(selectedImagePath));
                    }

                    var response = await client.PostAsync("http://localhost:5151/api/officer/add", form);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Officer added successfully");

                        ClearForm();
                        await LoadOfficers();
                    }
                    else
                    {
                        var err = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Error: " + err);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string key = cmbSearch.Text.Trim();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(
      $"http://localhost:5151/api/officer/search?key={key}"
  );

                if (!response.IsSuccessStatusCode)
                {
                    var err = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("API Error: " + err);
                    return;
                }

                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<dynamic>>(json);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                txtFullName.Text = row.Cells["name"].Value.ToString();
                cmbPosition.Text = row.Cells["position"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtContact.Text = row.Cells["contact"].Value.ToString();

                string base64 = row.Cells["image"].Value?.ToString();   

                if (!string.IsNullOrEmpty(base64))
                {
                    byte[] imgBytes = Convert.FromBase64String(base64);

                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }
    }
}
