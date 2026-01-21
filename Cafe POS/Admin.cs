using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_POS
{
    public partial class Admin : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");

        public Admin()
        {
            InitializeComponent();
            ShowAdminData();
            IdTB.Text = GenerateId().ToString();
        }

        public void ShowAdminData()
        {
            AdminData admData = new AdminData();
            List<AdminData> dataList = admData.AdminDataList();
            AdminDataGrid.DataSource = dataList;

            AdminDataGrid.Columns["ID"].DisplayIndex = 0;
            AdminDataGrid.Columns["NAME"].DisplayIndex = 1;
            AdminDataGrid.Columns["PHONE"].DisplayIndex = 2;
            AdminDataGrid.Columns["EMAIL"].DisplayIndex = 3;
            AdminDataGrid.Columns["PHOTO"].DisplayIndex = 4;

            AdminDataGrid.Columns["ROLE"].Visible = false;
            AdminDataGrid.Columns["PASSWORD"].Visible = false;
        }

        // Text clear korar jonno
        public void ClearFields()
        {
            NameTB.Text = "";
            PhoneTB.Text = "";
            EmailTB.Text = "";
            PasswordTB.Text = "";
            SearchTB.Text = "";
            AdminPB.ImageLocation = "";
        }

        // Text Box Khali kina check korbe
        public bool emptyField()
        {
            if (NameTB.Text == "" || PhoneTB.Text == "" || EmailTB.Text == "" || PasswordTB.Text == "" || AdminPB.ImageLocation == "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Email Pattern checker
        string emailpattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public bool validmail()
        {
            if (Regex.IsMatch(EmailTB.Text, emailpattern) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // ID Auto Generate
        private string GenerateId()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }

            string newId = "A101";

            string query = "SELECT ID FROM Admin ORDER BY ID DESC";

            SqlCommand cmd = new SqlCommand(query, connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["ID"].ToString();
                    int number = int.Parse(lastId.Replace("A", ""));
                    newId = "A" + (number + 1);
                }
            }
            connect.Close();
            return newId;
        }
        

        // Add Button ----------------------
        private void AddB_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (validmail())
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            else
            {
                try
                {
                    connect.Open();
                    // for Admin table
                    string query = @"INSERT INTO Admin (ID, NAME, PHONE, EMAIL, PASSWORD, PHOTO) 
                                     VALUES (@ID, @Name, @Phone, @Email, @Password, @Photo)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@ID", IdTB.Text);
                    cmd.Parameters.AddWithValue("@Name", NameTB.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTB.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTB.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTB.Text);
                    cmd.Parameters.AddWithValue("@Photo", AdminPB.ImageLocation);

                    cmd.ExecuteNonQuery();

                    // for Users table
                    string userQuery = @"INSERT INTO Users (ID, NAME, PASSWORD, ROLE)
                                         VALUES (@ID, @Name, @Password, @Role)";
                    SqlCommand userCmd = new SqlCommand(userQuery, connect);
                    userCmd.Parameters.AddWithValue("@ID", IdTB.Text);
                    userCmd.Parameters.AddWithValue("@Name", NameTB.Text);
                    userCmd.Parameters.AddWithValue("@Password", PasswordTB.Text);
                    userCmd.Parameters.AddWithValue("@Role", "Admin");
                    
                    userCmd.ExecuteNonQuery();

                    MessageBox.Show("Admin added successfully!");
                    ShowAdminData();
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


        // Photo Import Button ---------------------
        private void ImportB_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.png|*.jpg;*.png)";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    AdminPB.ImageLocation = dialog.FileName;
                    AdminPB.Image = new Bitmap(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Update Button ----------------------
        private void UpdateB_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "" || PhoneTB.Text == "" || EmailTB.Text == "" || AdminPB.ImageLocation == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (validmail())
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            else
            {
                try
                {
                    connect.Open();
                    // for Admin table
                    string query = @"UPDATE Admin 
                                    SET NAME=@Name, PHONE=@Phone, EMAIL=@Email, PHOTO=@Photo 
                                    WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@ID", IdTB.Text);
                    cmd.Parameters.AddWithValue("@Name", NameTB.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTB.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTB.Text);
                    cmd.Parameters.AddWithValue("@Photo", AdminPB.ImageLocation);
                    cmd.ExecuteNonQuery();

                    // for Users table
                    string userQuery = @"UPDATE Users 
                                         SET NAME=@Name, PASSWORD=@Password 
                                         WHERE ID=@ID";
                    SqlCommand userCmd = new SqlCommand(userQuery, connect);
                    userCmd.Parameters.AddWithValue("@ID", IdTB.Text);
                    userCmd.Parameters.AddWithValue("@Name", NameTB.Text);

                    MessageBox.Show("Admin updated successfully!");
                    ShowAdminData();
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

        // Remove Button ----------------------
        private void RemoveB_Click(object sender, EventArgs e)
        {
            if (IdTB.Text=="")
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }


            DialogResult check = MessageBox.Show(
                "Are you sure you want to delete this admin?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (check == DialogResult.Yes)
            {
                try
                {
                    connect.Open();

                    // for admin table
                    string query = "DELETE FROM Admin WHERE ID = @Id";

                    SqlCommand cmd = new SqlCommand(query, connect);

                    cmd.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                    cmd.ExecuteNonQuery();

                    // for users table
                    string userQuery = "DELETE FROM Users WHERE ID = @Id";
                    SqlCommand userCmd = new SqlCommand(userQuery, connect);
                    userCmd.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                    userCmd.ExecuteNonQuery();


                    MessageBox.Show("Admin Removed Successfully");
                    ShowAdminData();
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

        // Clear Button ----------------------
        private void ClearB_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Search Button ----------------------
        private void SearchB_Click(object sender, EventArgs e)
        {
            if (SearchTB.Text == "")
            {
                MessageBox.Show("Please Enter Admin ID");
                return;
            }

            try
            {
                connect.Open();

                string query = "SELECT * FROM Admin WHERE ID = @Id";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@Id", SearchTB.Text.Trim());

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IdTB.Text = reader["ID"].ToString();
                    NameTB.Text = reader["NAME"].ToString();
                    PhoneTB.Text = reader["PHONE"].ToString();
                    EmailTB.Text = reader["EMAIL"].ToString();
                    AdminPB.ImageLocation = reader["PHOTO"].ToString();
                }
                else
                {
                    MessageBox.Show("Admin Not Found");
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

        private void RefreshB_Click(object sender, EventArgs e)
        {
            ShowAdminData();
        }
    }
}
