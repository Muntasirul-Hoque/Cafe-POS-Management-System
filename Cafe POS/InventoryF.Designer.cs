namespace Cafe_POS
{
    partial class InventoryF
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameL = new System.Windows.Forms.Label();
            this.RemoveB = new System.Windows.Forms.Button();
            this.UpdateB = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SoldTB = new System.Windows.Forms.TextBox();
            this.SoldL = new System.Windows.Forms.Label();
            this.AddStockTB = new System.Windows.Forms.TextBox();
            this.AddStockL = new System.Windows.Forms.Label();
            this.ClearB = new System.Windows.Forms.Button();
            this.ImportB = new System.Windows.Forms.Button();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.CategoryL = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.SearchL = new System.Windows.Forms.Label();
            this.StockTB = new System.Windows.Forms.TextBox();
            this.StockL = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.PriceL = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.IdL = new System.Windows.Forms.Label();
            this.InventoryListL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductPB = new System.Windows.Forms.PictureBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.RefreshB = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPB)).BeginInit();
            this.SuspendLayout();
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameL.Location = new System.Drawing.Point(51, 65);
            this.NameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(70, 24);
            this.NameL.TabIndex = 19;
            this.NameL.Text = "Name :";
            this.NameL.Click += new System.EventHandler(this.NameL_Click);
            // 
            // RemoveB
            // 
            this.RemoveB.BackColor = System.Drawing.Color.Sienna;
            this.RemoveB.FlatAppearance.BorderSize = 0;
            this.RemoveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveB.Location = new System.Drawing.Point(425, 189);
            this.RemoveB.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveB.Name = "RemoveB";
            this.RemoveB.Size = new System.Drawing.Size(167, 41);
            this.RemoveB.TabIndex = 18;
            this.RemoveB.Text = "REMOVE";
            this.RemoveB.UseVisualStyleBackColor = false;
            this.RemoveB.Click += new System.EventHandler(this.RemoveB_Click);
            // 
            // UpdateB
            // 
            this.UpdateB.BackColor = System.Drawing.Color.Sienna;
            this.UpdateB.FlatAppearance.BorderSize = 0;
            this.UpdateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateB.Location = new System.Drawing.Point(238, 189);
            this.UpdateB.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateB.Name = "UpdateB";
            this.UpdateB.Size = new System.Drawing.Size(167, 41);
            this.UpdateB.TabIndex = 17;
            this.UpdateB.Text = "UPDATE";
            this.UpdateB.UseVisualStyleBackColor = false;
            this.UpdateB.Click += new System.EventHandler(this.UpdateB_Click);
            // 
            // AddB
            // 
            this.AddB.BackColor = System.Drawing.Color.Sienna;
            this.AddB.FlatAppearance.BorderSize = 0;
            this.AddB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddB.Location = new System.Drawing.Point(49, 189);
            this.AddB.Margin = new System.Windows.Forms.Padding(4);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(167, 41);
            this.AddB.TabIndex = 16;
            this.AddB.Text = "ADD";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SoldTB);
            this.panel2.Controls.Add(this.SoldL);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.AddStockTB);
            this.panel2.Controls.Add(this.AddStockL);
            this.panel2.Controls.Add(this.ClearB);
            this.panel2.Controls.Add(this.ImportB);
            this.panel2.Controls.Add(this.ProductPB);
            this.panel2.Controls.Add(this.CategoryCB);
            this.panel2.Controls.Add(this.CategoryL);
            this.panel2.Controls.Add(this.NameTB);
            this.panel2.Controls.Add(this.NameL);
            this.panel2.Controls.Add(this.RemoveB);
            this.panel2.Controls.Add(this.UpdateB);
            this.panel2.Controls.Add(this.AddB);
            this.panel2.Controls.Add(this.SearchB);
            this.panel2.Controls.Add(this.SearchTB);
            this.panel2.Controls.Add(this.SearchL);
            this.panel2.Controls.Add(this.StockTB);
            this.panel2.Controls.Add(this.StockL);
            this.panel2.Controls.Add(this.PriceTB);
            this.panel2.Controls.Add(this.PriceL);
            this.panel2.Controls.Add(this.IdTB);
            this.panel2.Controls.Add(this.IdL);
            this.panel2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(4, 509);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 234);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SoldTB
            // 
            this.SoldTB.BackColor = System.Drawing.Color.Linen;
            this.SoldTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoldTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldTB.Location = new System.Drawing.Point(533, 17);
            this.SoldTB.Margin = new System.Windows.Forms.Padding(4);
            this.SoldTB.Name = "SoldTB";
            this.SoldTB.ReadOnly = true;
            this.SoldTB.Size = new System.Drawing.Size(200, 32);
            this.SoldTB.TabIndex = 31;
            // 
            // SoldL
            // 
            this.SoldL.AutoSize = true;
            this.SoldL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldL.Location = new System.Drawing.Point(459, 21);
            this.SoldL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoldL.Name = "SoldL";
            this.SoldL.Size = new System.Drawing.Size(57, 24);
            this.SoldL.TabIndex = 30;
            this.SoldL.Text = "Sold :";
            // 
            // AddStockTB
            // 
            this.AddStockTB.BackColor = System.Drawing.Color.Linen;
            this.AddStockTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddStockTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockTB.Location = new System.Drawing.Point(533, 105);
            this.AddStockTB.Margin = new System.Windows.Forms.Padding(4);
            this.AddStockTB.Name = "AddStockTB";
            this.AddStockTB.Size = new System.Drawing.Size(200, 32);
            this.AddStockTB.TabIndex = 28;
            // 
            // AddStockL
            // 
            this.AddStockL.AutoSize = true;
            this.AddStockL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockL.Location = new System.Drawing.Point(420, 108);
            this.AddStockL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddStockL.Name = "AddStockL";
            this.AddStockL.Size = new System.Drawing.Size(105, 24);
            this.AddStockL.TabIndex = 27;
            this.AddStockL.Text = "Add Stock :";
            // 
            // ClearB
            // 
            this.ClearB.BackColor = System.Drawing.Color.Sienna;
            this.ClearB.FlatAppearance.BorderSize = 0;
            this.ClearB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearB.Location = new System.Drawing.Point(613, 189);
            this.ClearB.Margin = new System.Windows.Forms.Padding(4);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(167, 41);
            this.ClearB.TabIndex = 26;
            this.ClearB.Text = "CLEAR";
            this.ClearB.UseVisualStyleBackColor = false;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // ImportB
            // 
            this.ImportB.BackColor = System.Drawing.Color.Gray;
            this.ImportB.FlatAppearance.BorderSize = 0;
            this.ImportB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportB.Location = new System.Drawing.Point(878, 148);
            this.ImportB.Margin = new System.Windows.Forms.Padding(4);
            this.ImportB.Name = "ImportB";
            this.ImportB.Size = new System.Drawing.Size(120, 35);
            this.ImportB.TabIndex = 25;
            this.ImportB.Text = "IMPORT";
            this.ImportB.UseVisualStyleBackColor = false;
            this.ImportB.Click += new System.EventHandler(this.ImportB_Click);
            // 
            // CategoryCB
            // 
            this.CategoryCB.BackColor = System.Drawing.Color.Linen;
            this.CategoryCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Items.AddRange(new object[] {
            "Coffee",
            "Tea",
            "Drinks",
            "Smoothie",
            "Bakery"});
            this.CategoryCB.Location = new System.Drawing.Point(129, 107);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(200, 32);
            this.CategoryCB.TabIndex = 22;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // CategoryL
            // 
            this.CategoryL.AutoSize = true;
            this.CategoryL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryL.Location = new System.Drawing.Point(26, 109);
            this.CategoryL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryL.Name = "CategoryL";
            this.CategoryL.Size = new System.Drawing.Size(95, 24);
            this.CategoryL.TabIndex = 21;
            this.CategoryL.Text = "Category :";
            this.CategoryL.Click += new System.EventHandler(this.CategoryL_Click);
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.Color.Linen;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(129, 63);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(200, 32);
            this.NameTB.TabIndex = 20;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // SearchTB
            // 
            this.SearchTB.BackColor = System.Drawing.Color.Linen;
            this.SearchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTB.Location = new System.Drawing.Point(533, 148);
            this.SearchTB.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(200, 32);
            this.SearchTB.TabIndex = 11;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            // 
            // SearchL
            // 
            this.SearchL.AutoSize = true;
            this.SearchL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchL.Location = new System.Drawing.Point(449, 150);
            this.SearchL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchL.Name = "SearchL";
            this.SearchL.Size = new System.Drawing.Size(76, 24);
            this.SearchL.TabIndex = 10;
            this.SearchL.Text = "Search :";
            this.SearchL.Click += new System.EventHandler(this.SearchL_Click);
            // 
            // StockTB
            // 
            this.StockTB.BackColor = System.Drawing.Color.Linen;
            this.StockTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StockTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTB.Location = new System.Drawing.Point(533, 59);
            this.StockTB.Margin = new System.Windows.Forms.Padding(4);
            this.StockTB.Name = "StockTB";
            this.StockTB.Size = new System.Drawing.Size(200, 32);
            this.StockTB.TabIndex = 9;
            this.StockTB.TextChanged += new System.EventHandler(this.StockTB_TextChanged);
            // 
            // StockL
            // 
            this.StockL.AutoSize = true;
            this.StockL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockL.Location = new System.Drawing.Point(459, 63);
            this.StockL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StockL.Name = "StockL";
            this.StockL.Size = new System.Drawing.Size(66, 24);
            this.StockL.TabIndex = 8;
            this.StockL.Text = "Stock :";
            this.StockL.Click += new System.EventHandler(this.StockL_Click);
            // 
            // PriceTB
            // 
            this.PriceTB.BackColor = System.Drawing.Color.Linen;
            this.PriceTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTB.Location = new System.Drawing.Point(129, 146);
            this.PriceTB.Margin = new System.Windows.Forms.Padding(4);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(200, 32);
            this.PriceTB.TabIndex = 7;
            this.PriceTB.TextChanged += new System.EventHandler(this.PriceTB_TextChanged);
            // 
            // PriceL
            // 
            this.PriceL.AutoSize = true;
            this.PriceL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceL.Location = new System.Drawing.Point(59, 148);
            this.PriceL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(62, 24);
            this.PriceL.TabIndex = 6;
            this.PriceL.Text = "Price :";
            this.PriceL.Click += new System.EventHandler(this.PriceL_Click);
            // 
            // IdTB
            // 
            this.IdTB.BackColor = System.Drawing.Color.Linen;
            this.IdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(129, 17);
            this.IdTB.Margin = new System.Windows.Forms.Padding(4);
            this.IdTB.Name = "IdTB";
            this.IdTB.ReadOnly = true;
            this.IdTB.Size = new System.Drawing.Size(200, 32);
            this.IdTB.TabIndex = 5;
            this.IdTB.TextChanged += new System.EventHandler(this.IdTB_TextChanged);
            // 
            // IdL
            // 
            this.IdL.AutoSize = true;
            this.IdL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdL.Location = new System.Drawing.Point(82, 19);
            this.IdL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdL.Name = "IdL";
            this.IdL.Size = new System.Drawing.Size(39, 24);
            this.IdL.TabIndex = 4;
            this.IdL.Text = "ID :";
            this.IdL.Click += new System.EventHandler(this.IdL_Click);
            // 
            // InventoryListL
            // 
            this.InventoryListL.AutoSize = true;
            this.InventoryListL.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryListL.Location = new System.Drawing.Point(25, 5);
            this.InventoryListL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InventoryListL.Name = "InventoryListL";
            this.InventoryListL.Size = new System.Drawing.Size(205, 40);
            this.InventoryListL.TabIndex = 1;
            this.InventoryListL.Text = "Inventory List";
            this.InventoryListL.Click += new System.EventHandler(this.InventoryListL_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.RefreshB);
            this.panel1.Controls.Add(this.InventoryDataGrid);
            this.panel1.Controls.Add(this.InventoryListL);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 501);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.AllowUserToAddRows = false;
            this.InventoryDataGrid.AllowUserToResizeColumns = false;
            this.InventoryDataGrid.AllowUserToResizeRows = false;
            this.InventoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryDataGrid.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGrid.Location = new System.Drawing.Point(5, 50);
            this.InventoryDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.ReadOnly = true;
            this.InventoryDataGrid.RowHeadersWidth = 4;
            this.InventoryDataGrid.Size = new System.Drawing.Size(1068, 447);
            this.InventoryDataGrid.TabIndex = 2;
            this.InventoryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryDataGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Cafe_POS.Properties.Resources.Add;
            this.button1.Location = new System.Drawing.Point(741, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 29;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductPB
            // 
            this.ProductPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPB.Image = global::Cafe_POS.Properties.Resources.Image;
            this.ProductPB.Location = new System.Drawing.Point(878, 17);
            this.ProductPB.Name = "ProductPB";
            this.ProductPB.Size = new System.Drawing.Size(120, 120);
            this.ProductPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPB.TabIndex = 24;
            this.ProductPB.TabStop = false;
            this.ProductPB.Click += new System.EventHandler(this.ProductPB_Click);
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.Transparent;
            this.SearchB.FlatAppearance.BorderSize = 0;
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchB.Image = global::Cafe_POS.Properties.Resources.Search;
            this.SearchB.Location = new System.Drawing.Point(741, 144);
            this.SearchB.Margin = new System.Windows.Forms.Padding(4);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(35, 35);
            this.SearchB.TabIndex = 15;
            this.SearchB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchB.UseVisualStyleBackColor = false;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // RefreshB
            // 
            this.RefreshB.BackColor = System.Drawing.Color.PeachPuff;
            this.RefreshB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshB.ForeColor = System.Drawing.Color.Transparent;
            this.RefreshB.Image = global::Cafe_POS.Properties.Resources.Refresh;
            this.RefreshB.Location = new System.Drawing.Point(1038, 8);
            this.RefreshB.Name = "RefreshB";
            this.RefreshB.Size = new System.Drawing.Size(35, 35);
            this.RefreshB.TabIndex = 26;
            this.RefreshB.UseVisualStyleBackColor = false;
            this.RefreshB.Click += new System.EventHandler(this.RefreshB_Click);
            // 
            // InventoryF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventoryF";
            this.Size = new System.Drawing.Size(1098, 753);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Button RemoveB;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Label SearchL;
        private System.Windows.Forms.TextBox StockTB;
        private System.Windows.Forms.Label StockL;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label PriceL;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label IdL;
        private System.Windows.Forms.Label InventoryListL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView InventoryDataGrid;
        private System.Windows.Forms.Label CategoryL;
        private System.Windows.Forms.Button ImportB;
        private System.Windows.Forms.PictureBox ProductPB;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.TextBox AddStockTB;
        private System.Windows.Forms.Label AddStockL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SoldTB;
        private System.Windows.Forms.Label SoldL;
        private System.Windows.Forms.Button RefreshB;
    }
}
