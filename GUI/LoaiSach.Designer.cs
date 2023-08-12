namespace NguyenDucQuangHuy_doan.GUI
{
    partial class LoaiSach
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
            this.grDSKH = new System.Windows.Forms.GroupBox();
            this.dgvDSLS = new System.Windows.Forms.DataGridView();
            this.grTTLS = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiSach = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSach = new System.Windows.Forms.TextBox();
            this.lblTenLoaiSach = new System.Windows.Forms.Label();
            this.lblMaLoaiSach = new System.Windows.Forms.Label();
            this.grChucNangKH = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtTimLoaiSach = new System.Windows.Forms.TextBox();
            this.lblTimDG = new System.Windows.Forms.Label();
            this.btnTimLS = new System.Windows.Forms.Button();
            this.btnXoaLS = new System.Windows.Forms.Button();
            this.btnSuaLS = new System.Windows.Forms.Button();
            this.btnThemLS = new System.Windows.Forms.Button();
            this.grDSKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLS)).BeginInit();
            this.grTTLS.SuspendLayout();
            this.grChucNangKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDSKH
            // 
            this.grDSKH.Controls.Add(this.dgvDSLS);
            this.grDSKH.Location = new System.Drawing.Point(257, 10);
            this.grDSKH.Margin = new System.Windows.Forms.Padding(2);
            this.grDSKH.Name = "grDSKH";
            this.grDSKH.Padding = new System.Windows.Forms.Padding(2);
            this.grDSKH.Size = new System.Drawing.Size(667, 500);
            this.grDSKH.TabIndex = 13;
            this.grDSKH.TabStop = false;
            this.grDSKH.Text = "Danh Sách Loại Sách";
            // 
            // dgvDSLS
            // 
            this.dgvDSLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLS.Location = new System.Drawing.Point(5, 20);
            this.dgvDSLS.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSLS.Name = "dgvDSLS";
            this.dgvDSLS.RowHeadersWidth = 51;
            this.dgvDSLS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLS.Size = new System.Drawing.Size(657, 476);
            this.dgvDSLS.TabIndex = 0;
            this.dgvDSLS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLS_CellContentClick);
            // 
            // grTTLS
            // 
            this.grTTLS.Controls.Add(this.txtTenLoaiSach);
            this.grTTLS.Controls.Add(this.txtMaLoaiSach);
            this.grTTLS.Controls.Add(this.lblTenLoaiSach);
            this.grTTLS.Controls.Add(this.lblMaLoaiSach);
            this.grTTLS.Location = new System.Drawing.Point(9, 9);
            this.grTTLS.Margin = new System.Windows.Forms.Padding(2);
            this.grTTLS.Name = "grTTLS";
            this.grTTLS.Padding = new System.Windows.Forms.Padding(2);
            this.grTTLS.Size = new System.Drawing.Size(243, 213);
            this.grTTLS.TabIndex = 14;
            this.grTTLS.TabStop = false;
            this.grTTLS.Text = "Thông Tin Loại Sách";
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Location = new System.Drawing.Point(104, 45);
            this.txtTenLoaiSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Size = new System.Drawing.Size(135, 22);
            this.txtTenLoaiSach.TabIndex = 1;
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Location = new System.Drawing.Point(104, 20);
            this.txtMaLoaiSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.Size = new System.Drawing.Size(135, 22);
            this.txtMaLoaiSach.TabIndex = 1;
            // 
            // lblTenLoaiSach
            // 
            this.lblTenLoaiSach.AutoSize = true;
            this.lblTenLoaiSach.Location = new System.Drawing.Point(5, 47);
            this.lblTenLoaiSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenLoaiSach.Name = "lblTenLoaiSach";
            this.lblTenLoaiSach.Size = new System.Drawing.Size(94, 16);
            this.lblTenLoaiSach.TabIndex = 0;
            this.lblTenLoaiSach.Text = "Tên Loại Sách";
            // 
            // lblMaLoaiSach
            // 
            this.lblMaLoaiSach.AutoSize = true;
            this.lblMaLoaiSach.Location = new System.Drawing.Point(5, 22);
            this.lblMaLoaiSach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaLoaiSach.Name = "lblMaLoaiSach";
            this.lblMaLoaiSach.Size = new System.Drawing.Size(89, 16);
            this.lblMaLoaiSach.TabIndex = 0;
            this.lblMaLoaiSach.Text = "Mã Loại Sách";
            // 
            // grChucNangKH
            // 
            this.grChucNangKH.Controls.Add(this.btnRefresh);
            this.grChucNangKH.Controls.Add(this.txtTimLoaiSach);
            this.grChucNangKH.Controls.Add(this.lblTimDG);
            this.grChucNangKH.Controls.Add(this.btnTimLS);
            this.grChucNangKH.Controls.Add(this.btnXoaLS);
            this.grChucNangKH.Controls.Add(this.btnSuaLS);
            this.grChucNangKH.Controls.Add(this.btnThemLS);
            this.grChucNangKH.Location = new System.Drawing.Point(9, 227);
            this.grChucNangKH.Margin = new System.Windows.Forms.Padding(2);
            this.grChucNangKH.Name = "grChucNangKH";
            this.grChucNangKH.Padding = new System.Windows.Forms.Padding(2);
            this.grChucNangKH.Size = new System.Drawing.Size(243, 282);
            this.grChucNangKH.TabIndex = 15;
            this.grChucNangKH.TabStop = false;
            this.grChucNangKH.Text = "Chức Năng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(5, 144);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(231, 37);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtTimLoaiSach
            // 
            this.txtTimLoaiSach.Location = new System.Drawing.Point(5, 220);
            this.txtTimLoaiSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimLoaiSach.Name = "txtTimLoaiSach";
            this.txtTimLoaiSach.Size = new System.Drawing.Size(195, 22);
            this.txtTimLoaiSach.TabIndex = 3;
            this.txtTimLoaiSach.TextChanged += new System.EventHandler(this.txtTimLoaiSach_TextChanged);
            // 
            // lblTimDG
            // 
            this.lblTimDG.AutoSize = true;
            this.lblTimDG.Location = new System.Drawing.Point(2, 203);
            this.lblTimDG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimDG.Name = "lblTimDG";
            this.lblTimDG.Size = new System.Drawing.Size(155, 16);
            this.lblTimDG.TabIndex = 2;
            this.lblTimDG.Text = "Tìm Loại Sách Theo Tên";
            // 
            // btnTimLS
            // 
            this.btnTimLS.Location = new System.Drawing.Point(5, 246);
            this.btnTimLS.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimLS.Name = "btnTimLS";
            this.btnTimLS.Size = new System.Drawing.Size(109, 32);
            this.btnTimLS.TabIndex = 1;
            this.btnTimLS.Text = "Tìm Loại Sách";
            this.btnTimLS.UseVisualStyleBackColor = true;
            this.btnTimLS.Click += new System.EventHandler(this.btnTimLS_Click);
            // 
            // btnXoaLS
            // 
            this.btnXoaLS.Location = new System.Drawing.Point(5, 102);
            this.btnXoaLS.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaLS.Name = "btnXoaLS";
            this.btnXoaLS.Size = new System.Drawing.Size(231, 37);
            this.btnXoaLS.TabIndex = 0;
            this.btnXoaLS.Text = "Xóa Loại Sách";
            this.btnXoaLS.UseVisualStyleBackColor = true;
            this.btnXoaLS.Click += new System.EventHandler(this.btnXoaLS_Click);
            // 
            // btnSuaLS
            // 
            this.btnSuaLS.Location = new System.Drawing.Point(5, 61);
            this.btnSuaLS.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaLS.Name = "btnSuaLS";
            this.btnSuaLS.Size = new System.Drawing.Size(231, 37);
            this.btnSuaLS.TabIndex = 0;
            this.btnSuaLS.Text = "Sửa Loại Sách";
            this.btnSuaLS.UseVisualStyleBackColor = true;
            this.btnSuaLS.Click += new System.EventHandler(this.btnSuaLS_Click);
            // 
            // btnThemLS
            // 
            this.btnThemLS.Location = new System.Drawing.Point(5, 20);
            this.btnThemLS.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemLS.Name = "btnThemLS";
            this.btnThemLS.Size = new System.Drawing.Size(231, 37);
            this.btnThemLS.TabIndex = 0;
            this.btnThemLS.Text = "Thêm Loại Sách";
            this.btnThemLS.UseVisualStyleBackColor = true;
            this.btnThemLS.Click += new System.EventHandler(this.btnThemLS_Click);
            // 
            // LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(201)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.grChucNangKH);
            this.Controls.Add(this.grTTLS);
            this.Controls.Add(this.grDSKH);
            this.Name = "LoaiSach";
            this.Text = "LoaiSach";
            this.Load += new System.EventHandler(this.LoaiSach_Load);
            this.grDSKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLS)).EndInit();
            this.grTTLS.ResumeLayout(false);
            this.grTTLS.PerformLayout();
            this.grChucNangKH.ResumeLayout(false);
            this.grChucNangKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grDSKH;
        private System.Windows.Forms.DataGridView dgvDSLS;
        private System.Windows.Forms.GroupBox grTTLS;
        private System.Windows.Forms.TextBox txtTenLoaiSach;
        private System.Windows.Forms.TextBox txtMaLoaiSach;
        private System.Windows.Forms.Label lblTenLoaiSach;
        private System.Windows.Forms.Label lblMaLoaiSach;
        private System.Windows.Forms.GroupBox grChucNangKH;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtTimLoaiSach;
        private System.Windows.Forms.Label lblTimDG;
        private System.Windows.Forms.Button btnTimLS;
        private System.Windows.Forms.Button btnXoaLS;
        private System.Windows.Forms.Button btnSuaLS;
        private System.Windows.Forms.Button btnThemLS;
    }
}