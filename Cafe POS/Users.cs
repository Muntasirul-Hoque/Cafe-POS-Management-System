using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_POS
{
    internal class Users
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");

        public string ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


        public Users() { }
        public Users(string id, string name, string password, string role)
        {
            ID = id;
            Name = name;
            Password = password;
            Role = role;
        }

        //public List<Users> UsersList()
        //{
        //    List<Users> userList = new List<Users>();
        //    if (connect.State != System.Data.ConnectionState.Open)
        //    {
        //        try
        //        {
        //            connect.Open();
        //            string query = "SELECT * FROM Users";
        //            SqlCommand cmd = new SqlCommand(query, connect);
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                Users user = new Users();
        //                user.ID = reader["ID"].ToString();
        //                user.Name = reader["NAME"].ToString();
        //                user.Password = reader["PASSWORD"].ToString();
        //                user.Role = reader["ROLE"].ToString();
        //                userList.Add(user);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("An error occurred: " + ex.Message);
        //        }
        //        finally
        //        {
        //            connect.Close();
        //        }
        //    }
        //    return userList;
        //}

    }
}
