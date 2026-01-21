namespace Cafe_POS
{
    partial class Inventory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProductIDL = new System.Windows.Forms.Label();
            this.ProductIDTB = new System.Windows.Forms.TextBox();
            this.ProductNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductPriceTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductStockTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductCategoryCB = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ImportB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductAddB = new System.Windows.Forms.Button();
            this.ProductUpdateB = new System.Windows.Forms.Button();
            this.ProductClearB = new System.Windows.Forms.Button();
            this.ProductDeleteB = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 703);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(410, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 380);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(940, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProductClearB);
            this.panel3.Controls.Add(this.ProductDeleteB);
            this.panel3.Controls.Add(this.ProductUpdateB);
            this.panel3.Controls.Add(this.ProductAddB);
            this.panel3.Controls.Add(this.ImportB);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.ProductCategoryCB);
            this.panel3.Controls.Add(this.SearchTB);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ProductStockTB);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.ProductPriceTB);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ProductNameTB);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ProductIDTB);
            this.panel3.Controls.Add(this.ProductIDL);
            this.panel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(410, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(960, 291);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // ProductIDL
            // 
            this.ProductIDL.AutoSize = true;
            this.ProductIDL.Location = new System.Drawing.Point(9, 18);
            this.ProductIDL.Name = "ProductIDL";
            this.ProductIDL.Size = new System.Drawing.Size(102, 24);
            this.ProductIDL.TabIndex = 0;
            this.ProductIDL.Text = "Oroduct ID";
            // 
            // ProductIDTB
            // 
            this.ProductIDTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductIDTB.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDTB.Location = new System.Drawing.Point(117, 13);
            this.ProductIDTB.Name = "ProductIDTB";
            this.ProductIDTB.Size = new System.Drawing.Size(170, 29);
            this.ProductIDTB.TabIndex = 1;
            // 
            // ProductNameTB
            // 
            this.ProductNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductNameTB.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameTB.Location = new System.Drawing.Point(117, 60);
            this.ProductNameTB.Name = "ProductNameTB";
            this.ProductNameTB.Size = new System.Drawing.Size(170, 29);
            this.ProductNameTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            // 
            // ProductPriceTB
            // 
            this.ProductPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPriceTB.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceTB.Location = new System.Drawing.Point(451, 13);
            this.ProductPriceTB.Name = "ProductPriceTB";
            this.ProductPriceTB.Size = new System.Drawing.Size(170, 29);
            this.ProductPriceTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // ProductStockTB
            // 
            this.ProductStockTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductStockTB.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductStockTB.Location = new System.Drawing.Point(451, 60);
            this.ProductStockTB.Name = "ProductStockTB";
            this.ProductStockTB.Size = new System.Drawing.Size(170, 29);
            this.ProductStockTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stock";
            // 
            // SearchTB
            // 
            this.SearchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTB.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTB.Location = new System.Drawing.Point(451, 110);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(170, 29);
            this.SearchTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Search";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProductCategoryCB
            // 
            this.ProductCategoryCB.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryCB.FormattingEnabled = true;
            this.ProductCategoryCB.Items.AddRange(new object[] {
            "Coffee",
            "Tea",
            "Drinks",
            "Smoothie",
            "Bakery"});
            this.ProductCategoryCB.Location = new System.Drawing.Point(117, 107);
            this.ProductCategoryCB.Name = "ProductCategoryCB";
            this.ProductCategoryCB.Size = new System.Drawing.Size(170, 29);
            this.ProductCategoryCB.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(778, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 126);
            this.panel4.TabIndex = 13;
            // 
            // ImportB
            // 
            this.ImportB.BackColor = System.Drawing.Color.SaddleBrown;
            this.ImportB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ImportB.ForeColor = System.Drawing.Color.Transparent;
            this.ImportB.Location = new System.Drawing.Point(778, 155);
            this.ImportB.Name = "ImportB";
            this.ImportB.Size = new System.Drawing.Size(140, 45);
            this.ImportB.TabIndex = 14;
            this.ImportB.Text = "Import";
            this.ImportB.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 126);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProductAddB
            // 
            this.ProductAddB.BackColor = System.Drawing.Color.SaddleBrown;
            this.ProductAddB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductAddB.ForeColor = System.Drawing.Color.Transparent;
            this.ProductAddB.Location = new System.Drawing.Point(68, 221);
            this.ProductAddB.Name = "ProductAddB";
            this.ProductAddB.Size = new System.Drawing.Size(140, 45);
            this.ProductAddB.TabIndex = 15;
            this.ProductAddB.Text = "Add";
            this.ProductAddB.UseVisualStyleBackColor = false;
            this.ProductAddB.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductUpdateB
            // 
            this.ProductUpdateB.BackColor = System.Drawing.Color.SaddleBrown;
            this.ProductUpdateB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductUpdateB.ForeColor = System.Drawing.Color.Transparent;
            this.ProductUpdateB.Location = new System.Drawing.Point(248, 221);
            this.ProductUpdateB.Name = "ProductUpdateB";
            this.ProductUpdateB.Size = new System.Drawing.Size(140, 45);
            this.ProductUpdateB.TabIndex = 16;
            this.ProductUpdateB.Text = "Update";
            this.ProductUpdateB.UseVisualStyleBackColor = false;
            this.ProductUpdateB.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductClearB
            // 
            this.ProductClearB.BackColor = System.Drawing.Color.SaddleBrown;
            this.ProductClearB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductClearB.ForeColor = System.Drawing.Color.Transparent;
            this.ProductClearB.Location = new System.Drawing.Point(620, 221);
            this.ProductClearB.Name = "ProductClearB";
            this.ProductClearB.Size = new System.Drawing.Size(140, 45);
            this.ProductClearB.TabIndex = 18;
            this.ProductClearB.Text = "Clear";
            this.ProductClearB.UseVisualStyleBackColor = false;
            this.ProductClearB.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProductDeleteB
            // 
            this.ProductDeleteB.BackColor = System.Drawing.Color.SaddleBrown;
            this.ProductDeleteB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductDeleteB.ForeColor = System.Drawing.Color.Transparent;
            this.ProductDeleteB.Location = new System.Drawing.Point(440, 221);
            this.ProductDeleteB.Name = "ProductDeleteB";
            this.ProductDeleteB.Size = new System.Drawing.Size(140, 45);
            this.ProductDeleteB.TabIndex = 17;
            this.ProductDeleteB.Text = "Delete";
            this.ProductDeleteB.UseVisualStyleBackColor = false;
            this.ProductDeleteB.Click += new System.EventHandler(this.button4_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProductStockTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductPriceTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductIDTB;
        private System.Windows.Forms.Label ProductIDL;
        private System.Windows.Forms.ComboBox ProductCategoryCB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ImportB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ProductClearB;
        private System.Windows.Forms.Button ProductDeleteB;
        private System.Windows.Forms.Button ProductUpdateB;
        private System.Windows.Forms.Button ProductAddB;
    }
}