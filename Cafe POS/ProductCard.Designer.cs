namespace Cafe_POS
{
    partial class ProductCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductPB = new System.Windows.Forms.PictureBox();
            this.ProductNameL = new System.Windows.Forms.Label();
            this.StockL = new System.Windows.Forms.Label();
            this.QuantityL = new System.Windows.Forms.Label();
            this.QuentityB = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.PriceL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StockQYTL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuentityB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProductPB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ProductPB
            // 
            this.ProductPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductPB.Location = new System.Drawing.Point(0, 0);
            this.ProductPB.Name = "ProductPB";
            this.ProductPB.Size = new System.Drawing.Size(150, 100);
            this.ProductPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPB.TabIndex = 0;
            this.ProductPB.TabStop = false;
            // 
            // ProductNameL
            // 
            this.ProductNameL.AutoSize = true;
            this.ProductNameL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameL.Location = new System.Drawing.Point(9, 99);
            this.ProductNameL.Name = "ProductNameL";
            this.ProductNameL.Size = new System.Drawing.Size(130, 24);
            this.ProductNameL.TabIndex = 2;
            this.ProductNameL.Text = "Product Name";
            // 
            // StockL
            // 
            this.StockL.AutoSize = true;
            this.StockL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockL.Location = new System.Drawing.Point(3, 149);
            this.StockL.Name = "StockL";
            this.StockL.Size = new System.Drawing.Size(54, 24);
            this.StockL.TabIndex = 3;
            this.StockL.Text = "Stock";
            // 
            // QuantityL
            // 
            this.QuantityL.AutoSize = true;
            this.QuantityL.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityL.Location = new System.Drawing.Point(3, 184);
            this.QuantityL.Name = "QuantityL";
            this.QuantityL.Size = new System.Drawing.Size(37, 21);
            this.QuantityL.TabIndex = 5;
            this.QuantityL.Text = "QTY";
            // 
            // QuentityB
            // 
            this.QuentityB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuentityB.Location = new System.Drawing.Point(40, 182);
            this.QuentityB.Name = "QuentityB";
            this.QuentityB.Size = new System.Drawing.Size(45, 28);
            this.QuentityB.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(90, 178);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(55, 35);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PriceL
            // 
            this.PriceL.AutoSize = true;
            this.PriceL.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceL.Location = new System.Drawing.Point(28, 123);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(37, 22);
            this.PriceL.TabIndex = 8;
            this.PriceL.Text = "500";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "৳";
            // 
            // StockQYTL
            // 
            this.StockQYTL.AutoSize = true;
            this.StockQYTL.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQYTL.Location = new System.Drawing.Point(63, 151);
            this.StockQYTL.Name = "StockQYTL";
            this.StockQYTL.Size = new System.Drawing.Size(37, 22);
            this.StockQYTL.TabIndex = 10;
            this.StockQYTL.Text = "500";
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.StockQYTL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceL);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.QuentityB);
            this.Controls.Add(this.QuantityL);
            this.Controls.Add(this.StockL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductNameL);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(150, 215);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuentityB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProductNameL;
        private System.Windows.Forms.Label StockL;
        private System.Windows.Forms.PictureBox ProductPB;
        private System.Windows.Forms.Label QuantityL;
        private System.Windows.Forms.NumericUpDown QuentityB;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label PriceL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StockQYTL;
    }
}
