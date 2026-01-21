using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_POS
{
    internal class OrderData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");
        public string ID { get; set; }
        public double Total { get; set; }
        public string OrderType { get; set; }  
        public string PayType { get; set; }
        public string UserID { get; set; }
        public DateTime Date { get; set; }   

        public List<OrderData> OrderDataList()
        {
            List<OrderData> orderList = new List<OrderData>();
            if (connect.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string query = "SELECT * FROM Orders";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        OrderData order = new OrderData();
                        order.ID = reader["ORDER_ID"].ToString();
                        order.Total = Convert.ToDouble(reader["TOTAL"]);
                        order.OrderType = reader["ORDER_TYPE"].ToString();
                        order.PayType = reader["PAY_TYPE"].ToString();
                        order.UserID = reader["USER_ID"].ToString();
                        order.Date = Convert.ToDateTime(reader["DATE"]);
                        orderList.Add(order);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
            return orderList;
        }
    }
}
