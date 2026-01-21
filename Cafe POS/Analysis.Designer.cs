namespace Cafe_POS
{
    partial class Analysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GraphP = new System.Windows.Forms.Panel();
            this.GraphC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.JanuaryL = new System.Windows.Forms.Label();
            this.JanL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FebL = new System.Windows.Forms.Label();
            this.SepL = new System.Windows.Forms.Label();
            this.OctL = new System.Windows.Forms.Label();
            this.NovL = new System.Windows.Forms.Label();
            this.DecL = new System.Windows.Forms.Label();
            this.MonthP = new System.Windows.Forms.Panel();
            this.AugL = new System.Windows.Forms.Label();
            this.JulyL = new System.Windows.Forms.Label();
            this.JuneL = new System.Windows.Forms.Label();
            this.MayL = new System.Windows.Forms.Label();
            this.AprL = new System.Windows.Forms.Label();
            this.MarL = new System.Windows.Forms.Label();
            this.GraphP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphC)).BeginInit();
            this.MonthP.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphP
            // 
            this.GraphP.BackColor = System.Drawing.Color.PeachPuff;
            this.GraphP.Controls.Add(this.GraphC);
            this.GraphP.Location = new System.Drawing.Point(328, 20);
            this.GraphP.Margin = new System.Windows.Forms.Padding(4);
            this.GraphP.Name = "GraphP";
            this.GraphP.Size = new System.Drawing.Size(750, 713);
            this.GraphP.TabIndex = 27;
            this.GraphP.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphP_Paint);
            // 
            // GraphC
            // 
            this.GraphC.BackColor = System.Drawing.Color.PeachPuff;
            this.GraphC.BorderlineColor = System.Drawing.Color.Linen;
            chartArea1.Name = "ChartArea1";
            this.GraphC.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraphC.Legends.Add(legend1);
            this.GraphC.Location = new System.Drawing.Point(20, 20);
            this.GraphC.Name = "GraphC";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.GraphC.Series.Add(series1);
            this.GraphC.Size = new System.Drawing.Size(710, 673);
            this.GraphC.TabIndex = 0;
            this.GraphC.Text = "Monthly Sales";
            this.GraphC.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            title1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Monthy Sales";
            this.GraphC.Titles.Add(title1);
            this.GraphC.Click += new System.EventHandler(this.GraphC_Click);
            // 
            // JanuaryL
            // 
            this.JanuaryL.AutoSize = true;
            this.JanuaryL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JanuaryL.Location = new System.Drawing.Point(40, 9);
            this.JanuaryL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JanuaryL.Name = "JanuaryL";
            this.JanuaryL.Size = new System.Drawing.Size(153, 35);
            this.JanuaryL.TabIndex = 0;
            this.JanuaryL.Text = "January       :";
            // 
            // JanL
            // 
            this.JanL.AutoSize = true;
            this.JanL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JanL.Location = new System.Drawing.Point(37, 9);
            this.JanL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JanL.Name = "JanL";
            this.JanL.Size = new System.Drawing.Size(153, 35);
            this.JanL.TabIndex = 0;
            this.JanL.Text = "January       :";
            this.JanL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "February    :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FebL
            // 
            this.FebL.AutoSize = true;
            this.FebL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FebL.Location = new System.Drawing.Point(40, 69);
            this.FebL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FebL.Name = "FebL";
            this.FebL.Size = new System.Drawing.Size(150, 35);
            this.FebL.TabIndex = 2;
            this.FebL.Text = "February    :";
            this.FebL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SepL
            // 
            this.SepL.AutoSize = true;
            this.SepL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SepL.Location = new System.Drawing.Point(35, 489);
            this.SepL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SepL.Name = "SepL";
            this.SepL.Size = new System.Drawing.Size(155, 35);
            this.SepL.TabIndex = 28;
            this.SepL.Text = "September :";
            this.SepL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OctL
            // 
            this.OctL.AutoSize = true;
            this.OctL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OctL.Location = new System.Drawing.Point(37, 549);
            this.OctL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OctL.Name = "OctL";
            this.OctL.Size = new System.Drawing.Size(153, 35);
            this.OctL.TabIndex = 30;
            this.OctL.Text = "October      :";
            this.OctL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NovL
            // 
            this.NovL.AutoSize = true;
            this.NovL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovL.Location = new System.Drawing.Point(39, 609);
            this.NovL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NovL.Name = "NovL";
            this.NovL.Size = new System.Drawing.Size(150, 35);
            this.NovL.TabIndex = 32;
            this.NovL.Text = "November :";
            this.NovL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DecL
            // 
            this.DecL.AutoSize = true;
            this.DecL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecL.Location = new System.Drawing.Point(37, 669);
            this.DecL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DecL.Name = "DecL";
            this.DecL.Size = new System.Drawing.Size(153, 35);
            this.DecL.TabIndex = 34;
            this.DecL.Text = "December  :";
            this.DecL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MonthP
            // 
            this.MonthP.BackColor = System.Drawing.Color.PeachPuff;
            this.MonthP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthP.Controls.Add(this.AugL);
            this.MonthP.Controls.Add(this.JulyL);
            this.MonthP.Controls.Add(this.JuneL);
            this.MonthP.Controls.Add(this.MayL);
            this.MonthP.Controls.Add(this.AprL);
            this.MonthP.Controls.Add(this.MarL);
            this.MonthP.Controls.Add(this.DecL);
            this.MonthP.Controls.Add(this.NovL);
            this.MonthP.Controls.Add(this.OctL);
            this.MonthP.Controls.Add(this.SepL);
            this.MonthP.Controls.Add(this.FebL);
            this.MonthP.Controls.Add(this.label2);
            this.MonthP.Controls.Add(this.JanL);
            this.MonthP.Controls.Add(this.JanuaryL);
            this.MonthP.Location = new System.Drawing.Point(20, 20);
            this.MonthP.Name = "MonthP";
            this.MonthP.Size = new System.Drawing.Size(300, 713);
            this.MonthP.TabIndex = 0;
            this.MonthP.Paint += new System.Windows.Forms.PaintEventHandler(this.MonthP_Paint);
            // 
            // AugL
            // 
            this.AugL.AutoSize = true;
            this.AugL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AugL.Location = new System.Drawing.Point(34, 429);
            this.AugL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AugL.Name = "AugL";
            this.AugL.Size = new System.Drawing.Size(156, 35);
            this.AugL.TabIndex = 41;
            this.AugL.Text = "August         :";
            this.AugL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // JulyL
            // 
            this.JulyL.AutoSize = true;
            this.JulyL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JulyL.Location = new System.Drawing.Point(39, 369);
            this.JulyL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JulyL.Name = "JulyL";
            this.JulyL.Size = new System.Drawing.Size(150, 35);
            this.JulyL.TabIndex = 40;
            this.JulyL.Text = "July              :";
            this.JulyL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // JuneL
            // 
            this.JuneL.AutoSize = true;
            this.JuneL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JuneL.Location = new System.Drawing.Point(36, 309);
            this.JuneL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JuneL.Name = "JuneL";
            this.JuneL.Size = new System.Drawing.Size(154, 35);
            this.JuneL.TabIndex = 39;
            this.JuneL.Text = "June             :";
            this.JuneL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MayL
            // 
            this.MayL.AutoSize = true;
            this.MayL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayL.Location = new System.Drawing.Point(40, 249);
            this.MayL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MayL.Name = "MayL";
            this.MayL.Size = new System.Drawing.Size(150, 35);
            this.MayL.TabIndex = 38;
            this.MayL.Text = "May             :";
            this.MayL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AprL
            // 
            this.AprL.AutoSize = true;
            this.AprL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AprL.Location = new System.Drawing.Point(36, 189);
            this.AprL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AprL.Name = "AprL";
            this.AprL.Size = new System.Drawing.Size(154, 35);
            this.AprL.TabIndex = 37;
            this.AprL.Text = "April             :";
            this.AprL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MarL
            // 
            this.MarL.AutoSize = true;
            this.MarL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarL.Location = new System.Drawing.Point(39, 129);
            this.MarL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MarL.Name = "MarL";
            this.MarL.Size = new System.Drawing.Size(151, 35);
            this.MarL.TabIndex = 36;
            this.MarL.Text = "March         :";
            this.MarL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.MonthP);
            this.Controls.Add(this.GraphP);
            this.Name = "Analysis";
            this.Size = new System.Drawing.Size(1098, 753);
            this.Load += new System.EventHandler(this.Analysis_Load);
            this.GraphP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraphC)).EndInit();
            this.MonthP.ResumeLayout(false);
            this.MonthP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GraphP;
        private System.Windows.Forms.Label JanuaryL;
        private System.Windows.Forms.Label JanL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FebL;
        private System.Windows.Forms.Label SepL;
        private System.Windows.Forms.Label OctL;
        private System.Windows.Forms.Label NovL;
        private System.Windows.Forms.Label DecL;
        private System.Windows.Forms.Panel MonthP;
        private System.Windows.Forms.Label AugL;
        private System.Windows.Forms.Label JulyL;
        private System.Windows.Forms.Label JuneL;
        private System.Windows.Forms.Label MayL;
        private System.Windows.Forms.Label AprL;
        private System.Windows.Forms.Label MarL;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphC;
    }
}
