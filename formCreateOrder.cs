using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.Json; 

namespace POS_System
{
    public partial class formCreateOrder : Form
    {
        private const string connectionString = "Server=localhost;Database=pos;Uid=root;Pwd=robert;";
        private List<Product> cart = new List<Product>();
        private decimal total = 0;


        public formCreateOrder()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            string query = "SELECT product_id, name, price FROM products";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                flowProducts.Controls.Clear();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["product_id"]);
                    string name = reader["name"].ToString();
                    decimal price = Convert.ToDecimal(reader["price"]);

                    Button btn = new Button();
                    btn.Text = $"{name}\n₱{price:F2}";
                    btn.Width = 120;
                    btn.Height = 100;
                    btn.Tag = new Product { Id = id, Name = name, Price = price };
                    btn.Click += Product_Click;

                    flowProducts.Controls.Add(btn);
                }
            }
        }

        private void Product_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Product product = (Product)btn.Tag;

            cart.Add(product);
            listCart.Items.Add($"{product.Name} - ₱{product.Price:F2}");

            total += product.Price;
            lblTotal.Text = $"Total: ₱{total:F2}";
            subTotal.Text = total.ToString("C2");              
        }

        private void btnSubmitTransaction_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Please select products first.");
                return;
            }

            if (!decimal.TryParse(txtAmountGiven.Text, out decimal amountGiven))
            {
                MessageBox.Show("Invalid amount given.");
                return;
            }

            if (!decimal.TryParse(txtDiscount.Text, out decimal discount))
            {
                discount = 0;
            }

            int? customerId = null;
            if (!string.IsNullOrWhiteSpace(cusIdTxt.Text))
            {
                if (int.TryParse(cusIdTxt.Text, out int parsedId))
                {
                    customerId = parsedId;
                }
                else
                {
                    MessageBox.Show("Invalid Customer ID.");
                    return;
                }
            }

            decimal finalAmount = total - discount;
            if (amountGiven < finalAmount)
            {
                MessageBox.Show("Amount given is less than the final amount.");
                return;
            }

            string orderItemsJson = GenerateOrderItemsJson(cart);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    MySqlCommand cmd = new MySqlCommand("CreateOrderTransaction", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int employeeId = GlobalVariables.UserId;

                    object customerIdParam = customerId.HasValue ? (object)customerId.Value : DBNull.Value;
                    cmd.Parameters.AddWithValue("@p_customer_id", customerIdParam);


                    cmd.Parameters.AddWithValue("@p_total_amount", total);
                    cmd.Parameters.AddWithValue("@p_discount_id", DBNull.Value); 
                    cmd.Parameters.AddWithValue("@p_discount_amount", discount);
                    cmd.Parameters.AddWithValue("@p_final_amount", finalAmount);
                    cmd.Parameters.AddWithValue("@p_amount_paid", amountGiven);
                    cmd.Parameters.AddWithValue("@p_order_items", orderItemsJson);
                    cmd.Parameters.AddWithValue("@p_employee_id", employeeId);




                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Order and transaction saved successfully!");

                   
                    cart.Clear();
                    listCart.Items.Clear();
                    total = 0;
                    lblTotal.Text = "₱ 0.00";
                    subTotal.Text = "₱ 0.00";
                    txtAmountGiven.Text = "";
                    txtDiscount.Text = "";
                    cusIdTxt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private string GenerateOrderItemsJson(List<Product> products)
        {
            var items = products.Select(p => new
            {
                product_id = p.Id,
                quantity = 1, 
                price = p.Price,
                subtotal = p.Price 
            });

            return JsonSerializer.Serialize(items);
        }


    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
