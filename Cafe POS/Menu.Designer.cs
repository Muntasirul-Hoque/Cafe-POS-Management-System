namespace Cafe_POS
{
    partial class Menu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ShopNameL = new System.Windows.Forms.Label();
            this.CatagoryP = new System.Windows.Forms.Panel();
            this.BakeryB = new System.Windows.Forms.Button();
            this.SmoothieB = new System.Windows.Forms.Button();
            this.DrinksB = new System.Windows.Forms.Button();
            this.TeaB = new System.Windows.Forms.Button();
            this.CoffeeB = new System.Windows.Forms.Button();
            this.PaymentP = new System.Windows.Forms.Panel();
            this.CancleB = new System.Windows.Forms.Button();
            this.LogOutB = new System.Windows.Forms.Button();
            this.PaidTB = new System.Windows.Forms.TextBox();
            this.DiscountCB = new System.Windows.Forms.ComboBox();
            this.DiscountL = new System.Windows.Forms.Label();
            this.OrderTypeCB = new System.Windows.Forms.ComboBox();
            this.OrderTypeL = new System.Windows.Forms.Label();
            this.BackB = new System.Windows.Forms.Button();
            this.PrintB = new System.Windows.Forms.Button();
            this.PaidL = new System.Windows.Forms.Label();
            this.PayTypeCB = new System.Windows.Forms.ComboBox();
            this.PayType2L = new System.Windows.Forms.Label();
            this.ChangeTB = new System.Windows.Forms.TextBox();
            this.ChangeL = new System.Windows.Forms.Label();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.TotalL = new System.Windows.Forms.Label();
            this.TaxTB = new System.Windows.Forms.TextBox();
            this.TaxRateL = new System.Windows.Forms.Label();
            this.SubTotalTB = new System.Windows.Forms.TextBox();
            this.SubTotalL = new System.Windows.Forms.Label();
            this.OrderIDTB = new System.Windows.Forms.TextBox();
            this.OrderIDL = new System.Windows.Forms.Label();
            this.OrderSummaryL = new System.Windows.Forms.Label();
            this.UserIDL = new System.Windows.Forms.Label();
            this.UserIDTB = new System.Windows.Forms.TextBox();
            this.ItemLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.CartList = new System.Windows.Forms.DataGridView();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.LogoPB = new System.Windows.Forms.PictureBox();
            this.CatagoryP.SuspendLayout();
            this.PaymentP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopNameL
            // 
            this.ShopNameL.AutoSize = true;
            this.ShopNameL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopNameL.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ShopNameL.Location = new System.Drawing.Point(447, 12);
            this.ShopNameL.Name = "ShopNameL";
            this.ShopNameL.Size = new System.Drawing.Size(417, 54);
            this.ShopNameL.TabIndex = 0;
            this.ShopNameL.Text = "Urban Brew Café";
            // 
            // CatagoryP
            // 
            this.CatagoryP.BackColor = System.Drawing.Color.Transparent;
            this.CatagoryP.Controls.Add(this.BakeryB);
            this.CatagoryP.Controls.Add(this.SmoothieB);
            this.CatagoryP.Controls.Add(this.DrinksB);
            this.CatagoryP.Controls.Add(this.TeaB);
            this.CatagoryP.Controls.Add(this.CoffeeB);
            this.CatagoryP.Location = new System.Drawing.Point(9, 70);
            this.CatagoryP.Name = "CatagoryP";
            this.CatagoryP.Size = new System.Drawing.Size(201, 682);
            this.CatagoryP.TabIndex = 3;
            // 
            // BakeryB
            // 
            this.BakeryB.BackColor = System.Drawing.Color.PeachPuff;
            this.BakeryB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BakeryB.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakeryB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BakeryB.Image = global::Cafe_POS.Properties.Resources.Bakery;
            this.BakeryB.Location = new System.Drawing.Point(26, 540);
            this.BakeryB.Name = "BakeryB";
            this.BakeryB.Size = new System.Drawing.Size(175, 120);
            this.BakeryB.TabIndex = 4;
            this.BakeryB.Text = "Bakery";
            this.BakeryB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BakeryB.UseVisualStyleBackColor = false;
            this.BakeryB.Click += new System.EventHandler(this.BakeryB_Click);
            // 
            // SmoothieB
            // 
            this.SmoothieB.BackColor = System.Drawing.Color.PeachPuff;
            this.SmoothieB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SmoothieB.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmoothieB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SmoothieB.Image = global::Cafe_POS.Properties.Resources.Smoothie;
            this.SmoothieB.Location = new System.Drawing.Point(26, 405);
            this.SmoothieB.Name = "SmoothieB";
            this.SmoothieB.Size = new System.Drawing.Size(175, 120);
            this.SmoothieB.TabIndex = 3;
            this.SmoothieB.Text = "Smoothie";
            this.SmoothieB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SmoothieB.UseVisualStyleBackColor = false;
            this.SmoothieB.Click += new System.EventHandler(this.SmoothieB_Click);
            // 
            // DrinksB
            // 
            this.DrinksB.BackColor = System.Drawing.Color.PeachPuff;
            this.DrinksB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DrinksB.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinksB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DrinksB.Image = global::Cafe_POS.Properties.Resources.Drinks;
            this.DrinksB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DrinksB.Location = new System.Drawing.Point(26, 270);
            this.DrinksB.Name = "DrinksB";
            this.DrinksB.Size = new System.Drawing.Size(175, 120);
            this.DrinksB.TabIndex = 2;
            this.DrinksB.Text = "Drinks";
            this.DrinksB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DrinksB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DrinksB.UseVisualStyleBackColor = false;
            this.DrinksB.Click += new System.EventHandler(this.DrinksB_Click);
            // 
            // TeaB
            // 
            this.TeaB.BackColor = System.Drawing.Color.PeachPuff;
            this.TeaB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TeaB.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeaB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TeaB.Image = global::Cafe_POS.Properties.Resources.Tea;
            this.TeaB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TeaB.Location = new System.Drawing.Point(26, 135);
            this.TeaB.Name = "TeaB";
            this.TeaB.Size = new System.Drawing.Size(175, 120);
            this.TeaB.TabIndex = 1;
            this.TeaB.Text = "Tea";
            this.TeaB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TeaB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TeaB.UseVisualStyleBackColor = false;
            this.TeaB.Click += new System.EventHandler(this.TeaB_Click);
            // 
            // CoffeeB
            // 
            this.CoffeeB.BackColor = System.Drawing.Color.PeachPuff;
            this.CoffeeB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CoffeeB.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoffeeB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CoffeeB.Image = global::Cafe_POS.Properties.Resources.Coffee;
            this.CoffeeB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CoffeeB.Location = new System.Drawing.Point(26, 0);
            this.CoffeeB.Margin = new System.Windows.Forms.Padding(0);
            this.CoffeeB.Name = "CoffeeB";
            this.CoffeeB.Size = new System.Drawing.Size(175, 120);
            this.CoffeeB.TabIndex = 0;
            this.CoffeeB.Text = "Coffee";
            this.CoffeeB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CoffeeB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CoffeeB.UseVisualStyleBackColor = false;
            this.CoffeeB.Click += new System.EventHandler(this.CoffeeB_Click);
            // 
            // PaymentP
            // 
            this.PaymentP.BackColor = System.Drawing.Color.Transparent;
            this.PaymentP.Controls.Add(this.CancleB);
            this.PaymentP.Controls.Add(this.LogOutB);
            this.PaymentP.Controls.Add(this.PaidTB);
            this.PaymentP.Controls.Add(this.DiscountCB);
            this.PaymentP.Controls.Add(this.DiscountL);
            this.PaymentP.Controls.Add(this.OrderTypeCB);
            this.PaymentP.Controls.Add(this.OrderTypeL);
            this.PaymentP.Controls.Add(this.BackB);
            this.PaymentP.Controls.Add(this.PrintB);
            this.PaymentP.Controls.Add(this.PaidL);
            this.PaymentP.Controls.Add(this.PayTypeCB);
            this.PaymentP.Controls.Add(this.PayType2L);
            this.PaymentP.Controls.Add(this.ChangeTB);
            this.PaymentP.Controls.Add(this.ChangeL);
            this.PaymentP.Controls.Add(this.TotalTB);
            this.PaymentP.Controls.Add(this.TotalL);
            this.PaymentP.Controls.Add(this.TaxTB);
            this.PaymentP.Controls.Add(this.TaxRateL);
            this.PaymentP.Controls.Add(this.SubTotalTB);
            this.PaymentP.Controls.Add(this.SubTotalL);
            this.PaymentP.Controls.Add(this.OrderIDTB);
            this.PaymentP.Controls.Add(this.OrderIDL);
            this.PaymentP.Controls.Add(this.OrderSummaryL);
            this.PaymentP.Location = new System.Drawing.Point(555, 70);
            this.PaymentP.Name = "PaymentP";
            this.PaymentP.Size = new System.Drawing.Size(306, 682);
            this.PaymentP.TabIndex = 6;
            // 
            // CancleB
            // 
            this.CancleB.BackColor = System.Drawing.Color.SaddleBrown;
            this.CancleB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancleB.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancleB.Image = global::Cafe_POS.Properties.Resources.Cancel;
            this.CancleB.Location = new System.Drawing.Point(7, 486);
            this.CancleB.Margin = new System.Windows.Forms.Padding(0);
            this.CancleB.Name = "CancleB";
            this.CancleB.Size = new System.Drawing.Size(134, 60);
            this.CancleB.TabIndex = 51;
            this.CancleB.Text = "Cancel";
            this.CancleB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancleB.UseVisualStyleBackColor = false;
            this.CancleB.Click += new System.EventHandler(this.CancleB_Click);
            // 
            // LogOutB
            // 
            this.LogOutB.BackColor = System.Drawing.Color.SaddleBrown;
            this.LogOutB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOutB.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutB.Image = global::Cafe_POS.Properties.Resources.LogOut;
            this.LogOutB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutB.Location = new System.Drawing.Point(166, 571);
            this.LogOutB.Margin = new System.Windows.Forms.Padding(0);
            this.LogOutB.Name = "LogOutB";
            this.LogOutB.Size = new System.Drawing.Size(134, 60);
            this.LogOutB.TabIndex = 50;
            this.LogOutB.Text = "Log Out";
            this.LogOutB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LogOutB.UseVisualStyleBackColor = false;
            this.LogOutB.Click += new System.EventHandler(this.LogOutB_Click);
            // 
            // PaidTB
            // 
            this.PaidTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaidTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PaidTB.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidTB.Location = new System.Drawing.Point(139, 327);
            this.PaidTB.Name = "PaidTB";
            this.PaidTB.Size = new System.Drawing.Size(136, 29);
            this.PaidTB.TabIndex = 48;
            this.PaidTB.TextChanged += new System.EventHandler(this.PaidTB_TextChanged);
            // 
            // DiscountCB
            // 
            this.DiscountCB.BackColor = System.Drawing.Color.Linen;
            this.DiscountCB.DisplayMember = "5";
            this.DiscountCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiscountCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountCB.FormattingEnabled = true;
            this.DiscountCB.Items.AddRange(new object[] {
            "0",
            "5",
            "10"});
            this.DiscountCB.Location = new System.Drawing.Point(139, 287);
            this.DiscountCB.Name = "DiscountCB";
            this.DiscountCB.Size = new System.Drawing.Size(136, 32);
            this.DiscountCB.TabIndex = 47;
            this.DiscountCB.SelectedIndexChanged += new System.EventHandler(this.DiscountCB_SelectedIndexChanged);
            this.DiscountCB.SelectedValueChanged += new System.EventHandler(this.DiscountCB_SelectedValueChanged);
            // 
            // DiscountL
            // 
            this.DiscountL.AutoSize = true;
            this.DiscountL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountL.Location = new System.Drawing.Point(12, 287);
            this.DiscountL.Name = "DiscountL";
            this.DiscountL.Size = new System.Drawing.Size(84, 24);
            this.DiscountL.TabIndex = 46;
            this.DiscountL.Text = "Discount";
            // 
            // OrderTypeCB
            // 
            this.OrderTypeCB.BackColor = System.Drawing.Color.Linen;
            this.OrderTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderTypeCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTypeCB.FormattingEnabled = true;
            this.OrderTypeCB.Items.AddRange(new object[] {
            "Dine In",
            "Take Away"});
            this.OrderTypeCB.Location = new System.Drawing.Point(139, 213);
            this.OrderTypeCB.Name = "OrderTypeCB";
            this.OrderTypeCB.Size = new System.Drawing.Size(136, 32);
            this.OrderTypeCB.TabIndex = 45;
            // 
            // OrderTypeL
            // 
            this.OrderTypeL.AutoSize = true;
            this.OrderTypeL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTypeL.Location = new System.Drawing.Point(12, 216);
            this.OrderTypeL.Name = "OrderTypeL";
            this.OrderTypeL.Size = new System.Drawing.Size(103, 24);
            this.OrderTypeL.TabIndex = 44;
            this.OrderTypeL.Text = "Order Type";
            // 
            // BackB
            // 
            this.BackB.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackB.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackB.Image = global::Cafe_POS.Properties.Resources.Next;
            this.BackB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackB.Location = new System.Drawing.Point(7, 571);
            this.BackB.Margin = new System.Windows.Forms.Padding(0);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(134, 60);
            this.BackB.TabIndex = 41;
            this.BackB.Text = "Back";
            this.BackB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BackB.UseVisualStyleBackColor = false;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // PrintB
            // 
            this.PrintB.BackColor = System.Drawing.Color.SaddleBrown;
            this.PrintB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrintB.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintB.Image = global::Cafe_POS.Properties.Resources.Print;
            this.PrintB.Location = new System.Drawing.Point(166, 486);
            this.PrintB.Margin = new System.Windows.Forms.Padding(0);
            this.PrintB.Name = "PrintB";
            this.PrintB.Size = new System.Drawing.Size(134, 60);
            this.PrintB.TabIndex = 38;
            this.PrintB.Text = "Print";
            this.PrintB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintB.UseVisualStyleBackColor = false;
            this.PrintB.Click += new System.EventHandler(this.PrintB_Click);
            // 
            // PaidL
            // 
            this.PaidL.AutoSize = true;
            this.PaidL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidL.Location = new System.Drawing.Point(67, 325);
            this.PaidL.Name = "PaidL";
            this.PaidL.Size = new System.Drawing.Size(65, 35);
            this.PaidL.TabIndex = 36;
            this.PaidL.Text = "Paid";
            // 
            // PayTypeCB
            // 
            this.PayTypeCB.BackColor = System.Drawing.Color.Linen;
            this.PayTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PayTypeCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayTypeCB.FormattingEnabled = true;
            this.PayTypeCB.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Bangla QR"});
            this.PayTypeCB.Location = new System.Drawing.Point(139, 250);
            this.PayTypeCB.Name = "PayTypeCB";
            this.PayTypeCB.Size = new System.Drawing.Size(136, 32);
            this.PayTypeCB.TabIndex = 35;
            // 
            // PayType2L
            // 
            this.PayType2L.AutoSize = true;
            this.PayType2L.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayType2L.Location = new System.Drawing.Point(12, 253);
            this.PayType2L.Name = "PayType2L";
            this.PayType2L.Size = new System.Drawing.Size(128, 24);
            this.PayType2L.TabIndex = 34;
            this.PayType2L.Text = "Payment Type";
            // 
            // ChangeTB
            // 
            this.ChangeTB.BackColor = System.Drawing.Color.Linen;
            this.ChangeTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ChangeTB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTB.Location = new System.Drawing.Point(139, 181);
            this.ChangeTB.Multiline = true;
            this.ChangeTB.Name = "ChangeTB";
            this.ChangeTB.ReadOnly = true;
            this.ChangeTB.Size = new System.Drawing.Size(136, 25);
            this.ChangeTB.TabIndex = 28;
            this.ChangeTB.Text = "0";
            // 
            // ChangeL
            // 
            this.ChangeL.AutoSize = true;
            this.ChangeL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeL.Location = new System.Drawing.Point(26, 182);
            this.ChangeL.Name = "ChangeL";
            this.ChangeL.Size = new System.Drawing.Size(106, 21);
            this.ChangeL.TabIndex = 27;
            this.ChangeL.Text = "Change           ";
            // 
            // TotalTB
            // 
            this.TotalTB.BackColor = System.Drawing.Color.Linen;
            this.TotalTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TotalTB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTB.Location = new System.Drawing.Point(139, 149);
            this.TotalTB.Multiline = true;
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.ReadOnly = true;
            this.TotalTB.Size = new System.Drawing.Size(136, 25);
            this.TotalTB.TabIndex = 24;
            this.TotalTB.Text = "0";
            // 
            // TotalL
            // 
            this.TotalL.AutoSize = true;
            this.TotalL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalL.Location = new System.Drawing.Point(26, 148);
            this.TotalL.Name = "TotalL";
            this.TotalL.Size = new System.Drawing.Size(44, 21);
            this.TotalL.TabIndex = 23;
            this.TotalL.Text = "Total";
            // 
            // TaxTB
            // 
            this.TaxTB.BackColor = System.Drawing.Color.Linen;
            this.TaxTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaxTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TaxTB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTB.Location = new System.Drawing.Point(139, 117);
            this.TaxTB.Multiline = true;
            this.TaxTB.Name = "TaxTB";
            this.TaxTB.ReadOnly = true;
            this.TaxTB.Size = new System.Drawing.Size(136, 25);
            this.TaxTB.TabIndex = 22;
            this.TaxTB.Text = "0";
            // 
            // TaxRateL
            // 
            this.TaxRateL.AutoSize = true;
            this.TaxRateL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxRateL.Location = new System.Drawing.Point(26, 118);
            this.TaxRateL.Name = "TaxRateL";
            this.TaxRateL.Size = new System.Drawing.Size(70, 21);
            this.TaxRateL.TabIndex = 21;
            this.TaxRateL.Text = "Tax Rate";
            // 
            // SubTotalTB
            // 
            this.SubTotalTB.BackColor = System.Drawing.Color.Linen;
            this.SubTotalTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubTotalTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SubTotalTB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTB.Location = new System.Drawing.Point(139, 85);
            this.SubTotalTB.Multiline = true;
            this.SubTotalTB.Name = "SubTotalTB";
            this.SubTotalTB.ReadOnly = true;
            this.SubTotalTB.Size = new System.Drawing.Size(136, 25);
            this.SubTotalTB.TabIndex = 20;
            this.SubTotalTB.Text = "0";
            // 
            // SubTotalL
            // 
            this.SubTotalL.AutoSize = true;
            this.SubTotalL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalL.Location = new System.Drawing.Point(26, 88);
            this.SubTotalL.Name = "SubTotalL";
            this.SubTotalL.Size = new System.Drawing.Size(74, 21);
            this.SubTotalL.TabIndex = 19;
            this.SubTotalL.Text = "Sub Total";
            // 
            // OrderIDTB
            // 
            this.OrderIDTB.BackColor = System.Drawing.Color.Linen;
            this.OrderIDTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderIDTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OrderIDTB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDTB.Location = new System.Drawing.Point(139, 53);
            this.OrderIDTB.Multiline = true;
            this.OrderIDTB.Name = "OrderIDTB";
            this.OrderIDTB.ReadOnly = true;
            this.OrderIDTB.Size = new System.Drawing.Size(136, 25);
            this.OrderIDTB.TabIndex = 16;
            // 
            // OrderIDL
            // 
            this.OrderIDL.AutoSize = true;
            this.OrderIDL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDL.Location = new System.Drawing.Point(26, 58);
            this.OrderIDL.Name = "OrderIDL";
            this.OrderIDL.Size = new System.Drawing.Size(72, 21);
            this.OrderIDL.TabIndex = 15;
            this.OrderIDL.Text = "Order ID";
            // 
            // OrderSummaryL
            // 
            this.OrderSummaryL.AutoSize = true;
            this.OrderSummaryL.BackColor = System.Drawing.Color.PeachPuff;
            this.OrderSummaryL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderSummaryL.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSummaryL.ForeColor = System.Drawing.Color.Black;
            this.OrderSummaryL.Location = new System.Drawing.Point(75, 17);
            this.OrderSummaryL.Name = "OrderSummaryL";
            this.OrderSummaryL.Size = new System.Drawing.Size(161, 30);
            this.OrderSummaryL.TabIndex = 14;
            this.OrderSummaryL.Text = "OrderSummary";
            // 
            // UserIDL
            // 
            this.UserIDL.AutoSize = true;
            this.UserIDL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDL.Location = new System.Drawing.Point(976, 38);
            this.UserIDL.Name = "UserIDL";
            this.UserIDL.Size = new System.Drawing.Size(77, 24);
            this.UserIDL.TabIndex = 12;
            this.UserIDL.Text = "User ID:";
            // 
            // UserIDTB
            // 
            this.UserIDTB.BackColor = System.Drawing.Color.Linen;
            this.UserIDTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserIDTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UserIDTB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDTB.Location = new System.Drawing.Point(1061, 40);
            this.UserIDTB.Multiline = true;
            this.UserIDTB.Name = "UserIDTB";
            this.UserIDTB.ReadOnly = true;
            this.UserIDTB.Size = new System.Drawing.Size(136, 22);
            this.UserIDTB.TabIndex = 13;
            // 
            // ItemLayout
            // 
            this.ItemLayout.Location = new System.Drawing.Point(214, 70);
            this.ItemLayout.Name = "ItemLayout";
            this.ItemLayout.Size = new System.Drawing.Size(337, 682);
            this.ItemLayout.TabIndex = 14;
            // 
            // CartList
            // 
            this.CartList.AllowUserToAddRows = false;
            this.CartList.AllowUserToDeleteRows = false;
            this.CartList.AllowUserToResizeColumns = false;
            this.CartList.AllowUserToResizeRows = false;
            this.CartList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNo,
            this.colName,
            this.colPrice,
            this.colQuantity,
            this.colTotal});
            this.CartList.Location = new System.Drawing.Point(867, 70);
            this.CartList.Name = "CartList";
            this.CartList.RowHeadersWidth = 4;
            this.CartList.RowTemplate.Height = 24;
            this.CartList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartList.Size = new System.Drawing.Size(332, 682);
            this.CartList.TabIndex = 15;
            // 
            // ItemNo
            // 
            this.ItemNo.HeaderText = "No";
            this.ItemNo.MinimumWidth = 6;
            this.ItemNo.Name = "ItemNo";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "  ";
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // LogoPB
            // 
            this.LogoPB.Image = global::Cafe_POS.Properties.Resources.Logo;
            this.LogoPB.Location = new System.Drawing.Point(385, 10);
            this.LogoPB.Name = "LogoPB";
            this.LogoPB.Size = new System.Drawing.Size(52, 60);
            this.LogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPB.TabIndex = 2;
            this.LogoPB.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1209, 753);
            this.Controls.Add(this.CartList);
            this.Controls.Add(this.ItemLayout);
            this.Controls.Add(this.PaymentP);
            this.Controls.Add(this.CatagoryP);
            this.Controls.Add(this.LogoPB);
            this.Controls.Add(this.ShopNameL);
            this.Controls.Add(this.UserIDTB);
            this.Controls.Add(this.UserIDL);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.CatagoryP.ResumeLayout(false);
            this.PaymentP.ResumeLayout(false);
            this.PaymentP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShopNameL;
        private System.Windows.Forms.PictureBox LogoPB;
        private System.Windows.Forms.Panel CatagoryP;
        private System.Windows.Forms.Button BakeryB;
        private System.Windows.Forms.Button SmoothieB;
        private System.Windows.Forms.Button DrinksB;
        private System.Windows.Forms.Button TeaB;
        private System.Windows.Forms.Panel PaymentP;
        private System.Windows.Forms.Button CoffeeB;
        private System.Windows.Forms.Label OrderSummaryL;
        private System.Windows.Forms.TextBox ChangeTB;
        private System.Windows.Forms.Label ChangeL;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Label TotalL;
        private System.Windows.Forms.TextBox TaxTB;
        private System.Windows.Forms.Label TaxRateL;
        private System.Windows.Forms.TextBox SubTotalTB;
        private System.Windows.Forms.Label SubTotalL;
        private System.Windows.Forms.TextBox OrderIDTB;
        private System.Windows.Forms.Label OrderIDL;
        private System.Windows.Forms.Label UserIDL;
        private System.Windows.Forms.TextBox UserIDTB;
        private System.Windows.Forms.Label PaidL;
        private System.Windows.Forms.ComboBox PayTypeCB;
        private System.Windows.Forms.Label PayType2L;
        private System.Windows.Forms.Button PrintB;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.ComboBox DiscountCB;
        private System.Windows.Forms.Label DiscountL;
        private System.Windows.Forms.ComboBox OrderTypeCB;
        private System.Windows.Forms.Label OrderTypeL;
        private System.Windows.Forms.TextBox PaidTB;
        private System.Windows.Forms.Button LogOutB;
        private System.Windows.Forms.Button CancleB;
        private System.Windows.Forms.FlowLayoutPanel ItemLayout;
        private System.Windows.Forms.DataGridView CartList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}