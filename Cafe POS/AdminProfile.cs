using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_POS
{
    public partial class AdminProfile : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminProfile()
        {
            InitializeComponent();
            UpdateB.Hide();
            PhotoB.Hide();
            
            ShowAdminProfile();
        }
        private void ShowAdminProfile()
        {
            string id = UserAccess.Id;
            connect.Open();
            string query = "SELECT * FROM Admin WHERE ID = @Id";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                IDTB.Text = reader["ID"].ToString();
                NameTB.Text = reader["NAME"].ToString();
                PhoneTB.Text = reader["PHONE"].ToString();
                EmailTB.Text = reader["EMAIL"].ToString();
                PasswordTB.Text = reader["PASSWORD"].ToString();
                AdminPB.ImageLocation = reader["PHOTO"].ToString();
            }
            else
            {
                MessageBox.Show("Order Not Found");
            }
            reader.Close();
            connect.Close();
        }
        private void EditB_CheckedChanged(object sender, EventArgs e)
        {
            UpdateB.Show();
            PhotoB.Show();
            EditB.Hide();
            EditB2.Show();
            EditB2.Checked = true;
            IDTB.ReadOnly = false;
            NameTB.ReadOnly = false;
            PhoneTB.ReadOnly = false;
            EmailTB.ReadOnly = false;
            PasswordTB.ReadOnly = false;
        }

        private void EditB2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateB.Hide();
            PhotoB.Hide();
            EditB.Show();
            EditB2.Hide();
            EditB.Checked = false;
            IDTB.ReadOnly = true;
            NameTB.ReadOnly = true;
            PhoneTB.ReadOnly = true;
            EmailTB.ReadOnly = true;
            PasswordTB.ReadOnly = true;

        }

        private void UpdateB_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "" || PhoneTB.Text == "" || EmailTB.Text == "" || AdminPB.ImageLocation == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                try
                {
                    connect.Open();
                    // for Admin table
                    string query = @"UPDATE Admin 
                                    SET ID=@ID, NAME=@Name, PHONE=@Phone, EMAIL=@Email,PASSWORD=@pass PHOTO=@Photo 
                                    WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@ID", IDTB.Text);
                    cmd.Parameters.AddWithValue("@Name", NameTB.Text);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTB.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTB.Text);
                    cmd.Parameters.AddWithValue("@Photo", AdminPB.ImageLocation);
                    cmd.Parameters.AddWithValue("@pass", PasswordTB.Text);
                    cmd.ExecuteNonQuery();

                    // for Users table
                    string userQuery = @"UPDATE Users 
                                         SET NAME=@Name, PASSWORD=@Password 
                                         WHERE ID=@ID";
                    SqlCommand userCmd = new SqlCommand(userQuery, connect);
                    userCmd.Parameters.AddWithValue("@ID", IDTB.Text);
                    userCmd.Parameters.AddWithValue("@Name", NameTB.Text);

                    MessageBox.Show("Admin updated successfully!");
                    EditB2.PerformClick();

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

        private void PhotoB_Click(object sender, EventArgs e)
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

        private void RefreshB_Click(object sender, EventArgs e)
        {
            ShowAdminProfile();
        }
    }
}

