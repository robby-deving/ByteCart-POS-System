using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_System
{
    public partial class formDiscounts : Form
    {
        private const string connectionString = "Server=localhost;Database=pos;Uid=root;Pwd=robert;";

        public formDiscounts()
        {
            InitializeComponent();
            LoadDiscounts();
            dataGridView1.CellClick += dataGridView1_CellClick; 


        }

        private void formDiscounts_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string discountName = nameTxt.Text;
            string discountType = discountTypeTxt.Text;
            decimal discountValue = decimal.Parse(discountValueTxt.Text);
            decimal minPurchaseAmount = decimal.Parse(mniAmountTxt.Text);
            DateTime startDate = sdate.Value;
            DateTime endDate = edate.Value;

            if (saveBtn.Text == "Update" && saveBtn.Tag != null)
            {
                if (int.TryParse(saveBtn.Tag.ToString(), out int id))
                {
                    UpdateDiscount(id, discountName, discountType, discountValue, minPurchaseAmount, startDate, endDate);
                    saveBtn.Text = "Save";
                    saveBtn.Tag = null;
                }
                else
                {
                    MessageBox.Show("Invalid discount ID");
                }
            }
            else
            {
                SaveDiscount(discountName, discountType, discountValue, minPurchaseAmount, startDate, endDate);
            }

            LoadDiscounts();
        }



        private void SaveDiscount(string name, string type, decimal value, decimal minPurchase, DateTime startDate, DateTime endDate)
        {
            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO discounts 
                (discount_name, discount_type, discount_value, min_purchase_amount, start_date, end_date) 
                VALUES (@name, @type, @value, @minPurchase, @startDate, @endDate)";

                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@minPurchase", minPurchase);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    cmd.ExecuteNonQuery();
                    DialogResult result = MessageBox.Show("Discount saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        LoadDiscounts();
                    }

                    nameTxt.Text = "";
                    discountTypeTxt.Text = "";
                    discountValueTxt.Text = "";
                    mniAmountTxt.Text = "";
                    sdate.Value = DateTime.Today;
                    edate.Value = DateTime.Today;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void crownDropDownList1_Click(object sender, EventArgs e)
        {

        }
        private void LoadDiscounts()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT discount_id, discount_name, discount_type, discount_value, min_purchase_amount, start_date, end_date FROM discounts";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                if (!dataGridView1.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                    editButton.Name = "Edit";
                    editButton.HeaderText = "";
                    editButton.Text = "Edit";
                    editButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(editButton);
                }

                if (!dataGridView1.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                    deleteButton.Name = "Delete";
                    deleteButton.HeaderText = "";
                    deleteButton.Text = "Delete";
                    deleteButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(deleteButton);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                string discountId = selectedRow.Cells["discount_id"].Value.ToString();

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    EditDiscount(selectedRow);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this discount?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        DeleteDiscount(discountId);
                        LoadDiscounts();
                    }
                }
            }
        }
        private void EditDiscount(DataGridViewRow row)
        {
            string id = row.Cells["discount_id"].Value.ToString();
            string name = row.Cells["discount_name"].Value.ToString();
            string type = row.Cells["discount_type"].Value.ToString();
            string value = row.Cells["discount_value"].Value.ToString();
            string min = row.Cells["min_purchase_amount"].Value.ToString();
            string start = row.Cells["start_date"].Value.ToString();
            string end = row.Cells["end_date"].Value.ToString();

            nameTxt.Text = name;
            discountTypeTxt.Text = type;
            discountValueTxt.Text = value;
            mniAmountTxt.Text = min;
            sdate.Value = DateTime.Parse(start);
            edate.Value = DateTime.Parse(end);

            saveBtn.Text = "Update";
            saveBtn.Tag = id;
        }


        private void UpdateDiscount(int id, string name, string type, decimal value, decimal minPurchase, DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"UPDATE discounts 
                         SET discount_name=@name, discount_type=@type, discount_value=@value,
                             min_purchase_amount=@min, start_date=@start, end_date=@end 
                         WHERE discount_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@value", value);
                cmd.Parameters.AddWithValue("@min", minPurchase);
                cmd.Parameters.AddWithValue("@start", startDate.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@end", endDate.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                nameTxt.Text = "";
                discountTypeTxt.Text = "";
                discountValueTxt.Text = "";
                mniAmountTxt.Text = "";
                sdate.Value = DateTime.Today;
                edate.Value = DateTime.Today;
            }

            LoadDiscounts();
        }



        private void DeleteDiscount(string discountId)
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=pos;Uid=root;Pwd=robert;"))
            {
                conn.Open();
                string query = "DELETE FROM discounts WHERE discount_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", discountId);
                cmd.ExecuteNonQuery();
            }
        }




    }
}
