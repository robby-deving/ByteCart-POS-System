using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace POS_System
{
    public partial class formEmployees : Form
    {
        private const string ApiKey = "AIzaSyCfl2uvWOANopm-jsqBua35trK4fZdwU1I";
        private const string connectionString = "Server=localhost;Database=pos;Uid=root;Pwd=robert;";
        private int? selectedEmployeeId = null;
        int employeeId = GlobalVariables.UserId;


        public formEmployees()
        {
            InitializeComponent();
            LoadEmployees();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;


        }

        private void formEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string phoneNumber = phoneNumberTxt.Text;
            string email = emailTxt.Text.ToLower();
            string role = roleTxt.Text.ToLower();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (selectedEmployeeId == null)
            {
                string password = "EmployeePassword"; 
                var firebaseResponse = await RegisterWithFirebase(email, password);

                if (firebaseResponse != null)
                {
                    if (CreateAccount(name, phoneNumber, email, role))
                    {
                        MessageBox.Show("Account created successfully!");
                        LogAction(employeeId, "insert", $"Inserted account: {name}", "employees");

                        ClearForm();
                        LoadEmployees();
                    }
                }
            }
            else
            {
                if (UpdateEmployee((int)selectedEmployeeId, name, phoneNumber, email, role))
                {
                    MessageBox.Show("Employee updated successfully!");
                    LogAction(employeeId, "update", $"Updated employee: {name}", "employees"); 
                    ClearForm();
                    LoadEmployees();
                }
            }
        }

        private async Task<string> RegisterWithFirebase(string email, string password)
        {
            var payload = new
            {
                email,
                password,
                returnSecureToken = true
            };

            try
            {
                using (var client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(
                        $"https://identitytoolkit.googleapis.com/v1/accounts:signUp?key={ApiKey}",
                        content);

                    var responseBody = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        dynamic result = JsonConvert.DeserializeObject(responseBody);
                        return result.localId; 
                    }
                    else
                    {
                        dynamic error = JsonConvert.DeserializeObject(responseBody);
                        MessageBox.Show($"Error: {error.error.message}");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }

        private bool CreateAccount(string name, string phoneNumber, string email, string role)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO employees (name, phone, email, role) VALUES (@name, @phone, @email, @role)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phoneNumber);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@role", role);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }

        private bool UpdateEmployee(int id, string name, string phoneNumber, string email, string role)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE employees SET name = @name, phone = @phone, email = @email, role = @role WHERE employee_id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@phone", phoneNumber);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }

        }

        private bool DeleteEmployee(int id)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM employees WHERE employee_id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }

        private void LoadEmployees()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT employee_id, name, phone, email, role FROM employees";
                    var adapter = new MySqlDataAdapter(query, conn);
                    var table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = table;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    var editBtn = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true,
                        Width = 60
                    };
                    var deleteBtn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true,
                        Width = 60
                    };

                    dataGridView1.Columns.Add(editBtn);
                    dataGridView1.Columns.Add(deleteBtn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["employee_id"].Value);

                if (columnName == "Edit")
                {
                    selectedEmployeeId = id;
                    nameTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    phoneNumberTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                    emailTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                    roleTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["role"].Value.ToString();
                    button1.Text = "Update";
                }
                else if (columnName == "Delete")
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        if (DeleteEmployee(id))
                        {
                            string deletedName = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                            MessageBox.Show("Employee deleted successfully.");
                            LogAction(employeeId, "delete", $"Deleted employee: {deletedName}", "employees"); 
                            LoadEmployees();
                        }
                    }
                }
            }
        }

        private void ClearForm()
        {
            selectedEmployeeId = null;
            nameTxt.Clear();
            phoneNumberTxt.Clear();
            emailTxt.Clear();
            roleTxt.Clear();
            button1.Text = "Save";
        }

        private void LogAction(int employeeId, string action, string description, string tableAffected)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("InsertLog", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_employee_id", employeeId);
                    cmd.Parameters.AddWithValue("@p_action", action);
                    cmd.Parameters.AddWithValue("@p_description", description);
                    cmd.Parameters.AddWithValue("@p_table_affected", tableAffected);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Logging failed: " + ex.Message);
                }
            }
        }

    }
}
