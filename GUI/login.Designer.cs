namespace NguyenDucQuangHuy_doan.GUI
{
    partial class login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.lblTB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 50);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 43);
            this.label3.TabIndex = 26;
            this.label3.Text = "Welcome to LibraryManagement";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(89, 99);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(191, 22);
            this.txtTK.TabIndex = 31;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(89, 147);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(191, 22);
            this.txtMK.TabIndex = 32;
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.LightCoral;
            this.btnDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDN.Location = new System.Drawing.Point(33, 244);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(109, 42);
            this.btnDN.TabIndex = 33;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.PaleGreen;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(170, 244);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 42);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::NguyenDucQuangHuy_doan.Properties.Resources.icons8_password_32;
            this.pictureBox3.Location = new System.Drawing.Point(43, 139);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NguyenDucQuangHuy_doan.Properties.Resources.icons8_user_32;
            this.pictureBox2.Location = new System.Drawing.Point(43, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTK.ForeColor = System.Drawing.Color.Red;
            this.lblTK.Location = new System.Drawing.Point(86, 124);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(214, 17);
            this.lblTK.TabIndex = 37;
            this.lblTK.Text = "Tài Khoản Không Được Bỏ Trống!";
            this.lblTK.Visible = false;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.ForeColor = System.Drawing.Color.Red;
            this.lblMK.Location = new System.Drawing.Point(30, 172);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(283, 17);
            this.lblMK.TabIndex = 38;
            this.lblMK.Text = "Tài Khoản Hoặc Mật Khẩu Không Chính Xác";
            this.lblMK.Visible = false;
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.ForeColor = System.Drawing.Color.Red;
            this.lblTB.Location = new System.Drawing.Point(30, 224);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(283, 17);
            this.lblTB.TabIndex = 39;
            this.lblTB.Text = "Tài Khoản Hoặc Mật Khẩu Không Chính Xác";
            this.lblTB.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(162)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(347, 298);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTK);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Label lblTB;
    }
}