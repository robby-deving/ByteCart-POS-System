using System;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace POS_System
{
    public partial class login : Form
    {
        private const string ApiKey = "AIzaSyCfl2uvWOANopm-jsqBua35trK4fZdwU1I";
        private const string ConnectionString = "Server=localhost;Database=pos;Uid=root;Pwd=robert";

        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void login_Load(object sender, EventArgs e) { }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            var email = emailTxt.Text;
            var password = passwordTxt.Text;

            var result = await SignIn(email, password);

            if (result.StartsWith("Success"))
            {
                int employeeId = await GetEmployeeIdByEmail(email);

                if (employeeId > 0)
                {
                    GlobalVariables.UserId = employeeId;

                    this.Hide();
                    Form1 mainForm = new Form1();
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                }
                else
                {
                    lblStatus.Text = "User not found in the database.";
                }
            }
            else
            {
                lblStatus.Text = result;
            }
        }

        private async Task<string> SignIn(string email, string password)
        {
            var payload = new
            {
                email,
                password,
                returnSecureToken = true
            };

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(
                    $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={ApiKey}",
                    content);

                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    dynamic result = JsonConvert.DeserializeObject(responseBody);
                    return $"Success! UID: {result.localId}";
                }
                else
                {
                    dynamic error = JsonConvert.DeserializeObject(responseBody);
                    return $"Error: {error.error.message}";
                }
            }
        }

        private async Task<int> GetEmployeeIdByEmail(string email)
        {
            int employeeId = 0;

            try
            {
                using (var connection = new MySqlConnection(ConnectionString))
                {
                    await connection.OpenAsync();
                    var query = "SELECT employee_id FROM employees WHERE email = @Email";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        var result = await command.ExecuteScalarAsync();
                        if (result != null)
                        {
                            employeeId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }

            return employeeId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            emailField forgotPasswordForm = new emailField();
            forgotPasswordForm.Show();
        }
    }
}
