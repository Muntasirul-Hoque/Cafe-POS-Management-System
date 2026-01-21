using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Cafe_POS
{
    public partial class Employee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");

        public Employee()
        {
            InitializeComponent();
            ShowEmployeeData(); 
            IdTB.Text = GenerateId().ToString();
        }

        // SHow Employee Data in Data Grid View
        public void ShowEmployeeData()
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> dataList = empData.EmployeeDataList();
            EmpDataGrid.DataSource = dataList;

            EmpDataGrid.Columns["ID"].DisplayIndex = 0;
            EmpDataGrid.Columns["Name"].DisplayIndex = 1;
            EmpDataGrid.Columns["Salary"].DisplayIndex = 2;
            EmpDataGrid.Columns["Phone"].DisplayIndex = 3;
            EmpDataGrid.Columns["Password"].DisplayIndex = 4;

            EmpDataGrid.Columns["Role"].Visible = false;
        }

        // Text clear korar jonno
        public void ClearFields()
        {
            NameTB.Text = "";
            SalaryTB.Text = "";
            PhoneTB.Text = "";
            PasswordTB.Text = "";
            SearchTB.Text = "";
        }

        // Text Box Khali kina check korbe
        public bool emptyField()
        {
            if (NameTB.Text == "" || SalaryTB.Text == "" || PhoneTB.Text == "" || PasswordTB.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // ID Auto generate 
        private string GenerateId()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }

            string newId = "E101";

            string query = "SELECT ID FROM Employee ORDER BY ID DESC";

            SqlCommand cmd = new SqlCommand(query, connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["ID"].ToString();
                    int number = int.Parse(lastId.Replace("E", ""));
                    newId = "E" + (number + 1);
                }
            }
            connect.Close();
            return newId;
        }



        // Add Button ----------
        private void AddB_Click(object sender, EventArgs e)
        {

            if (emptyField())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            try
            {
                connect.Open();

                // for Employee Table
                string Empquery = @"INSERT INTO Employee (ID, NAME, SALARY, PHONE, PASSWORD)
                                VALUES (@Id, @Name, @Salary, @Phone, @Pass)";

                SqlCommand cmd = new SqlCommand(Empquery, connect);
                    cmd.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Name", NameTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Salary", int.Parse(SalaryTB.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Phone", PhoneTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@Pass", PasswordTB.Text.Trim());
                   
                    cmd.ExecuteNonQuery();

                // for user table
                string Userquery = @"INSERT INTO Users (ID, NAME, PASSWORD, ROLE)
                                VALUES (@Id, @Name, @Pass, @Role)";

                SqlCommand cmd2 = new SqlCommand(Userquery, connect);
                    cmd2.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                    cmd2.Parameters.AddWithValue("@Name", NameTB.Text.Trim());
                    cmd2.Parameters.AddWithValue("@Pass", PasswordTB.Text.Trim());
                    cmd2.Parameters.AddWithValue("@Role", "Employee");
                    
                    cmd2.ExecuteNonQuery();

                MessageBox.Show("Employee Added Successfully");
                ShowEmployeeData();
                IdTB.Text = GenerateId().ToString();

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

        // Update Button ------------------
        private void UpdateB_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

                try
                {
                    connect.Open();

                    // for Employee Table
                    string query = @"UPDATE Employee SET NAME = @Name, SALARY = @Salary, PHONE = @Phone, PASSWORD = @Password
                                    WHERE ID = @Id";

                    SqlCommand cmd = new SqlCommand(query, connect);
                        
                        cmd.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                        cmd.Parameters.AddWithValue("@Name", NameTB.Text.Trim());
                        cmd.Parameters.AddWithValue("@Salary", int.Parse(SalaryTB.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Phone", PhoneTB.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", PasswordTB.Text.Trim());

                        cmd.ExecuteNonQuery();

                    // for Users Table
                    string Userquery = @"UPDATE Users SET NAME = @Name, PASSWORD = @Password
                                    WHERE ID = @Id";
                    SqlCommand cmd2 = new SqlCommand(Userquery, connect);
                        
                        cmd2.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                        cmd2.Parameters.AddWithValue("@Name", NameTB.Text.Trim());
                        cmd2.Parameters.AddWithValue("@Password", PasswordTB.Text.Trim());
                        cmd2.ExecuteNonQuery();

                    MessageBox.Show("Employee Updated Successfully");

                        ShowEmployeeData();
                        IdTB.Text = GenerateId().ToString();

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

        
        // Remove Button -----------------------
        private void RemoveB_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }


            DialogResult check = MessageBox.Show(
                "Are you sure you want to delete this employee?",
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
                        string query = "DELETE FROM Employee WHERE ID = @Id";

                        SqlCommand cmd = new SqlCommand(query, connect);
                        
                            cmd.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                            cmd.ExecuteNonQuery();

                        // for Users Table
                        string Userquery = "DELETE FROM Users WHERE ID = @Id";
                        SqlCommand cmd2 = new SqlCommand(Userquery, connect);
                        
                            cmd2.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                            cmd2.ExecuteNonQuery();

                    MessageBox.Show("Employee Removed Successfully");
                            ShowEmployeeData();
                            IdTB.Text = GenerateId().ToString();

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

        // Clear Button -----------------
        private void ClearB_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Search Button -------------------
        private void SearchB_Click(object sender, EventArgs e)
        {
            if (SearchTB.Text == "")
            {
                MessageBox.Show("Please Enter Employee ID");
                return;
            }

                try
                {
                    connect.Open();

                    string query = "SELECT * FROM Employee WHERE ID = @Id";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    
                        cmd.Parameters.AddWithValue("@Id", SearchTB.Text.Trim());

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            IdTB.Text = reader["ID"].ToString();
                            NameTB.Text = reader["NAME"].ToString();
                            SalaryTB.Text = reader["SALARY"].ToString();
                            PhoneTB.Text = reader["PHONE"].ToString();
                            PasswordTB.Text = reader["PASSWORD"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Employee Not Found");
                            ClearFields();
                        }
                    
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

        private void EmpDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

            if (e.RowIndex > 0)
            {
                DataGridViewRow row = EmpDataGrid.Rows[e.RowIndex];

                IdTB.Text = row.Cells[0].Value.ToString();
                NameTB.Text = row.Cells[1].Value.ToString();
                SalaryTB.Text = row.Cells[2].Value.ToString();
                PhoneTB.Text = row.Cells[3].Value.ToString();
                PasswordTB.Text = row.Cells[4].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please select a valid row.");
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void RefreshB_Click(object sender, EventArgs e)
        {
            ShowEmployeeData();
        }
    }
}
