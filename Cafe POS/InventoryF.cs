using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_POS
{
    public partial class InventoryF : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Cafe POS.mdf;Integrated Security=True;Connect Timeout=30");

        public InventoryF()
        {
            InitializeComponent();
            ShowInventoryData();
            IdTB.Text = GenerateInventoryId().ToString();

            
        }
        // SHow Inventory Data in Data Grid View
        public void ShowInventoryData()
        {
            InventoryData iData = new InventoryData();
            List<InventoryData> dataList = iData.InventoryDataList();
            InventoryDataGrid.DataSource = dataList;
            SoldTB.Text = "0";
        }
        // Text clear korar jonno
        public void ClearFields()
        {
            NameTB.Text = "";
            CategoryCB.Text = "";
            PriceTB.Text = "";
            StockTB.Text = "";
            SearchTB.Text = "";
            ProductPB.ImageLocation = "";
            SoldTB.Text = "0";
            AddStockTB.Text = "";
        }

        // Text Box Khali kina check korbe
        public bool emptyFIeld()
        {
            if (NameTB.Text == "" || CategoryCB.Text == "" || PriceTB.Text == "" || StockTB.Text == "" || ProductPB.ImageLocation == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // ID Auto Generate
        private string GenerateInventoryId()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }

            string newId = "I101";

            string query = "SELECT ID FROM Inventory ORDER BY ID DESC";

            SqlCommand cmd = new SqlCommand(query, connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string lastId = reader["ID"].ToString();
                    int number = int.Parse(lastId.Replace("I", ""));
                    newId = "I" + (number + 1);
                }
            }
            connect.Close();
            return newId;
        }

        // Add Button 
        private void AddB_Click(object sender, EventArgs e)
        {
            if (emptyFIeld())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }


            try
            {
                connect.Open();

                string query = @"INSERT INTO Inventory (ID, NAME, CATEGORY, PRICE, STOCK, SOLD, PHOTO)
                                VALUES (@Id, @Name, @Category, @Price, @Stock, @Sold, @Photo)";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", NameTB.Text.Trim());
                cmd.Parameters.AddWithValue("@Category", CategoryCB.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(PriceTB.Text.Trim()));
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(StockTB.Text.Trim()));
                cmd.Parameters.AddWithValue("@Sold", 0);
                cmd.Parameters.AddWithValue("@Photo", ProductPB.ImageLocation);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Inventory Added Successfully");
                ShowInventoryData();
                IdTB.Text = GenerateInventoryId().ToString();

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

        // Update Button
        private void UpdateB_Click(object sender, EventArgs e)
        {
            if (emptyFIeld())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            try
            {
                connect.Open();

                string query = @"UPDATE Inventory SET NAME = @Name, CATEGORY = @Category, PRICE = @Price, STOCK = @Stock, PHOTO = @Photo
                                WHERE ID = @Id";

                SqlCommand cmd = new SqlCommand(query, connect);

                cmd.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", NameTB.Text.Trim());
                cmd.Parameters.AddWithValue("@Category", CategoryCB.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(PriceTB.Text.Trim()));
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(StockTB.Text.Trim()));
                cmd.Parameters.AddWithValue("@Photo", ProductPB.ImageLocation);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Imventory Updated Successfully");

                ShowInventoryData();
                IdTB.Text = GenerateInventoryId().ToString();

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


        // Remove Button
        private void RemoveB_Click(object sender, EventArgs e)
        {
            if (emptyFIeld())
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }

            DialogResult check = MessageBox.Show(
                "Are you sure to remove this Item?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (check == DialogResult.Yes)
            {
                try
                {
                    connect.Open();

                    string query = "DELETE FROM Inventory WHERE ID = @Id";

                    SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@Id", IdTB.Text.Trim());
                        cmd.ExecuteNonQuery();

                    MessageBox.Show("Inventory Removed Successfully");
                    ShowInventoryData();
                    IdTB.Text = GenerateInventoryId().ToString();

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

        // Clear Button
        private void ClearB_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        
        // Search Button
        private void SearchB_Click(object sender, EventArgs e)
        {
            if (SearchTB.Text == "")
            {
                MessageBox.Show("Please enter Item Id");
                return;
            }

            try
            {
                connect.Open();

                string query = "SELECT * FROM Inventory WHERE ID = @Id";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@Id", SearchTB.Text.Trim());

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IdTB.Text = reader["ID"].ToString();
                    NameTB.Text = reader["NAME"].ToString();
                    CategoryCB.Text = reader["CATEGORY"].ToString();
                    PriceTB.Text = reader["PRICE"].ToString();
                    StockTB.Text = reader["STOCK"].ToString();
                    ProductPB.ImageLocation = reader["PHOTO"].ToString();
                    SoldTB.Text = reader["SOLD"].ToString();

                }
                else
                {
                    MessageBox.Show("Employee Not Found");
                    IdTB.Text = GenerateInventoryId().ToString();

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

        // Photo Import Button
        private void ImportB_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.png|*.jpg;*.png)";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ProductPB.ImageLocation = dialog.FileName;
                    ProductPB.Image = new Bitmap(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CategoryL_Click(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchL_Click(object sender, EventArgs e)
        {

        }

        private void StockTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void StockL_Click(object sender, EventArgs e)
        {

        }

        private void PriceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceL_Click(object sender, EventArgs e)
        {

        }

        private void IdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdL_Click(object sender, EventArgs e)
        {

        }

        private void InventoryListL_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InventoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameL_Click(object sender, EventArgs e)
        {

        }

        private void ProductPB_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddStockTB.Text == "")
            {
                MessageBox.Show("Please enter stock amount");
                return;
            }

            int NewStock = Convert.ToInt32(StockTB.Text.Trim()) + Convert.ToInt32(AddStockTB.Text.Trim());

            StockTB.Text = NewStock.ToString();
            UpdateB.PerformClick();


        }

        private void RefreshB_Click(object sender, EventArgs e)
        {
            ShowInventoryData();
        }
    }
}
