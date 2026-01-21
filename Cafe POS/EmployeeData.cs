using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_POS
{
    internal class EmployeeData:Users
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");
        //public string Id { set; get; }
        //public string Name { set; get; }
        public int Salary { set; get; }
        public string Phone { set; get; }
        //public string Password { set; get; }

        public EmployeeData() { }

        public EmployeeData(string id, string name, int salary, string phone, string password)
            :base(id, name, password, "Employee")
        {
            this.ID = id;
            this.Name = name;
            this.Salary = salary;
            this.Phone = phone;
            this.Password = password;
        }

        public List<EmployeeData> EmployeeDataList()
        {
            List<EmployeeData> dataList = new List<EmployeeData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string query = "SELECT * FROM Employee";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    
                        SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                EmployeeData emp = new EmployeeData();
                                emp.ID = reader["ID"].ToString();
                                emp.Name = reader["NAME"].ToString();
                                emp.Salary = Convert.ToInt32(reader["SALARY"]);
                                emp.Phone = reader["PHONE"].ToString();
                                emp.Password = reader["PASSWORD"].ToString();
                                dataList.Add(emp);
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
