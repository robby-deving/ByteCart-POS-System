using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POS_System
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
            LoadTransactions();
            dgvTransactions.CellClick += dgvTransactions_CellClick;

        }

        private void LoadTransactions(string search = "")
        {
            string query = "SELECT * FROM order_transaction_summary_with_employee";
            if (!string.IsNullOrEmpty(search))
                query += " WHERE order_id LIKE @search";

            using (var conn = new MySqlConnection("server=localhost;user=root;database=pos;password=robert"))
            using (var cmd = new MySqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(search))
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dgvTransactions.DataSource = table;
            }
        }


        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var orderId = dgvTransactions.Rows[e.RowIndex].Cells["order_id"].Value.ToString();
                LoadOrderDetails(orderId);
            }
        }

        private void LoadOrderDetails(string orderId)
        {
            string query = "SELECT * FROM order_details_with_product_name WHERE order_id = @order_id";

            using (var conn = new MySqlConnection("server=localhost;user=root;database=pos;password=robert"))
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@order_id", orderId);
                var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                dgvOrderDetails.DataSource = table;
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTransactions(txtSearch.Text.Trim());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Checked ? dtpStart.Value.Date : DateTime.Today.AddMonths(-1);
            DateTime endDate = dtpEnd.Checked ? dtpEnd.Value.Date.AddDays(1).AddSeconds(-1) : DateTime.Today.AddDays(1).AddSeconds(-1);

            string templatePath = Path.Combine(Application.StartupPath, "transaction_template.xlsx");

            if (!File.Exists(templatePath))
            {
                MessageBox.Show("Template file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable exportTable = new DataTable();
            string query = @"
        SELECT 
            order_id,
            employee_name,
            total_amount,
            discount_amount,
            final_amount,
            order_created_at,
            amount_paid,
            change_amount,
            transaction_created_at
        FROM order_transaction_summary_with_employee
        WHERE transaction_created_at BETWEEN @start AND @end
    ";

            using (var conn = new MySqlConnection("server=localhost;user=root;database=pos;password=robert"))
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@start", startDate);
                cmd.Parameters.AddWithValue("@end", endDate);

                var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(exportTable);
            }

            if (exportTable.Rows.Count == 0)
            {
                MessageBox.Show("No transactions in the selected date range.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var wb = new ClosedXML.Excel.XLWorkbook(templatePath))
            {
                var ws = wb.Worksheet(1);
                int startRow = 4;

                for (int i = 0; i < exportTable.Columns.Count; i++)
                {
                    ws.Cell(startRow - 1, i + 1).Value = exportTable.Columns[i].ColumnName;
                }

                for (int i = 0; i < exportTable.Rows.Count; i++)
                {
                    for (int j = 0; j < exportTable.Columns.Count; j++)
                    {
                        ws.Cell(i + startRow, j + 1).Value = exportTable.Rows[i][j]?.ToString() ?? "";
                    }
                }

                string fileName = $"Transaction Report - {startDate:yyyy-MM-dd} to {endDate:yyyy-MM-dd}.xlsx";

                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = fileName,
                    Title = "Save Transactions Report"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Report exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
