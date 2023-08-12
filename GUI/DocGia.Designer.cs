namespace NguyenDucQuangHuy_doan.GUI
{
    partial class DocGia
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
            this.grDSDG = new System.Windows.Forms.GroupBox();
            this.dgvDSDG = new System.Windows.Forms.DataGridView();
            this.grTTDG = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.txtEmailDG = new System.Windows.Forms.TextBox();
            this.txtSDTDG = new System.Windows.Forms.TextBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.txtDCDG = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblSDTDG = new System.Windows.Forms.Label();
            this.lblDCDG = new System.Windows.Forms.Label();
            this.lblTenDG = new System.Windows.Forms.Label();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.grChucNangPT = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimDG = new System.Windows.Forms.Label();
            this.btnXoaDG = new System.Windows.Forms.Button();
            this.btnSuaDG = new System.Windows.Forms.Button();
            this.btnTimDG = new System.Windows.Forms.Button();
            this.btnThemDG = new System.Windows.Forms.Button();
            this.grDSDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDG)).BeginInit();
            this.grTTDG.SuspendLayout();
            this.grChucNangPT.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDSDG
            // 
            this.grDSDG.Controls.Add(this.dgvDSDG);
            this.grDSDG.Location = new System.Drawing.Point(257, 10);
            this.grDSDG.Margin = new System.Windows.Forms.Padding(2);
            this.grDSDG.Name = "grDSDG";
            this.grDSDG.Padding = new System.Windows.Forms.Padding(2);
            this.grDSDG.Size = new System.Drawing.Size(667, 500);
            this.grDSDG.TabIndex = 10;
            this.grDSDG.TabStop = false;
            this.grDSDG.Text = "Danh Sách Độc Giả";
            // 
            // dgvDSDG
            // 
            this.dgvDSDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDG.Location = new System.Drawing.Point(6, 19);
            this.dgvDSDG.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSDG.Name = "dgvDSDG";
            this.dgvDSDG.RowHeadersWidth = 51;
            this.dgvDSDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDG.Size = new System.Drawing.Size(657, 476);
            this.dgvDSDG.TabIndex = 0;
            this.dgvDSDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDG_CellContentClick);
            // 
            // grTTDG
            // 
            this.grTTDG.Controls.Add(this.radNu);
            this.grTTDG.Controls.Add(this.txtEmailDG);
            this.grTTDG.Controls.Add(this.txtSDTDG);
            this.grTTDG.Controls.Add(this.txtTenDG);
            this.grTTDG.Controls.Add(this.radNam);
            this.grTTDG.Controls.Add(this.txtDCDG);
            this.grTTDG.Controls.Add(this.dtpNgaySinh);
            this.grTTDG.Controls.Add(this.lblGioiTinh);
            this.grTTDG.Controls.Add(this.txtMaDG);
            this.grTTDG.Controls.Add(this.lblEmail);
            this.grTTDG.Controls.Add(this.lblNgaySinh);
            this.grTTDG.Controls.Add(this.lblSDTDG);
            this.grTTDG.Controls.Add(this.lblDCDG);
            this.grTTDG.Controls.Add(this.lblTenDG);
            this.grTTDG.Controls.Add(this.lblMaDG);
            this.grTTDG.Location = new System.Drawing.Point(9, 9);
            this.grTTDG.Margin = new System.Windows.Forms.Padding(2);
            this.grTTDG.Name = "grTTDG";
            this.grTTDG.Padding = new System.Windows.Forms.Padding(2);
            this.grTTDG.Size = new System.Drawing.Size(243, 213);
            this.grTTDG.TabIndex = 11;
            this.grTTDG.TabStop = false;
            this.grTTDG.Text = "Thông Tin Độc Giả";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(171, 96);
            this.radNu.Margin = new System.Windows.Forms.Padding(2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 5;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // txtEmailDG
            // 
            this.txtEmailDG.Location = new System.Drawing.Point(104, 171);
            this.txtEmailDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailDG.Name = "txtEmailDG";
            this.txtEmailDG.Size = new System.Drawing.Size(135, 22);
            this.txtEmailDG.TabIndex = 1;
            // 
            // txtSDTDG
            // 
            this.txtSDTDG.Location = new System.Drawing.Point(104, 145);
            this.txtSDTDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDTDG.Name = "txtSDTDG";
            this.txtSDTDG.Size = new System.Drawing.Size(135, 22);
            this.txtSDTDG.TabIndex = 1;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(104, 45);
            this.txtTenDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(135, 22);
            this.txtTenDG.TabIndex = 1;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(104, 96);
            this.radNam.Margin = new System.Windows.Forms.Padding(2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 5;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // txtDCDG
            // 
            this.txtDCDG.Location = new System.Drawing.Point(104, 119);
            this.txtDCDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtDCDG.Name = "txtDCDG";
            this.txtDCDG.Size = new System.Drawing.Size(135, 22);
            this.txtDCDG.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(104, 70);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(135, 22);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(5, 98);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(60, 16);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(104, 20);
            this.txtMaDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(135, 22);
            this.txtMaDG.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(5, 174);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(5, 76);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 16);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblSDTDG
            // 
            this.lblSDTDG.AutoSize = true;
            this.lblSDTDG.Location = new System.Drawing.Point(5, 148);
            this.lblSDTDG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDTDG.Name = "lblSDTDG";
            this.lblSDTDG.Size = new System.Drawing.Size(92, 16);
            this.lblSDTDG.TabIndex = 0;
            this.lblSDTDG.Text = "Số Điện Thoại";
            // 
            // lblDCDG
            // 
            this.lblDCDG.AutoSize = true;
            this.lblDCDG.Location = new System.Drawing.Point(5, 122);
            this.lblDCDG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDCDG.Name = "lblDCDG";
            this.lblDCDG.Size = new System.Drawing.Size(49, 16);
            this.lblDCDG.TabIndex = 0;
            this.lblDCDG.Text = "Địa Chỉ";
            // 
            // lblTenDG
            // 
            this.lblTenDG.AutoSize = true;
            this.lblTenDG.Location = new System.Drawing.Point(5, 47);
            this.lblTenDG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDG.Name = "lblTenDG";
            this.lblTenDG.Size = new System.Drawing.Size(82, 16);
            this.lblTenDG.TabIndex = 0;
            this.lblTenDG.Text = "Tên Độc Giả";
            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Location = new System.Drawing.Point(5, 22);
            this.lblMaDG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Size = new System.Drawing.Size(77, 16);
            this.lblMaDG.TabIndex = 0;
            this.lblMaDG.Text = "Mã Độc Giả";
            // 
            // grChucNangPT
            // 
            this.grChucNangPT.Controls.Add(this.btnRefresh);
            this.grChucNangPT.Controls.Add(this.txtTimkiem);
            this.grChucNangPT.Controls.Add(this.lblTimDG);
            this.grChucNangPT.Controls.Add(this.btnXoaDG);
            this.grChucNangPT.Controls.Add(this.btnSuaDG);
            this.grChucNangPT.Controls.Add(this.btnTimDG);
            this.grChucNangPT.Controls.Add(this.btnThemDG);
            this.grChucNangPT.Location = new System.Drawing.Point(9, 227);
            this.grChucNangPT.Margin = new System.Windows.Forms.Padding(2);
            this.grChucNangPT.Name = "grChucNangPT";
            this.grChucNangPT.Padding = new System.Windows.Forms.Padding(2);
            this.grChucNangPT.Size = new System.Drawing.Size(243, 282);
            this.grChucNangPT.TabIndex = 12;
            this.grChucNangPT.TabStop = false;
            this.grChucNangPT.Text = "Chức Năng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(5, 144);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(231, 37);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(5, 220);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(195, 22);
            this.txtTimkiem.TabIndex = 3;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // lblTimDG
            // 
            this.lblTimDG.AutoSize = true;
            this.lblTimDG.Location = new System.Drawing.Point(2, 203);
            this.lblTimDG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimDG.Name = "lblTimDG";
            this.lblTimDG.Size = new System.Drawing.Size(143, 16);
            this.lblTimDG.TabIndex = 2;
            this.lblTimDG.Text = "Tìm Độc Giả Theo Tên";
            // 
            // btnXoaDG
            // 
            this.btnXoaDG.Location = new System.Drawing.Point(5, 102);
            this.btnXoaDG.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaDG.Name = "btnXoaDG";
            this.btnXoaDG.Size = new System.Drawing.Size(231, 37);
            this.btnXoaDG.TabIndex = 0;
            this.btnXoaDG.Text = "Xóa Độc Giả";
            this.btnXoaDG.UseVisualStyleBackColor = true;
            this.btnXoaDG.Click += new System.EventHandler(this.btnXoaDG_Click);
            // 
            // btnSuaDG
            // 
            this.btnSuaDG.Location = new System.Drawing.Point(5, 61);
            this.btnSuaDG.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaDG.Name = "btnSuaDG";
            this.btnSuaDG.Size = new System.Drawing.Size(231, 37);
            this.btnSuaDG.TabIndex = 0;
            this.btnSuaDG.Text = "Sửa Độc Giả";
            this.btnSuaDG.UseVisualStyleBackColor = true;
            this.btnSuaDG.Click += new System.EventHandler(this.btnSuaDG_Click);
            // 
            // btnTimDG
            // 
            this.btnTimDG.Location = new System.Drawing.Point(5, 246);
            this.btnTimDG.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimDG.Name = "btnTimDG";
            this.btnTimDG.Size = new System.Drawing.Size(109, 32);
            this.btnTimDG.TabIndex = 1;
            this.btnTimDG.Text = "Tìm Độc Giả";
            this.btnTimDG.UseVisualStyleBackColor = true;
            this.btnTimDG.Click += new System.EventHandler(this.btnTimDG_Click);
            // 
            // btnThemDG
            // 
            this.btnThemDG.Location = new System.Drawing.Point(5, 20);
            this.btnThemDG.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemDG.Name = "btnThemDG";
            this.btnThemDG.Size = new System.Drawing.Size(231, 37);
            this.btnThemDG.TabIndex = 0;
            this.btnThemDG.Text = "Thêm Độc Giả";
            this.btnThemDG.UseVisualStyleBackColor = true;
            this.btnThemDG.Click += new System.EventHandler(this.btnThemDG_Click);
            // 
            // DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(201)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.grChucNangPT);
            this.Controls.Add(this.grTTDG);
            this.Controls.Add(this.grDSDG);
            this.Name = "DocGia";
            this.Text = "DocGia";
            this.Load += new System.EventHandler(this.DocGia_Load);
            this.grDSDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDG)).EndInit();
            this.grTTDG.ResumeLayout(false);
            this.grTTDG.PerformLayout();
            this.grChucNangPT.ResumeLayout(false);
            this.grChucNangPT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grDSDG;
        private System.Windows.Forms.DataGridView dgvDSDG;
        private System.Windows.Forms.GroupBox grTTDG;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.TextBox txtEmailDG;
        private System.Windows.Forms.TextBox txtSDTDG;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtDCDG;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblSDTDG;
        private System.Windows.Forms.Label lblDCDG;
        private System.Windows.Forms.Label lblTenDG;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.GroupBox grChucNangPT;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lblTimDG;
        private System.Windows.Forms.Button btnXoaDG;
        private System.Windows.Forms.Button btnSuaDG;
        private System.Windows.Forms.Button btnTimDG;
        private System.Windows.Forms.Button btnThemDG;
    }
}