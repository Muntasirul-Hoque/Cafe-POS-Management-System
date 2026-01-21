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
    public partial class Dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");
        public Dashboard()
        {
            InitializeComponent();
            sales();
            BestProducts();
            LowStock();
        }

        public void sales()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            // Today Sales
            string today = DateTime.Today.ToString();
            string totalSalesQuery = @"SELECT ISNULL(SUM(TOTAL), 0)
                                       FROM Orders
                                       WHERE DATE = @today" ;

            SqlCommand cmd = new SqlCommand(totalSalesQuery, connect);
            cmd.Parameters.Add("@today", SqlDbType.Date).Value = today;

            object result = cmd.ExecuteScalar();

            decimal todaysales = Convert.ToDecimal(result);  
            TodayL.Text = "TK" + todaysales.ToString();

            // Monthly Sales
            string startMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
                        .ToString("yyyy-MM-dd");

            string endMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month,
                                    DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month))
                                    .AddDays(1) 
                                    .ToString("yyyy-MM-dd");


            string mon = @"SELECT ISNULL(SUM(TOTAL), 0)
                           FROM Orders
                           WHERE [DATE] >= @StartDate
                           AND [DATE] < @EndDate";

            SqlCommand cmd2 = new SqlCommand(mon, connect);
            cmd2.Parameters.Add("@StartDate", SqlDbType.Date).Value = startMonth;
            cmd2.Parameters.Add("@EndDate", SqlDbType.Date).Value = endMonth;

            object result2 = cmd2.ExecuteScalar();

            decimal monthlysale = Convert.ToDecimal(result2);
            MonthlyL.Text = "TK " + monthlysale.ToString();


            connect.Close();
        }

        public void BestProducts()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            // Best Product 1
            string top1 = @"SELECT TOP 1 NAME, SOLD, PHOTO
                            FROM INVENTORY
                            ORDER BY SOLD DESC";
            SqlCommand cmd3 = new SqlCommand(top1, connect);
            SqlDataReader reader = cmd3.ExecuteReader();
            if (reader.Read())
            {
                Bp1L.Text = reader["NAME"].ToString();
                Sold1L.Text = reader["SOLD"].ToString();
                Bp1PB.ImageLocation = reader["PHOTO"].ToString();
            }
            reader.Close();

            // Best Product 2
            string top2 = @"SELECT TOP 1 NAME, SOLD, PHOTO
                            FROM INVENTORY
                            WHERE SOLD < (SELECT MAX(SOLD) FROM INVENTORY)
                            ORDER BY SOLD DESC";
            SqlCommand cmd4 = new SqlCommand(top2, connect);
            SqlDataReader reader2 = cmd4.ExecuteReader();
            if (reader2.Read())
            {
                Bp2L.Text = reader2["NAME"].ToString();
                Sold2L.Text = reader2["SOLD"].ToString();
                Bp2PB.ImageLocation = reader2["PHOTO"].ToString();
            }
            reader2.Close();

            // Best Product 3
            string top3 = @"SELECT TOP 1 NAME, SOLD, PHOTO
                            FROM INVENTORY
                            WHERE SOLD < (SELECT MAX(SOLD) FROM INVENTORY WHERE SOLD < (SELECT MAX(SOLD) FROM INVENTORY))
                            ORDER BY SOLD DESC";
            SqlCommand cmd5 = new SqlCommand(top3, connect);
            SqlDataReader reader3 = cmd5.ExecuteReader();
            if (reader3.Read())
            {
                Bp3L.Text = reader3["NAME"].ToString();
                Sold3L.Text = reader3["SOLD"].ToString();
                Bp3PB.ImageLocation = reader3["PHOTO"].ToString();
            }
            reader3.Close();

            connect.Close();
        }

        public void LowStock()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            // Low Stock 1
            string top1 = @"SELECT TOP 1 NAME, STOCK, PHOTO
                            FROM INVENTORY
                            ORDER BY STOCK ASC";
            SqlCommand cmd3 = new SqlCommand(top1, connect);
            SqlDataReader reader = cmd3.ExecuteReader();
            if (reader.Read())
            {
                Ls1L.Text = reader["NAME"].ToString();
                Stock1L.Text = reader["STOCK"].ToString();
                LS1PB.ImageLocation = reader["PHOTO"].ToString();
            }
            reader.Close();

            // Low Stock 2
            string top2 = @"SELECT TOP 1 NAME, STOCK, PHOTO
                            FROM INVENTORY
                            WHERE STOCK > (SELECT MIN(STOCK) FROM INVENTORY)
                            ORDER BY STOCK ASC";
            SqlCommand cmd4 = new SqlCommand(top2, connect);
            SqlDataReader reader2 = cmd4.ExecuteReader();
            if (reader2.Read())
            {
                Ls2L.Text = reader2["NAME"].ToString();
                Stock2L.Text = reader2["STOCK"].ToString();
                LS2PB.ImageLocation = reader2["PHOTO"].ToString();
            }
            reader2.Close();

            // Low Stock 3
            string top3 = @"SELECT TOP 1 NAME, STOCK, PHOTO
                            FROM INVENTORY
                            WHERE STOCK > (SELECT MIN(STOCK) FROM INVENTORY WHERE STOCK > (SELECT MIN(STOCK) FROM INVENTORY))
                            ORDER BY STOCK ASC";
            SqlCommand cmd5 = new SqlCommand(top3, connect);
            SqlDataReader reader3 = cmd5.ExecuteReader();
            if (reader3.Read())
            {
                Ls3L.Text = reader3["NAME"].ToString();
                Stock3L.Text = reader3["STOCK"].ToString();
                LS3PB.ImageLocation = reader3["PHOTO"].ToString();
            }
            reader3.Close();
            connect.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void TpL_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
