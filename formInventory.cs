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
using Mysqlx.Crud;
using static System.Net.Mime.MediaTypeNames;

namespace POS_System
{
    public partial class formInventory : Form
    {
        public formInventory()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.formInventory_Load);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LoadInventoryData()
        {
            try
            {
                string connectionString = "Server=localhost;Database=pos;Uid=root;Pwd=robert;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM inventory", conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
        }

        private void formInventory_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Database=pos;Uid=root;Pwd=robert;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("InsertInventoryWithLog", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        int productId = int.Parse(productTxt.Text);
                        int quantity = int.Parse(quantityTxt.Text);
                        int employeeId = GlobalVariables.UserId;
                        string action = "Insert";
                        string description = "New stock added to inventory";
                        string tableAffected = "inventory";

                        cmd.Parameters.AddWithValue("p_product_id", productId);
                        cmd.Parameters.AddWithValue("p_quantity", quantity);
                        cmd.Parameters.AddWithValue("p_employee_id", employeeId);
                        cmd.Parameters.AddWithValue("p_action", action);
                        cmd.Parameters.AddWithValue("p_description", description);
                        cmd.Parameters.AddWithValue("p_table_affected", tableAffected);

                        cmd.ExecuteNonQuery();
                    }

                    using (MySqlCommand loadCmd = new MySqlCommand("SELECT * FROM inventory", conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(loadCmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
