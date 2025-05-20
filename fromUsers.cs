using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_System
{
    public partial class fromUsers : Form
    {
        private const string connectionString = "Server=localhost;Database=pos;Uid=root;Pwd=robert;";
        private int? selectedCustomerId = null;

        public fromUsers()
        {
            InitializeComponent();
            LoadCustomers();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void fromUsers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string email = emailTxt.Text;
            string phone = phoneTxt.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (selectedCustomerId == null)
            {
                if (CreateCustomer(name, email, phone))
                {
                    MessageBox.Show("Customer added successfully!");
                    ClearForm();
                    LoadCustomers();
                }
            }
            else
            {
                if (UpdateCustomer((int)selectedCustomerId, name, email, phone))
                {
                    MessageBox.Show("Customer updated successfully!");
                    ClearForm();
                    LoadCustomers();
                }
            }
        }

        private bool CreateCustomer(string name, string email, string phone)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO customers (name, email, phone) VALUES (@name, @email, @phone)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private bool UpdateCustomer(int id, string name, string email, string phone)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE customers SET name = @name, email = @email, phone = @phone WHERE customer_id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private bool DeleteCustomer(int id)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM customers WHERE customer_id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void LoadCustomers()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT customer_id, name, email, phone, created_at FROM customers";
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
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["customer_id"].Value);

                if (columnName == "Edit")
                {
                    selectedCustomerId = id;
                    nameTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    emailTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                    phoneTxt.Text = dataGridView1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                    button1.Text = "Update";
                }
                else if (columnName == "Delete")
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        if (DeleteCustomer(id))
                        {
                            MessageBox.Show("Customer deleted successfully.");
                            LoadCustomers();
                        }
                    }
                }
            }
        }

        private void ClearForm()
        {
            selectedCustomerId = null;
            nameTxt.Clear();
            emailTxt.Clear();
            phoneTxt.Clear();
            button1.Text = "Save";
        }
    }
}
