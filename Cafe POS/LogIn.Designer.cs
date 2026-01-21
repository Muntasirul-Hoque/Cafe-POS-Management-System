namespace Cafe_POS
{
    partial class LogIn
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
            this.ShopNameL = new System.Windows.Forms.Label();
            this.SignInL = new System.Windows.Forms.Label();
            this.UserIDL = new System.Windows.Forms.Label();
            this.PassL = new System.Windows.Forms.Label();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.LogInB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopNameL
            // 
            this.ShopNameL.AutoSize = true;
            this.ShopNameL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopNameL.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ShopNameL.Location = new System.Drawing.Point(854, 30);
            this.ShopNameL.Name = "ShopNameL";
            this.ShopNameL.Size = new System.Drawing.Size(445, 58);
            this.ShopNameL.TabIndex = 1;
            this.ShopNameL.Text = "Urban Brew Café";
            // 
            // SignInL
            // 
            this.SignInL.AutoSize = true;
            this.SignInL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInL.Location = new System.Drawing.Point(827, 171);
            this.SignInL.Name = "SignInL";
            this.SignInL.Size = new System.Drawing.Size(166, 50);
            this.SignInL.TabIndex = 2;
            this.SignInL.Text = "Sign In";
            // 
            // UserIDL
            // 
            this.UserIDL.AutoSize = true;
            this.UserIDL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDL.Location = new System.Drawing.Point(829, 257);
            this.UserIDL.Name = "UserIDL";
            this.UserIDL.Size = new System.Drawing.Size(154, 38);
            this.UserIDL.TabIndex = 3;
            this.UserIDL.Text = "User ID: ";
            // 
            // PassL
            // 
            this.PassL.AutoSize = true;
            this.PassL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassL.Location = new System.Drawing.Point(829, 356);
            this.PassL.Name = "PassL";
            this.PassL.Size = new System.Drawing.Size(195, 38);
            this.PassL.TabIndex = 4;
            this.PassL.Text = "Password: ";
            // 
            // IdTB
            // 
            this.IdTB.BackColor = System.Drawing.Color.Linen;
            this.IdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(836, 296);
            this.IdTB.Margin = new System.Windows.Forms.Padding(0);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(463, 35);
            this.IdTB.TabIndex = 5;
            // 
            // PassTB
            // 
            this.PassTB.BackColor = System.Drawing.Color.Linen;
            this.PassTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTB.Location = new System.Drawing.Point(836, 395);
            this.PassTB.Margin = new System.Windows.Forms.Padding(0);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(463, 35);
            this.PassTB.TabIndex = 6;
            // 
            // LogInB
            // 
            this.LogInB.BackColor = System.Drawing.Color.Sienna;
            this.LogInB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogInB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInB.ForeColor = System.Drawing.Color.Transparent;
            this.LogInB.Location = new System.Drawing.Point(836, 490);
            this.LogInB.Name = "LogInB";
            this.LogInB.Size = new System.Drawing.Size(163, 54);
            this.LogInB.TabIndex = 7;
            this.LogInB.Text = "Log In";
            this.LogInB.UseVisualStyleBackColor = false;
            this.LogInB.Click += new System.EventHandler(this.LogInB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cafe_POS.Properties.Resources.LogIn_Photo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(753, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.LogInB);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.PassL);
            this.Controls.Add(this.UserIDL);
            this.Controls.Add(this.SignInL);
            this.Controls.Add(this.ShopNameL);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ShopNameL;
        private System.Windows.Forms.Label SignInL;
        private System.Windows.Forms.Label UserIDL;
        private System.Windows.Forms.Label PassL;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Button LogInB;
    }
}