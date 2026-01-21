using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cafe_POS
{
    internal class InventoryData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");

        public string Id { set; get; }
        public string Name { set; get; }
        public string Category { set; get; }
        public double Price { set; get; }
        public int Stock { set; get; }
        public string Photo { set; get; }

        public string Sold { set; get; }

        public List<InventoryData> InventoryDataList()
        {
            List<InventoryData> dataList = new List<InventoryData>();

            if (connect.State != ConnectionState.Open)
            {
                try 
                {
                    connect.Open();

                    string query = "SELECT * FROM Inventory";

                    SqlCommand cmd = new SqlCommand(query, connect);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        InventoryData iData = new InventoryData();

                        iData.Id = reader["ID"].ToString();
                        iData.Name = reader["NAME"].ToString();
                        iData.Category = reader["CATEGORY"].ToString();
                        iData.Price = Convert.ToDouble(reader["PRICE"]);
                        iData.Stock = Convert.ToInt32(reader["STOCK"]);
                        iData.Photo = reader["PHOTO"].ToString();
                        iData.Sold = reader["SOLD"].ToString();
                        dataList.Add(iData);
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Error: " + ex);

                }
                finally
                {
                    connect.Close();
                }
                
            }
            return dataList;
        }

    }
}
