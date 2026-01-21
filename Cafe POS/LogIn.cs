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
    public partial class LogIn : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");

        public LogIn()
        {
            InitializeComponent();
        }


        private void LogInB_Click(object sender, EventArgs e)
        {
            if (IdTB.Text == "" || PassTB.Text == "")
            {
                MessageBox.Show("Please enter your ID and Password");
                return;
            }

            try
            {
                connect.Open();

                // Employee ---------------
                string query = "SELECT COUNT(*) FROM Employee WHERE ID = @Id AND PASSWORD = @Password";

                SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@Id", IdTB.Text);
                    cmd.Parameters.AddWithValue("@Password", PassTB.Text);

                int EmpCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (EmpCount == 1)
                {
                    MessageBox.Show("Login Successful");
                    UserAccess.Id = IdTB.Text.Trim();


                    Menu menu = new Menu(IdTB.Text.Trim());
                    menu.Show();
                    this.Hide();
                    return;
                }

                // Admin ----------------
                query = "SELECT COUNT(*) FROM Admin WHERE ID = @Id AND PASSWORD = @Password";
                
                SqlCommand cmd2 = new SqlCommand(query, connect);
                    cmd2.Parameters.AddWithValue("@Id", IdTB.Text);
                    cmd2.Parameters.AddWithValue("@Password", PassTB.Text);

                int ACount = Convert.ToInt32(cmd2.ExecuteScalar());

                if (ACount == 1)
                {
                    MessageBox.Show("Login Successful");
                    UserAccess.Id = IdTB.Text.Trim();

                    Main main = new Main(IdTB.Text.Trim());
                    main.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }

            //if (IdTB.Text == "A101" && PassTB.Text == "1234")
            //{
            //    MessageBox.Show("Login Successful");

            //    Main main = new Main(IdTB.Text.Trim());
            //    main.Show();
            //    this.Hide();
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Invalid ID or Password");
            //}

        }

    }
}
