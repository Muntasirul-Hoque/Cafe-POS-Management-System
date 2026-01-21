namespace Cafe_POS
{
    partial class Order
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
            this.OrderTypeCB = new System.Windows.Forms.ComboBox();
            this.OrderTypeL = new System.Windows.Forms.Label();
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderListL = new System.Windows.Forms.Label();
            this.TotalTB = new System.Windows.Forms.TextBox();
            this.TotalL = new System.Windows.Forms.Label();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.UserIDTB = new System.Windows.Forms.TextBox();
            this.UserIDL = new System.Windows.Forms.Label();
            this.OrderIDTB = new System.Windows.Forms.TextBox();
            this.OrderIdL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateTB = new System.Windows.Forms.DateTimePicker();
            this.ClearB = new System.Windows.Forms.Button();
            this.PaymentTypeCB = new System.Windows.Forms.ComboBox();
            this.PaymentTypeL = new System.Windows.Forms.Label();
            this.OrderDatel = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.UpdateB = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.SearchL = new System.Windows.Forms.Label();
            this.SearchB = new System.Windows.Forms.Button();
            this.RefreshB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderTypeCB
            // 
            this.OrderTypeCB.BackColor = System.Drawing.Color.Linen;
            this.OrderTypeCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTypeCB.FormattingEnabled = true;
            this.OrderTypeCB.Items.AddRange(new object[] {
            "Dine In",
            "Take Away"});
            this.OrderTypeCB.Location = new System.Drawing.Point(143, 107);
            this.OrderTypeCB.Name = "OrderTypeCB";
            this.OrderTypeCB.Size = new System.Drawing.Size(200, 32);
            this.OrderTypeCB.TabIndex = 22;
            // 
            // OrderTypeL
            // 
            this.OrderTypeL.AutoSize = true;
            this.OrderTypeL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTypeL.Location = new System.Drawing.Point(22, 110);
            this.OrderTypeL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderTypeL.Name = "OrderTypeL";
            this.OrderTypeL.Size = new System.Drawing.Size(114, 24);
            this.OrderTypeL.TabIndex = 21;
            this.OrderTypeL.Text = "Order Type :";
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.AllowUserToAddRows = false;
            this.OrderDataGrid.AllowUserToDeleteRows = false;
            this.OrderDataGrid.AllowUserToOrderColumns = true;
            this.OrderDataGrid.AllowUserToResizeColumns = false;
            this.OrderDataGrid.AllowUserToResizeRows = false;
            this.OrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDataGrid.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDataGrid.Location = new System.Drawing.Point(5, 50);
            this.OrderDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.ReadOnly = true;
            this.OrderDataGrid.RowHeadersWidth = 4;
            this.OrderDataGrid.Size = new System.Drawing.Size(1068, 447);
            this.OrderDataGrid.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.RefreshB);
            this.panel1.Controls.Add(this.OrderDataGrid);
            this.panel1.Controls.Add(this.OrderListL);
            this.panel1.Location = new System.Drawing.Point(10, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 501);
            this.panel1.TabIndex = 6;
            // 
            // OrderListL
            // 
            this.OrderListL.AutoSize = true;
            this.OrderListL.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderListL.Location = new System.Drawing.Point(25, 5);
            this.OrderListL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderListL.Name = "OrderListL";
            this.OrderListL.Size = new System.Drawing.Size(151, 40);
            this.OrderListL.TabIndex = 1;
            this.OrderListL.Text = "Order List";
            // 
            // TotalTB
            // 
            this.TotalTB.BackColor = System.Drawing.Color.Linen;
            this.TotalTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTB.Location = new System.Drawing.Point(143, 63);
            this.TotalTB.Margin = new System.Windows.Forms.Padding(4);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(200, 32);
            this.TotalTB.TabIndex = 20;
            // 
            // TotalL
            // 
            this.TotalL.AutoSize = true;
            this.TotalL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalL.Location = new System.Drawing.Point(73, 67);
            this.TotalL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalL.Name = "TotalL";
            this.TotalL.Size = new System.Drawing.Size(62, 24);
            this.TotalL.TabIndex = 19;
            this.TotalL.Text = "Total :";
            this.TotalL.Click += new System.EventHandler(this.NameL_Click);
            // 
            // SearchTB
            // 
            this.SearchTB.BackColor = System.Drawing.Color.Linen;
            this.SearchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTB.Location = new System.Drawing.Point(533, 108);
            this.SearchTB.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(200, 32);
            this.SearchTB.TabIndex = 11;
            // 
            // UserIDTB
            // 
            this.UserIDTB.BackColor = System.Drawing.Color.Linen;
            this.UserIDTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserIDTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDTB.Location = new System.Drawing.Point(533, 17);
            this.UserIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.UserIDTB.Name = "UserIDTB";
            this.UserIDTB.Size = new System.Drawing.Size(200, 32);
            this.UserIDTB.TabIndex = 7;
            // 
            // UserIDL
            // 
            this.UserIDL.AutoSize = true;
            this.UserIDL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDL.Location = new System.Drawing.Point(443, 21);
            this.UserIDL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserIDL.Name = "UserIDL";
            this.UserIDL.Size = new System.Drawing.Size(82, 24);
            this.UserIDL.TabIndex = 6;
            this.UserIDL.Text = "User ID :";
            // 
            // OrderIDTB
            // 
            this.OrderIDTB.BackColor = System.Drawing.Color.Linen;
            this.OrderIDTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderIDTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDTB.Location = new System.Drawing.Point(143, 17);
            this.OrderIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.OrderIDTB.Name = "OrderIDTB";
            this.OrderIDTB.Size = new System.Drawing.Size(200, 32);
            this.OrderIDTB.TabIndex = 5;
            // 
            // OrderIdL
            // 
            this.OrderIdL.AutoSize = true;
            this.OrderIdL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdL.Location = new System.Drawing.Point(43, 19);
            this.OrderIdL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderIdL.Name = "OrderIdL";
            this.OrderIdL.Size = new System.Drawing.Size(93, 24);
            this.OrderIdL.TabIndex = 4;
            this.OrderIdL.Text = "Order ID :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DateTB);
            this.panel2.Controls.Add(this.ClearB);
            this.panel2.Controls.Add(this.PaymentTypeCB);
            this.panel2.Controls.Add(this.PaymentTypeL);
            this.panel2.Controls.Add(this.OrderDatel);
            this.panel2.Controls.Add(this.OrderTypeCB);
            this.panel2.Controls.Add(this.OrderTypeL);
            this.panel2.Controls.Add(this.TotalTB);
            this.panel2.Controls.Add(this.TotalL);
            this.panel2.Controls.Add(this.Remove);
            this.panel2.Controls.Add(this.UpdateB);
            this.panel2.Controls.Add(this.AddB);
            this.panel2.Controls.Add(this.SearchB);
            this.panel2.Controls.Add(this.SearchTB);
            this.panel2.Controls.Add(this.SearchL);
            this.panel2.Controls.Add(this.UserIDTB);
            this.panel2.Controls.Add(this.UserIDL);
            this.panel2.Controls.Add(this.OrderIDTB);
            this.panel2.Controls.Add(this.OrderIdL);
            this.panel2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(10, 512);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 234);
            this.panel2.TabIndex = 7;
            // 
            // DateTB
            // 
            this.DateTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTB.Location = new System.Drawing.Point(143, 148);
            this.DateTB.Name = "DateTB";
            this.DateTB.Size = new System.Drawing.Size(200, 32);
            this.DateTB.TabIndex = 28;
            // 
            // ClearB
            // 
            this.ClearB.BackColor = System.Drawing.Color.Sienna;
            this.ClearB.FlatAppearance.BorderSize = 0;
            this.ClearB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearB.Location = new System.Drawing.Point(868, 172);
            this.ClearB.Margin = new System.Windows.Forms.Padding(4);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(167, 41);
            this.ClearB.TabIndex = 27;
            this.ClearB.Text = "CLEARE";
            this.ClearB.UseVisualStyleBackColor = false;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // PaymentTypeCB
            // 
            this.PaymentTypeCB.BackColor = System.Drawing.Color.Linen;
            this.PaymentTypeCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeCB.FormattingEnabled = true;
            this.PaymentTypeCB.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Bangla QR"});
            this.PaymentTypeCB.Location = new System.Drawing.Point(533, 64);
            this.PaymentTypeCB.Name = "PaymentTypeCB";
            this.PaymentTypeCB.Size = new System.Drawing.Size(200, 32);
            this.PaymentTypeCB.TabIndex = 26;
            // 
            // PaymentTypeL
            // 
            this.PaymentTypeL.AutoSize = true;
            this.PaymentTypeL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeL.Location = new System.Drawing.Point(386, 67);
            this.PaymentTypeL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaymentTypeL.Name = "PaymentTypeL";
            this.PaymentTypeL.Size = new System.Drawing.Size(139, 24);
            this.PaymentTypeL.TabIndex = 25;
            this.PaymentTypeL.Text = "Payment Type :";
            // 
            // OrderDatel
            // 
            this.OrderDatel.AutoSize = true;
            this.OrderDatel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDatel.Location = new System.Drawing.Point(21, 153);
            this.OrderDatel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderDatel.Name = "OrderDatel";
            this.OrderDatel.Size = new System.Drawing.Size(115, 24);
            this.OrderDatel.TabIndex = 23;
            this.OrderDatel.Text = "Order Date :";
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Sienna;
            this.Remove.FlatAppearance.BorderSize = 0;
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Location = new System.Drawing.Point(868, 121);
            this.Remove.Margin = new System.Windows.Forms.Padding(4);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(167, 41);
            this.Remove.TabIndex = 18;
            this.Remove.Text = "REMOVE";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // UpdateB
            // 
            this.UpdateB.BackColor = System.Drawing.Color.Sienna;
            this.UpdateB.FlatAppearance.BorderSize = 0;
            this.UpdateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateB.Location = new System.Drawing.Point(868, 70);
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
            this.AddB.Location = new System.Drawing.Point(868, 19);
            this.AddB.Margin = new System.Windows.Forms.Padding(4);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(167, 41);
            this.AddB.TabIndex = 16;
            this.AddB.Text = "ADD";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // SearchL
            // 
            this.SearchL.AutoSize = true;
            this.SearchL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchL.Location = new System.Drawing.Point(449, 110);
            this.SearchL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchL.Name = "SearchL";
            this.SearchL.Size = new System.Drawing.Size(76, 24);
            this.SearchL.TabIndex = 10;
            this.SearchL.Text = "Search :";
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.Transparent;
            this.SearchB.FlatAppearance.BorderSize = 0;
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchB.Image = global::Cafe_POS.Properties.Resources.Search;
            this.SearchB.Location = new System.Drawing.Point(741, 107);
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
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1098, 753);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox OrderTypeCB;
        private System.Windows.Forms.Label OrderTypeL;
        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OrderListL;
        private System.Windows.Forms.TextBox TotalTB;
        private System.Windows.Forms.Label TotalL;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.TextBox UserIDTB;
        private System.Windows.Forms.Label UserIDL;
        private System.Windows.Forms.TextBox OrderIDTB;
        private System.Windows.Forms.Label OrderIdL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Label SearchL;
        private System.Windows.Forms.Label OrderDatel;
        private System.Windows.Forms.ComboBox PaymentTypeCB;
        private System.Windows.Forms.Label PaymentTypeL;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.DateTimePicker DateTB;
        private System.Windows.Forms.Button RefreshB;
    }
}
