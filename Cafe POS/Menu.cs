using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_POS
{
    public partial class Menu : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");

        public Menu(string Id)
        {
            InitializeComponent();
            OrderIDTB.Text = GenerateId().ToString();
            UserIDTB.Text = Id;
            getAllProduct();
            DiscountCB.SelectedIndex = 0;
            ResetOrderForm();
        }

        public bool emptyFileds()
        {
            if (PaidTB.Text == "" || OrderTypeCB.Text == "" || PayTypeCB.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // order id generate korar jonn
        private string GenerateId()
        {
            connect.Open();
            string newId = "O101";

            string query = "SELECT ORDER_ID FROM ORDERS ORDER BY ORDER_ID DESC";

            SqlCommand cmd = new SqlCommand(query, connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["ORDER_ID"].ToString();
                    int number = int.Parse(lastId.Replace("O", ""));
                    newId = "O" + (number + 1);
                }
            }
            connect.Close();
            return newId;

        }

        // Add Product to FlowLayoutPanel
        private void addProduct(string id, string name, string price, string category, string img, int stock)
        {
            try
            {
                ProductCard p = new ProductCard()
                {
                    ID = id,
                    Name = name,
                    Price = price,
                    Category = category,
                    Photo = img,
                    Stock = stock,
                };

                ItemLayout.Controls.Add(p);

                p.selected += (sender, args) =>
                {
                    ProductCard selectedProduct = (ProductCard)sender;

                    if (selectedProduct.Quantity <= 0)
                    {
                        MessageBox.Show("Select a valid quantity.");
                        return;
                    }
                    // Parameterized query
                    try
                    {

                        if (connect.State == ConnectionState.Closed)
                            connect.Open();

                        string sql = "SELECT * FROM Inventory WHERE NAME = @Name";

                        SqlCommand cmd = new SqlCommand(sql, connect);
                        cmd.Parameters.AddWithValue("@Name", selectedProduct.Name);
                        
                        int productStock = 0;
                        double productPrice = 0;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productPrice = Convert.ToDouble(reader["PRICE"]);
                                productStock = Convert.ToInt32(reader["STOCK"]);
                            }
                        }

                        if (productStock < selectedProduct.Quantity)
                        {
                            MessageBox.Show($"Limited stock.\nStock: {productStock}");
                            return;
                        }

                        double total = selectedProduct.Quantity * productPrice;

                        // Update DataGridView
                        bool found = false;
                        foreach (DataGridViewRow row in CartList.Rows)
                        {
                            if (row.Cells["colName"].Value?.ToString() == selectedProduct.Name)
                            {
                                row.Cells["colPrice"].Value = selectedProduct.Price;
                                row.Cells["colQuantity"].Value = selectedProduct.Quantity;
                                row.Cells["colTotal"].Value = total;
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            CartList.Rows.Add(CartList.Rows.Count+1, selectedProduct.Name, selectedProduct.Price, selectedProduct.Quantity, total);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                            connect.Close();
                    }

                    updateAll();
                    //updatesubtotal();
                    //updateTax();
                };
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }

        }

        // button e click korle oita product show korbe
        public void getAllProduct(string sql = @"SELECT * FROM Inventory Where CATEGORY='Coffee'")
        {
            try
            {
                ItemLayout.Controls.Clear();
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                if (ItemLayout == null)
                {
                    MessageBox.Show("FlowLayoutPanel is not initialized.");
                    return;
                }

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string name = reader["NAME"].ToString();
                    string price = reader["PRICE"].ToString();
                    int stock = int.Parse(reader["STOCK"].ToString());
                    string category = reader["CATEGORY"].ToString();
                    string img = reader["PHOTO"].ToString();

                    addProduct(id, name, price, category, img, stock);
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        // payment section update
        private void updateAll()
        {
            double subtotal = 0;
            foreach (DataGridViewRow row in CartList.Rows)
            {
                double price = Convert.ToDouble(row.Cells["colTotal"].Value);
                subtotal += price;
            }
            double discountAmount = subtotal*(Convert.ToDouble(DiscountCB.Text)/100);

            double totalTax = ((subtotal-discountAmount)* 0.05);
            SubTotalTB.Text = subtotal.ToString();
            TaxTB.Text = totalTax.ToString();

            double totalAmount = (subtotal + totalTax)-discountAmount;
            TotalTB.Text = totalAmount.ToString();
        }


        // Calculate Change
        private void PaidTB_TextChanged(object sender, EventArgs e)
        {
            double total = 0;
            double paid = 0;

            // Parse the values from the TextBoxes
            double.TryParse(TotalTB.Text, out total);

            if (double.TryParse(PaidTB.Text, out paid))
            {
                // Calculate change
                double change = paid - total;

                // Display change
                if (change >= 0)
                {
                    ChangeTB.Text = change.ToString("N2");
                }
                else
                {
                    ChangeTB.Text = "0.00";
                }
            }
            else
            {
                ChangeTB.Text = "0.00";
            }
        }

        // inventory update
        private void updateInventoryStock()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                foreach (DataGridViewRow row in CartList.Rows)
                {
                    if (row.Cells["colName"].Value != null)
                    {
                        string itemName = row.Cells["colName"].Value.ToString();
                        int soldQuantity = Convert.ToInt32(row.Cells["colQuantity"].Value);

                        // SQL to subtract the sold quantity from current stock
                        string updateSql = "UPDATE Inventory SET STOCK = STOCK - @qty, SOLD = SOLD + @qty WHERE NAME = @name";

                        using (SqlCommand cmd = new SqlCommand(updateSql, connect))
                        {
                            cmd.Parameters.AddWithValue("@qty", soldQuantity);
                            cmd.Parameters.AddWithValue("@name", itemName);
                            cmd.ExecuteNonQuery();
                        }

                        // sql for sold count


                    }
                }
                getAllProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock Update Error: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        // Add Order Data ---------
        public void addOrderData()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string insertOrderSql = @"INSERT INTO Orders (ORDER_ID, TOTAL, ORDER_TYPE, PAY_TYPE, USER_ID, DATE) 
                                        VALUES (@orderId, @totalAmount, @orderType, @paymentType, @userId, @orderDate)";

                using (SqlCommand cmd = new SqlCommand(insertOrderSql, connect))
                {
                    cmd.Parameters.AddWithValue("@orderId", OrderIDTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@totalAmount", Convert.ToDouble(TotalTB.Text));
                    cmd.Parameters.AddWithValue("@orderType", OrderTypeCB.Text.Trim());    
                    cmd.Parameters.AddWithValue("@paymentType", PayTypeCB.Text.Trim());
                    cmd.Parameters.AddWithValue("@userId", UserIDTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@orderDate", DateTime.Today);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order Data Insertion Error: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        // clear all from textboxes and datagridview
        private void ResetOrderForm()
        {
            CartList.Rows.Clear();

            // Reset Dropdowns
            OrderTypeCB.SelectedIndex = -1;
            PayTypeCB.SelectedIndex = -1;
            DiscountCB.SelectedIndex = 0;


            PaidTB.Clear();
            ChangeTB.Text = "0.00";

            updateAll();
            getAllProduct();
        }


        private void AddB_Click(object sender, EventArgs e)
        {
            
        }


        private int Row = 0;
        // PRINT BUTTON --------------
        private void PrintB_Click(object sender, EventArgs e)
        {
            if (emptyFileds())
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double total = 0;
            double paid = 0;

            double.TryParse(TotalTB.Text, out total);
            double.TryParse(PaidTB.Text, out paid);

            //Validation
            if (paid < total || CartList.Rows.Count == 0)
            {
                MessageBox.Show("Invalid or Insufficient Paid Amount!", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Message box confirmation
            DialogResult confirm = MessageBox.Show("Are you sure you want to print the receipt?", "Confirm Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Print Receipt
            if (confirm == DialogResult.Yes)
            {
                updateInventoryStock();
                addOrderData();
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
                OrderIDTB.Text = GenerateId().ToString();

                //Reset everything 
                ResetOrderForm();

                MessageBox.Show("Transaction Complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Printing Logic
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            Font bold = new Font("Arial", 10, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);

            float y = e.MarginBounds.Top;
            int colWidth = 120;

            //Logo in Printing Receipt
            try
            {
                Image logo = Properties.Resources.Logo;

                int logoWidth = 100; 
                int logoHeight = 100;
                int centerX = (e.PageBounds.Width - logoWidth) / 2;

                e.Graphics.DrawImage(logo, centerX, y, logoWidth, logoHeight);

                y += logoHeight + 10;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //HEADER 
            string headerText = "CAFE URBAN BREW";
            e.Graphics.DrawString(
                headerText,
                headerFont,
                Brushes.Black,
                e.PageBounds.Width / 2,
                y,
                new StringFormat { Alignment = StringAlignment.Center }
            );

            y += headerFont.GetHeight(e.Graphics) + 5; // Move down slightly

            //   ORDER ID
            e.Graphics.DrawString(
                $"Order ID: {OrderIDTB.Text}",
                bold,
                Brushes.Black,
                e.PageBounds.Width / 2,
                y,
                new StringFormat { Alignment = StringAlignment.Center }
            );

            y += bold.GetHeight(e.Graphics) + 15; // Add spacing before the table

            //HEADERS 
            string[] headers = { "Item", "Price", "Qty", "Total" };
            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawString(
                    headers[i],
                    bold,
                    Brushes.Black,
                    e.MarginBounds.Left + i * colWidth,
                    y
                );
            }

            y += bold.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += 10;

            while (Row < CartList.Rows.Count)
            {
                DataGridViewRow row = CartList.Rows[Row];

                if (!row.IsNewRow)
                {
                    e.Graphics.DrawString(row.Cells["colName"].Value?.ToString(), font, Brushes.Black, e.MarginBounds.Left + 0 * colWidth, y);
                    e.Graphics.DrawString(row.Cells["colPrice"].Value?.ToString(), font, Brushes.Black, e.MarginBounds.Left + 1 * colWidth, y);
                    e.Graphics.DrawString(row.Cells["colQuantity"].Value?.ToString(), font, Brushes.Black, e.MarginBounds.Left + 2 * colWidth, y);
                    e.Graphics.DrawString(row.Cells["colTotal"].Value?.ToString(), font, Brushes.Black, e.MarginBounds.Left + 3 * colWidth, y);

                    y += font.GetHeight(e.Graphics) + 6;
                }

                Row++;

                if (y > e.MarginBounds.Bottom - 120)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // TOTAL 
            y += 20;
            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += 10;

            StringFormat rightAlign = new StringFormat() { Alignment = StringAlignment.Far };
            float leftX = e.MarginBounds.Left;
            float rightX = e.MarginBounds.Right;

            e.Graphics.DrawString($"Order Type: {OrderTypeCB.Text}", bold, Brushes.Black, leftX, y);
            double.TryParse(SubTotalTB.Text, out double subtotalVal);
            e.Graphics.DrawString($"Subtotal: {subtotalVal:N2}", font, Brushes.Black, rightX, y, rightAlign);

            y += 20;

            e.Graphics.DrawString($"Payment: {PayTypeCB.Text}", bold, Brushes.Black, leftX, y);

            double.TryParse(TaxTB.Text, out double taxVal);
            e.Graphics.DrawString($"Tax: {taxVal:N2}", font, Brushes.Black, rightX, y, rightAlign);

            y += 20;
            e.Graphics.DrawString($"Discount: {DiscountCB.Text}%", font, Brushes.Black, rightX, y, rightAlign);
            y += 25;

            double.TryParse(TotalTB.Text, out double totalVal);
            e.Graphics.DrawString($"TOTAL: {totalVal:N2}", bold, Brushes.Black, rightX, y, rightAlign);

            y += 25;
            double.TryParse(PaidTB.Text, out double paidVal);
            double changeVal = paidVal - totalVal;

            e.Graphics.DrawString($"PAID: {paidVal:N2}", font, Brushes.Black, rightX, y, rightAlign);
            y += 18;
            e.Graphics.DrawString($"CHANGE: {changeVal:N2}", bold, Brushes.Black, rightX, y, rightAlign);
        }

        private void DiscountCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiscountCB_SelectedValueChanged(object sender, EventArgs e)
        {
            updateAll();
        }

        private void CoffeeB_Click(object sender, EventArgs e)
        {
            getAllProduct(@"SELECT * FROM Inventory Where CATEGORY='Coffee'");
        }

        private void TeaB_Click(object sender, EventArgs e)
        {
            getAllProduct(@"SELECT * FROM Inventory Where CATEGORY='Tea'");
        }

        private void DrinksB_Click(object sender, EventArgs e)
        {
            getAllProduct(@"SELECT * FROM Inventory Where CATEGORY='Drinks'");
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Row = 0;
        }

        private void LogOutB_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }
        private void CancleB_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Clear all current order data?", "Confirm Cancel", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                ResetOrderForm();
            }
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            string id = UserIDTB.Text.Substring(0, 1);
            if (id == "A")
            {
                Main main = new Main(UserIDTB.Text);
                main.Show();
                this.Hide();
            }
            else if (id == "E")
            {
                LogIn login = new LogIn();
                login.Show();
                this.Hide();
            }
        }

        private void SmoothieB_Click(object sender, EventArgs e)
        {
            getAllProduct(@"SELECT * FROM Inventory Where CATEGORY='Smoothie'");
        }

        private void BakeryB_Click(object sender, EventArgs e)
        {
            getAllProduct(@"SELECT * FROM Inventory Where CATEGORY='Bakery'");
        }
    }
}
