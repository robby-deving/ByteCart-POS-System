using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;

namespace POS_System
{
    public partial class formProducts : Form
    {
        private const string connectionString = "Server=localhost;Database=pos;Uid=root;Pwd=robert;";

        public formProducts()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            this.Load += formProducts_Load;
        }

        private void formProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM products";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    // Add Edit and Delete buttons if not yet added
                    if (!dataGridView1.Columns.Contains("Edit"))
                    {
                        DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn
                        {
                            HeaderText = "Edit",
                            Text = "Edit",
                            UseColumnTextForButtonValue = true,
                            Name = "Edit"
                        };
                        dataGridView1.Columns.Add(editBtn);
                    }

                    if (!dataGridView1.Columns.Contains("Delete"))
                    {
                        DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn
                        {
                            HeaderText = "Delete",
                            Text = "Delete",
                            UseColumnTextForButtonValue = true,
                            Name = "Delete"
                        };
                        dataGridView1.Columns.Add(deleteBtn);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            decimal price = decimal.Parse(priceTxt.Text);
            int quantity = int.Parse(quantityTxt.Text);

            if (saveBtn.Text == "Update" && saveBtn.Tag != null)
            {
                int id = (int)saveBtn.Tag;
                UpdateProduct(id, name, price, quantity);
                saveBtn.Text = "Save";
                saveBtn.Tag = null;
            }
            else
            {
                SaveProduct(name, price, quantity);
            }

            LoadProducts();
        }

        private void SaveProduct(string name, decimal price, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO products (name, price, stock_quantity) VALUES (@name, @price, @quantity)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product saved successfully!");
                    nameTxt.Text = "";
                    priceTxt.Text = "";
                    quantityTxt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateProduct(int id, string name, decimal price, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE products SET name=@name, price=@price, stock_quantity=@quantity WHERE product_id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product updated successfully!");
                    nameTxt.Text = "";
                    priceTxt.Text = "";
                    quantityTxt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update error: " + ex.Message);
                }
            }
        }

        private void DeleteProduct(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM products WHERE product_id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete error: " + ex.Message);
                }
            }

            LoadProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["product_id"].Value);

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    nameTxt.Text = row.Cells["name"].Value.ToString();
                    priceTxt.Text = row.Cells["price"].Value.ToString();
                    quantityTxt.Text = row.Cells["stock_quantity"].Value.ToString();

                    saveBtn.Text = "Update";
                    saveBtn.Tag = productId;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        DeleteProduct(productId);
                    }
                }
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.");
                    return;
                }

                string templatePath = Path.Combine(Application.StartupPath, "product_list_template.xlsx");
                if (!File.Exists(templatePath))
                {
                    MessageBox.Show("Template file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "Product List.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (var wb = new XLWorkbook(templatePath))
                        {
                            var ws = wb.Worksheet(1); 
                            int startRow = 4; 

                            for (int col = 0; col < dt.Columns.Count; col++)
                            {
                                ws.Cell(startRow - 1, col + 1).Value = dt.Columns[col].ColumnName;
                            }

                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    ws.Cell(i + startRow, j + 1).Value = dt.Rows[i][j]?.ToString() ?? "";
                                }
                            }

                            wb.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message);
            }
        }

    }
}
