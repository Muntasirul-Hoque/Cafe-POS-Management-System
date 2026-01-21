using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Cafe_POS
{
    public partial class Main : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");
        public Main(string Id)
        {
            InitializeComponent();
            HideAllpanel();
            dashboard1.Show();
            IdL.Text = Id;

            connect.Open();
            string query = "SELECT * FROM Admin WHERE ID = @Id";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                AdminNameL.Text = reader["NAME"].ToString();
            }
            reader.Close();
            connect.Close();

        }

        private void HideAllpanel()
        {
            dashboard1.Hide();
            employee1.Hide();
            admin1.Hide();
            inventoryF1.Hide();
            order1.Hide();
            analysis1.Hide();
            adminProfile1.Hide();

        }
        private void InventoryB_Click(object sender, EventArgs e)
        {
            HideAllpanel();
            inventoryF1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideAllpanel();
            order1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideAllpanel();
            analysis1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(IdL.Text.Trim());
            menu.Show();
            this.Hide();
        }

        private void DahboardB_Click(object sender, EventArgs e)
        {
            HideAllpanel();
            dashboard1.Show();
        }

        private void EmployeeB_Click(object sender, EventArgs e)
        {
            HideAllpanel();
            employee1.Show();
        }


        private void LogOutB_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }



        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ProfileB_Click(object sender, EventArgs e)
        {
            HideAllpanel();
            //AdminProfile profile = new AdminProfile(IdL.Text);
            //AdminProfile.id = IdL.Text;
            adminProfile1.Show();

        }

        private void AdminB_Click(object sender, EventArgs e)
        {
            HideAllpanel();
            admin1.Show();
        }

    }
}
