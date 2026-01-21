namespace Cafe_POS
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpDataGrid = new System.Windows.Forms.DataGridView();
            this.EmployeeListL = new System.Windows.Forms.Label();
            this.IdL = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.SalaryL = new System.Windows.Forms.Label();
            this.SalaryTB = new System.Windows.Forms.TextBox();
            this.PhoneL = new System.Windows.Forms.Label();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.SearchL = new System.Windows.Forms.Label();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveB = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordL = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NameL = new System.Windows.Forms.Label();
            this.UpdateB = new System.Windows.Forms.Button();
            this.AddB = new System.Windows.Forms.Button();
            this.RefreshB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.RefreshB);
            this.panel1.Controls.Add(this.EmpDataGrid);
            this.panel1.Controls.Add(this.EmployeeListL);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 501);
            this.panel1.TabIndex = 2;
            // 
            // EmpDataGrid
            // 
            this.EmpDataGrid.AllowUserToAddRows = false;
            this.EmpDataGrid.AllowUserToDeleteRows = false;
            this.EmpDataGrid.AllowUserToResizeColumns = false;
            this.EmpDataGrid.AllowUserToResizeRows = false;
            this.EmpDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpDataGrid.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.EmpDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.EmpDataGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmpDataGrid.Location = new System.Drawing.Point(17, 48);
            this.EmpDataGrid.Name = "EmpDataGrid";
            this.EmpDataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.EmpDataGrid.RowHeadersVisible = false;
            this.EmpDataGrid.RowHeadersWidth = 5;
            this.EmpDataGrid.RowTemplate.Height = 24;
            this.EmpDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpDataGrid.Size = new System.Drawing.Size(1055, 440);
            this.EmpDataGrid.TabIndex = 2;
            this.EmpDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDataGrid_CellContentClick);
            // 
            // EmployeeListL
            // 
            this.EmployeeListL.AutoSize = true;
            this.EmployeeListL.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListL.Location = new System.Drawing.Point(25, 5);
            this.EmployeeListL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeListL.Name = "EmployeeListL";
            this.EmployeeListL.Size = new System.Drawing.Size(207, 40);
            this.EmployeeListL.TabIndex = 1;
            this.EmployeeListL.Text = "Employee List";
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
            this.IdTB.Size = new System.Drawing.Size(273, 32);
            this.IdTB.TabIndex = 5;
            // 
            // SalaryL
            // 
            this.SalaryL.AutoSize = true;
            this.SalaryL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryL.Location = new System.Drawing.Point(597, 19);
            this.SalaryL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalaryL.Name = "SalaryL";
            this.SalaryL.Size = new System.Drawing.Size(71, 24);
            this.SalaryL.TabIndex = 6;
            this.SalaryL.Text = "Salary :";
            // 
            // SalaryTB
            // 
            this.SalaryTB.BackColor = System.Drawing.Color.Linen;
            this.SalaryTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryTB.Location = new System.Drawing.Point(676, 17);
            this.SalaryTB.Margin = new System.Windows.Forms.Padding(4);
            this.SalaryTB.Name = "SalaryTB";
            this.SalaryTB.Size = new System.Drawing.Size(273, 32);
            this.SalaryTB.TabIndex = 7;
            // 
            // PhoneL
            // 
            this.PhoneL.AutoSize = true;
            this.PhoneL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneL.Location = new System.Drawing.Point(593, 61);
            this.PhoneL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneL.Name = "PhoneL";
            this.PhoneL.Size = new System.Drawing.Size(75, 24);
            this.PhoneL.TabIndex = 8;
            this.PhoneL.Text = "Phone :";
            // 
            // PhoneTB
            // 
            this.PhoneTB.BackColor = System.Drawing.Color.Linen;
            this.PhoneTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTB.Location = new System.Drawing.Point(676, 59);
            this.PhoneTB.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(273, 32);
            this.PhoneTB.TabIndex = 9;
            // 
            // SearchL
            // 
            this.SearchL.AutoSize = true;
            this.SearchL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchL.Location = new System.Drawing.Point(592, 103);
            this.SearchL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchL.Name = "SearchL";
            this.SearchL.Size = new System.Drawing.Size(76, 24);
            this.SearchL.TabIndex = 10;
            this.SearchL.Text = "Search :";
            // 
            // SearchTB
            // 
            this.SearchTB.BackColor = System.Drawing.Color.Linen;
            this.SearchTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTB.Location = new System.Drawing.Point(676, 101);
            this.SearchTB.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(273, 32);
            this.SearchTB.TabIndex = 11;
            // 
            // SearchB
            // 
            this.SearchB.BackColor = System.Drawing.Color.Transparent;
            this.SearchB.FlatAppearance.BorderSize = 0;
            this.SearchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchB.Image = global::Cafe_POS.Properties.Resources.Search;
            this.SearchB.Location = new System.Drawing.Point(957, 96);
            this.SearchB.Margin = new System.Windows.Forms.Padding(4);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(35, 35);
            this.SearchB.TabIndex = 15;
            this.SearchB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchB.UseVisualStyleBackColor = false;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.RemoveB);
            this.panel2.Controls.Add(this.ClearB);
            this.panel2.Controls.Add(this.PasswordTB);
            this.panel2.Controls.Add(this.PasswordL);
            this.panel2.Controls.Add(this.NameTB);
            this.panel2.Controls.Add(this.NameL);
            this.panel2.Controls.Add(this.UpdateB);
            this.panel2.Controls.Add(this.AddB);
            this.panel2.Controls.Add(this.SearchB);
            this.panel2.Controls.Add(this.SearchTB);
            this.panel2.Controls.Add(this.SearchL);
            this.panel2.Controls.Add(this.PhoneTB);
            this.panel2.Controls.Add(this.PhoneL);
            this.panel2.Controls.Add(this.SalaryTB);
            this.panel2.Controls.Add(this.SalaryL);
            this.panel2.Controls.Add(this.IdTB);
            this.panel2.Controls.Add(this.IdL);
            this.panel2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(10, 515);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 234);
            this.panel2.TabIndex = 3;
            // 
            // RemoveB
            // 
            this.RemoveB.BackColor = System.Drawing.Color.Sienna;
            this.RemoveB.FlatAppearance.BorderSize = 0;
            this.RemoveB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveB.Location = new System.Drawing.Point(567, 173);
            this.RemoveB.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveB.Name = "RemoveB";
            this.RemoveB.Size = new System.Drawing.Size(167, 41);
            this.RemoveB.TabIndex = 24;
            this.RemoveB.Text = "REMOVE";
            this.RemoveB.UseVisualStyleBackColor = false;
            this.RemoveB.Click += new System.EventHandler(this.RemoveB_Click);
            // 
            // ClearB
            // 
            this.ClearB.BackColor = System.Drawing.Color.Sienna;
            this.ClearB.FlatAppearance.BorderSize = 0;
            this.ClearB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearB.Location = new System.Drawing.Point(782, 173);
            this.ClearB.Margin = new System.Windows.Forms.Padding(4);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(167, 41);
            this.ClearB.TabIndex = 23;
            this.ClearB.Text = "CLEARE";
            this.ClearB.UseVisualStyleBackColor = false;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.Color.Linen;
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(129, 103);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(273, 32);
            this.PasswordTB.TabIndex = 22;
            // 
            // PasswordL
            // 
            this.PasswordL.AutoSize = true;
            this.PasswordL.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordL.Location = new System.Drawing.Point(19, 105);
            this.PasswordL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordL.Name = "PasswordL";
            this.PasswordL.Size = new System.Drawing.Size(102, 24);
            this.PasswordL.TabIndex = 21;
            this.PasswordL.Text = "Password :";
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.Color.Linen;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(129, 63);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(273, 32);
            this.NameTB.TabIndex = 20;
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
            // 
            // UpdateB
            // 
            this.UpdateB.BackColor = System.Drawing.Color.Sienna;
            this.UpdateB.FlatAppearance.BorderSize = 0;
            this.UpdateB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateB.Location = new System.Drawing.Point(348, 173);
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
            this.AddB.Location = new System.Drawing.Point(126, 173);
            this.AddB.Margin = new System.Windows.Forms.Padding(4);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(167, 41);
            this.AddB.TabIndex = 16;
            this.AddB.Text = "ADD";
            this.AddB.UseVisualStyleBackColor = false;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // RefreshB
            // 
            this.RefreshB.BackColor = System.Drawing.Color.PeachPuff;
            this.RefreshB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshB.ForeColor = System.Drawing.Color.Transparent;
            this.RefreshB.Image = global::Cafe_POS.Properties.Resources.Refresh;
            this.RefreshB.Location = new System.Drawing.Point(1037, 6);
            this.RefreshB.Name = "RefreshB";
            this.RefreshB.Size = new System.Drawing.Size(35, 35);
            this.RefreshB.TabIndex = 25;
            this.RefreshB.UseVisualStyleBackColor = false;
            this.RefreshB.Click += new System.EventHandler(this.RefreshB_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(1098, 753);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EmployeeListL;
        private System.Windows.Forms.Label IdL;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label SalaryL;
        private System.Windows.Forms.TextBox SalaryTB;
        private System.Windows.Forms.Label PhoneL;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.Label SearchL;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Button UpdateB;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label PasswordL;
        private System.Windows.Forms.Button RemoveB;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.DataGridView EmpDataGrid;
        private System.Windows.Forms.Button RefreshB;
    }
}
