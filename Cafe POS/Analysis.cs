using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_POS
{
    public partial class Analysis : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");
        public Analysis()
        {
            InitializeComponent();
            LoadMonthlySales();
        }

        public void LoadMonthlySales()
        {
            int currentYear = DateTime.Now.Year;


            // graph setup
            GraphC.Series.Clear();
            GraphC.Series.Add("Sales");

            string query = @"SELECT YEAR(DATE) AS SalesYear, MONTH(DATE) AS SalesMonth, 
                            SUM(TOTAL) AS Total_Sales FROM ORDERS
                            GROUP BY YEAR(DATE), MONTH(DATE)
                            ORDER BY SalesYear, SalesMonth";

            SqlCommand cmd = new SqlCommand(query, connect);
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // update graph and monthly sales
            while (reader.Read())
            {
                int year = Convert.ToInt32(reader["SalesYear"]);
                int month = Convert.ToInt32(reader["SalesMonth"]);
                decimal total = Convert.ToDecimal(reader["Total_Sales"]);

                if (year != currentYear) { continue; }

                switch (month)
                {
                    case 1: JanL.Text = JanL.Text + total; break;
                    case 2: FebL.Text = FebL.Text + total; break;
                    case 3: MarL.Text = MarL.Text + total; break;
                    case 4: AprL.Text = AprL.Text + total; break;
                    case 5: MayL.Text = MayL.Text + total; break;
                    case 6: JuneL.Text = JuneL.Text + total; break;
                    case 7: JulyL.Text = JulyL.Text + total; break;
                    case 8: AugL.Text = AugL.Text + total; break;
                    case 9: SepL.Text = SepL.Text + total; break;
                    case 10: OctL.Text = OctL.Text + total; break;
                    case 11: NovL.Text = NovL.Text + total; break;
                    case 12: DecL.Text = DecL.Text + total; break;
                }

                string[] months ={ "January","February","March","April","May","June","July","August","September","October","November","December"};
                GraphC.Series["Sales"].Points.AddXY(months[month-1], total );
            }

            reader.Close();
            connect.Close();
        }


        private void FirstP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MarL_Click(object sender, EventArgs e)
        {

        }

        private void GraphP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JansaleL_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void GraphC_Click(object sender, EventArgs e)
        {

        }

        private void MonthP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Analysis_Load(object sender, EventArgs e)
        {

        }
    }
}
