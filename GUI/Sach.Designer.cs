namespace NguyenDucQuangHuy_doan.GUI
{
    partial class Sach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiSach = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSach = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.lblNXB = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblLoaiSach = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblDG = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.lblTimSP = new System.Windows.Forms.Label();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSSach);
            this.groupBox2.Location = new System.Drawing.Point(398, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 490);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sách";
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Location = new System.Drawing.Point(6, 21);
            this.dgvDSSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.RowHeadersWidth = 51;
            this.dgvDSSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSach.Size = new System.Drawing.Size(509, 463);
            this.dgvDSSach.TabIndex = 0;
            this.dgvDSSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSach_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLoaiSach);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtMaLoaiSach);
            this.groupBox1.Controls.Add(this.txtTinhTrang);
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTinhTrang);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.lblNXB);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.lblTacGia);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.lblLoaiSach);
            this.groupBox1.Controls.Add(this.lblMaSach);
            this.groupBox1.Controls.Add(this.lblDG);
            this.groupBox1.Controls.Add(this.lblTenSach);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 320);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // cboLoaiSach
            // 
            this.cboLoaiSach.FormattingEnabled = true;
            this.cboLoaiSach.Location = new System.Drawing.Point(255, 78);
            this.cboLoaiSach.Name = "cboLoaiSach";
            this.cboLoaiSach.Size = new System.Drawing.Size(111, 24);
            this.cboLoaiSach.TabIndex = 5;
            this.cboLoaiSach.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSach_SelectedIndexChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(70, 78);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(86, 22);
            this.txtDonGia.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(280, 22);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(86, 22);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(70, 50);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(296, 22);
            this.txtTenSach.TabIndex = 1;
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Enabled = false;
            this.txtMaLoaiSach.Location = new System.Drawing.Point(95, 197);
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.Size = new System.Drawing.Size(111, 22);
            this.txtMaLoaiSach.TabIndex = 1;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Enabled = false;
            this.txtTinhTrang.Location = new System.Drawing.Point(95, 162);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(111, 22);
            this.txtTinhTrang.TabIndex = 1;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(95, 134);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(111, 22);
            this.txtNXB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại Sách";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(7, 165);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(72, 16);
            this.lblTinhTrang.TabIndex = 0;
            this.lblTinhTrang.Text = "Tình Trạng";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(95, 106);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(111, 22);
            this.txtTacGia.TabIndex = 1;
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Location = new System.Drawing.Point(7, 137);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(88, 16);
            this.lblNXB.TabIndex = 0;
            this.lblNXB.Text = "Nhà Xuất Bản";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(70, 22);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(117, 22);
            this.txtMaSach.TabIndex = 1;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(7, 109);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(55, 16);
            this.lblTacGia.TabIndex = 0;
            this.lblTacGia.Text = "Tác Giả";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(215, 25);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 16);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lblLoaiSach
            // 
            this.lblLoaiSach.AutoSize = true;
            this.lblLoaiSach.Location = new System.Drawing.Point(167, 81);
            this.lblLoaiSach.Name = "lblLoaiSach";
            this.lblLoaiSach.Size = new System.Drawing.Size(67, 16);
            this.lblLoaiSach.TabIndex = 0;
            this.lblLoaiSach.Text = "Loại Sách";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(7, 25);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(60, 16);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã Sách";
            // 
            // lblDG
            // 
            this.lblDG.AutoSize = true;
            this.lblDG.Location = new System.Drawing.Point(7, 81);
            this.lblDG.Name = "lblDG";
            this.lblDG.Size = new System.Drawing.Size(55, 16);
            this.lblDG.TabIndex = 0;
            this.lblDG.Text = "Đơn Giá";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(7, 53);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(65, 16);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.txtTimSach);
            this.groupBox3.Controls.Add(this.lblTimSP);
            this.groupBox3.Controls.Add(this.btnTimSach);
            this.groupBox3.Controls.Add(this.btnXoaSach);
            this.groupBox3.Controls.Add(this.btnSuaSach);
            this.groupBox3.Controls.Add(this.btnThemSach);
            this.groupBox3.Location = new System.Drawing.Point(15, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 164);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(286, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 39);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(11, 101);
            this.txtTimSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(195, 22);
            this.txtTimSach.TabIndex = 6;
            this.txtTimSach.TextChanged += new System.EventHandler(this.txtTimSach_TextChanged);
            // 
            // lblTimSP
            // 
            this.lblTimSP.AutoSize = true;
            this.lblTimSP.Location = new System.Drawing.Point(8, 84);
            this.lblTimSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimSP.Name = "lblTimSP";
            this.lblTimSP.Size = new System.Drawing.Size(126, 16);
            this.lblTimSP.TabIndex = 5;
            this.lblTimSP.Text = "Tìm Sách Theo Tên";
            // 
            // btnTimSach
            // 
            this.btnTimSach.Location = new System.Drawing.Point(11, 126);
            this.btnTimSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(71, 31);
            this.btnTimSach.TabIndex = 4;
            this.btnTimSach.Text = "Tìm Sách";
            this.btnTimSach.UseVisualStyleBackColor = true;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(193, 22);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(87, 39);
            this.btnXoaSach.TabIndex = 3;
            this.btnXoaSach.Text = "Xóa Sách";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Location = new System.Drawing.Point(100, 22);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(87, 39);
            this.btnSuaSach.TabIndex = 3;
            this.btnSuaSach.Text = "Sửa Sách";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(7, 22);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(87, 39);
            this.btnThemSach.TabIndex = 3;
            this.btnThemSach.Text = "Thêm Sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(201)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Sach";
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLoaiSach;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label lblNXB;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblLoaiSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblDG;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Label lblTimSP;
        private System.Windows.Forms.Button btnTimSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.TextBox txtMaLoaiSach;
        private System.Windows.Forms.Label label1;
    }
}