using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace POS_System
{
    public partial class emailField : Form
    {
        private const string ApiKey = "AIzaSyCfl2uvWOANopm-jsqBua35trK4fZdwU1I";

        public emailField()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var email = emailTxt.Text; 

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            var payload = new
            {
                requestType = "PASSWORD_RESET",
                email = email
            };

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(
                    $"https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key={ApiKey}",
                    content);

                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    DialogResult result = MessageBox.Show("Password reset email sent!", "Success", MessageBoxButtons.OK);

                    if (result == DialogResult.OK)
                    {
                        login loginForm = new login();
                        loginForm.Show();
                        this.Hide(); 
                    }

                }
                else
                {
                    dynamic error = JsonConvert.DeserializeObject(responseBody);
                    MessageBox.Show($"Error: {error.error.message}");
                }
            }
        }
    }
}
