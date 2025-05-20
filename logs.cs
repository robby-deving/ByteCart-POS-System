using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace POS_System
{
    public partial class logs : Form
    {
        private string connectionString = "server=localhost;database=pos;uid=root;pwd=robert;";

        public logs()
        {
            InitializeComponent();
            LoadLogs();
        }

        private void LoadLogs()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT `id`, `employee_id`, `action`, `description`, `table_affected`, `created_at`, `updated_at` FROM `logs`";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridViewLogs.DataSource = dt;

                            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridViewLogs.ReadOnly = true;
                            dataGridViewLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs: " + ex.Message);
            }
        }

        private void dataGridViewLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
