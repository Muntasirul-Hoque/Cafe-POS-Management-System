using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_POS
{
    internal class AdminData: Users
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");

       // public string Id { get; set; }
       // public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        //public string Password { get; set; }

        public string Photo { get; set; }

        public AdminData()
        {
        }

        public AdminData(string id, string name, string phone, string email, string password, string photo)
            : base(id, name, password, "Admin")
        {
            this.ID = id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Password = password;
            this.Photo = photo;
        }

        public List<AdminData> AdminDataList()
        {
            List<AdminData> dataList = new List<AdminData>();

            try
            {
                connect.Open();

                string query = "SELECT * FROM Admin";
                SqlCommand cmd = new SqlCommand(query, connect);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AdminData adm = new AdminData();

                    adm.ID = reader["ID"].ToString();
                    adm.Name = reader["NAME"].ToString();
                    adm.Phone = reader["PHONE"].ToString();
                    adm.Email = reader["EMAIL"].ToString();
                    adm.Password = reader["PASSWORD"].ToString();
                    adm.Photo = reader["PHOTO"].ToString();

                    dataList.Add(adm);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            return dataList;
        }
    }
}
