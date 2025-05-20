using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_System
{
    public partial class formLoyaltyPrograms : Form
    {
        private const string connectionString = "Server=localhost;Database=pos;Uid=root;Pwd=robert";
        private int? selectedProgramId = null; 


        public formLoyaltyPrograms()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            LoadLoyaltyPrograms();

        }

        private void formLoyaltyPrograms_Load(object sender, EventArgs e)
        {
            LoadLoyaltyPrograms();
        }

        private void LoadLoyaltyPrograms()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT program_id, program_name, description FROM loyalty_programs";
                    var adapter = new MySqlDataAdapter(query, conn);
                    var table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = table;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToResizeColumns = false;

                    var editBtn = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                        Width = 60
                    };

                    var deleteBtn = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                        Width = 60
                    };

                    dataGridView1.Columns.Add(editBtn);
                    dataGridView1.Columns.Add(deleteBtn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading programs: " + ex.Message);
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string programName = nameTxt.Text;
            string description = descriptionTxt.Text;

            if (string.IsNullOrWhiteSpace(programName))
            {
                MessageBox.Show("Program Name is required.");
                return;
            }

            if (selectedProgramId.HasValue)
            {
                UpdateLoyaltyProgram(selectedProgramId.Value, programName, description);
            }
            else
            {
                SaveLoyaltyProgram(programName, description);
            }

            LoadLoyaltyPrograms();
        }

        private void SaveLoyaltyProgram(string programName, string description)
        {
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO loyalty_programs (program_name, description) VALUES (@programName, @description)";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@programName", programName);
                    cmd.Parameters.AddWithValue("@description", description);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Loyalty Program saved successfully!");

                    nameTxt.Text = "";
                    descriptionTxt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var column = dataGridView1.Columns[e.ColumnIndex].Name;
            var row = dataGridView1.Rows[e.RowIndex];
            int programId = Convert.ToInt32(row.Cells["program_id"].Value);

            if (column == "Edit")
            {
                nameTxt.Text = row.Cells["program_name"].Value.ToString();
                descriptionTxt.Text = row.Cells["description"].Value.ToString();
                selectedProgramId = programId;
                saveBtn.Text = "Update";
            }
            else if (column == "Delete")
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this program?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    DeleteLoyaltyProgram(programId);
                    LoadLoyaltyPrograms();
                }
            }
        }

        private void UpdateLoyaltyProgram(int programId, string programName, string description)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE loyalty_programs SET program_name = @programName, description = @description WHERE program_id = @programId";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@programName", programName);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@programId", programId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Loyalty Program updated successfully!");
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating program: " + ex.Message);
                }
            }
        }

        private void DeleteLoyaltyProgram(int programId)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM loyalty_programs WHERE program_id = @programId";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@programId", programId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Loyalty Program deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting program: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            nameTxt.Text = "";
            descriptionTxt.Text = "";
            selectedProgramId = null;
            saveBtn.Text = "Save";
        }



    }
}
