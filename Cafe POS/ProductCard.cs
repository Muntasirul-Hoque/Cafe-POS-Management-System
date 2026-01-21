using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_POS
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public string ID { get; set; }
        public string Name
        {
            set { ProductNameL.Text = value; }
            get { return ProductNameL.Text; }
        }
        public string Price {
            set { PriceL.Text = value; }
            get { return PriceL.Text; }
        }
        public string Category { get; set; }
        
        public string Photo {
            set { ProductPB.ImageLocation = value; }
            get { return ProductPB.ImageLocation; }
        }
       
        public int Quantity {
            set { QuentityB.Value = value; }
            get { return (int)QuentityB.Value; }
        }
        public int Stock
        {
            set { StockQYTL.Text = value.ToString(); }
            get { return Convert.ToInt32(StockQYTL.Text); }
        }


        public event EventHandler selected = null;

        private void AddButton_Click(object sender, EventArgs e)
        {
            selected?.Invoke(this, EventArgs.Empty);
        }
    }
}
