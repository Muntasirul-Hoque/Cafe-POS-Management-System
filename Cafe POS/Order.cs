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

namespace Cafe_POS
{
    public partial class Order : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");
        public Order()
        {
            InitializeComponent();
            ShowOrderData();
            OrderIDTB.Text = GenerateId().ToString();
        }

        public void ShowOrderData()
        {
            OrderData order = new OrderData();
            List<OrderData> orderList = order.OrderDataList();
            OrderDataGrid.DataSource = orderList;

            OrderDataGrid.Columns["ID"].DisplayIndex = 0;
            OrderDataGrid.Columns["Total"].DisplayIndex = 1;
            OrderDataGrid.Columns["OrderType"].DisplayIndex = 2;
            OrderDataGrid.Columns["PayType"].DisplayIndex = 3;
            OrderDataGrid.Columns["UserID"].DisplayIndex = 4;
            OrderDataGrid.Columns["Date"].DisplayIndex = 5;

            UserIDTB.Text = UserAccess.Id;

        }

        // Text Clear korar jonn
        public void ClearFields()
        {
            TotalTB.Text = "";
            OrderTypeCB.Text = "";
            PaymentTypeCB.Text = "";
            UserIDTB.Text = "";
            DateTB.Text = "";
            SearchB.Text = "";
            UserIDTB.Text = UserAccess.Id;
        }

        // Empty field kina check korar jonn
        public bool IsEmptyField()
        {
            if (OrderIDTB.Text == "" || TotalTB.Text == "" || OrderTypeCB.Text == "" || PaymentTypeCB.Text == "" || UserIDTB.Text == "" || DateTB.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
            ;
        }

        private string GenerateId()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }

            string newId = "O101";

            string query = "SELECT ORDER_ID FROM Orders ORDER BY ORDER_ID DESC";

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

        private void NameL_Click(object sender, EventArgs e)
        {

        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (IsEmptyField())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            try
            {
                connect.Open();

                string query = "INSERT INTO Orders (ORDER_ID, TOTAL, ORDER_TYPE, PAY_TYPE, USER_ID, DATE) VALUES (@Id, @Total, @OrderType, @PayType, @UserID, @Date)";
                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@Id", OrderIDTB.Text);
                cmd.Parameters.AddWithValue("@Total", TotalTB.Text);
                cmd.Parameters.AddWithValue("OrderType", OrderTypeCB.Text);
                cmd.Parameters.AddWithValue("@PayType", PaymentTypeCB.Text.Trim());
                cmd.Parameters.AddWithValue("@UserID", UserIDTB.Text.Trim());
                cmd.Parameters.AddWithValue("@Date", DateTB.Value.Date);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully");
                ShowOrderData();
                OrderIDTB.Text = GenerateId().ToString();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            if (IsEmptyField())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            try
            {
                connect.Open();
                string query = "UPDATE Orders SET TOTAL = @Total, ORDER_TYPE = @OrderType, PAY_TYPE = @PayType, USER_ID = @UserID, DATE = @Date WHERE ORDER_ID = @Id";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@Id", OrderIDTB.Text.Trim());
                cmd.Parameters.AddWithValue("@Total", TotalTB.Text.Trim());
                cmd.Parameters.AddWithValue("@OrderType", OrderTypeCB.Text.Trim());
                cmd.Parameters.AddWithValue("@PayType", PaymentTypeCB.Text.Trim());
                cmd.Parameters.AddWithValue("@UserID", UserIDTB.Text.Trim());
                cmd.Parameters.AddWithValue("@Date", DateTB.Value.Date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Updated Successfully");
                ShowOrderData();
                OrderIDTB.Text = GenerateId().ToString();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (OrderIDTB.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            DialogResult check = MessageBox.Show(
                "Are you sure you want to delete this Order?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (check == DialogResult.Yes)
            {
                try
                {
                    connect.Open();

                    // for Employee Table
                    string query = "DELETE FROM Orders WHERE ORDER_ID = @Id";

                    SqlCommand cmd = new SqlCommand(query, connect);

                    cmd.Parameters.AddWithValue("@Id", OrderIDTB.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Order Removed Successfully");
                    ShowOrderData();
                    OrderIDTB.Text = GenerateId().ToString();

                    ClearFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            if (SearchTB.Text == "")
            {
                MessageBox.Show("Please Enter Order ID to Search");
                return;
            }
            try
            {
                connect.Open();
                string query = "SELECT * FROM Orders WHERE ORDER_ID = @Id";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@Id", SearchTB.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    OrderIDTB.Text = reader["ORDER_ID"].ToString();
                    TotalTB.Text = reader["TOTAL"].ToString();
                    OrderTypeCB.Text = reader["ORDER_TYPE"].ToString();
                    PaymentTypeCB.Text = reader["PAY_TYPE"].ToString();
                    UserIDTB.Text = reader["USER_ID"].ToString();
                    DateTB.Text = reader["DATE"].ToString();
                }
                else
                {
                    MessageBox.Show("Order Not Found");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void RefreshB_Click(object sender, EventArgs e)
        {
            ShowOrderData();
        }
    }
}
