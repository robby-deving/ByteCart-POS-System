using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace POS_System
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Server=localhost;Database=pos;Uid=root;Pwd=robert;";

        formDashboard dashboard;
        formCreateOrder createOrder;
        formProducts products;
        formInventory inventory;
        formEmployees employees;
        fromUsers users;
        formDiscounts discounts;
        formLoyaltyPrograms loyaltyPrograms;
        logs logs;

        public Form1()
        {
            InitializeComponent();
        }
        private void ShowDashboard()
        {
            if (dashboard == null)
            {
                dashboard = new formDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ShowDashboard();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (createOrder == null)
            {
                createOrder = new formCreateOrder();
                createOrder.FormClosed += CreateOrder_FormClosed;
                createOrder.MdiParent = this;
                createOrder.Dock = DockStyle.Fill;
                createOrder.Show();
            }
            else
            {
                createOrder.Activate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (products == null)
            {
                products = new formProducts();
                products.FormClosed += Products_FormClosed;
                products.MdiParent = this;
                products.Dock = DockStyle.Fill;
                products.Show();
            }
            else
            {
                products.Activate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (inventory == null)
            {
                inventory = new formInventory();
                inventory.FormClosed += Inventory_FormClosed;
                inventory.MdiParent = this;
                inventory.Dock = DockStyle.Fill;
                inventory.Show();
            }
            else
            {
                inventory.Activate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (employees == null)
            {
                employees = new formEmployees();
                employees.FormClosed += Employees_FormClosed;
                employees.MdiParent = this;
                employees.Dock = DockStyle.Fill;
                employees.Show();
            }
            else
            {
                employees.Activate();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (users == null)
            {
                users = new fromUsers();
                users.FormClosed += Users_FormClosed;
                users.MdiParent = this;
                users.Dock = DockStyle.Fill;
                users.Show();
            }
            else
            {
                users.Activate();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (discounts == null)
            {
                discounts = new formDiscounts();
                discounts.FormClosed += Discounts_FormClosed;
                discounts.MdiParent = this;
                discounts.Dock = DockStyle.Fill;
                discounts.Show();
            }
            else
            {
                discounts.Activate();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (loyaltyPrograms == null)
            {
                loyaltyPrograms = new formLoyaltyPrograms();
                loyaltyPrograms.FormClosed += LoyaltyPrograms_FormClosed;
                loyaltyPrograms.MdiParent = this;
                loyaltyPrograms.Dock = DockStyle.Fill;
                loyaltyPrograms.Show();
            }
            else
            {
                loyaltyPrograms.Activate();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void CreateOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            createOrder = null;
        }

        private void Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            products = null;
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            inventory = null;
        }

        private void Employees_FormClosed(object sender, FormClosedEventArgs e)
        {
            employees = null;
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            users = null;
        }

        private void Discounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            discounts = null;
        }

        private void LoyaltyPrograms_FormClosed(object sender, FormClosedEventArgs e)
        {
            loyaltyPrograms = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();

            login loginForm = new login();
            loginForm.FormClosed += (s, args) => this.Close(); 
            loginForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (logs == null)
            {
                logs = new logs();
                logs.FormClosed += Logs_FormClosed;
                logs.MdiParent = this;
                logs.Dock = DockStyle.Fill;
                logs.Show();
            }
            else
            {
                logs.Activate();
            }
        }

        private void Logs_FormClosed(object sender, FormClosedEventArgs e)
        {
            logs = null;
        }

    }
}
