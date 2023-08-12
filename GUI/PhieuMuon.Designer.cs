namespace NguyenDucQuangHuy_doan.GUI
{
    partial class PhieuMuon
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
            this.grDSPM = new System.Windows.Forms.GroupBox();
            this.dgvDSPM = new System.Windows.Forms.DataGridView();
            this.grTTPM = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtIDPhieuMuon = new System.Windows.Forms.TextBox();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.cboMaDG = new System.Windows.Forms.ComboBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.lblMaPM = new System.Windows.Forms.Label();
            this.grChucNangKH = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtTimPM = new System.Windows.Forms.TextBox();
            this.lblTimPM = new System.Windows.Forms.Label();
            this.btnTimPM = new System.Windows.Forms.Button();
            this.btnXoaPM = new System.Windows.Forms.Button();
            this.btnSuaPM = new System.Windows.Forms.Button();
            this.btnThemPM = new System.Windows.Forms.Button();
            this.grDSPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPM)).BeginInit();
            this.grTTPM.SuspendLayout();
            this.grChucNangKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDSPM
            // 
            this.grDSPM.Controls.Add(this.dgvDSPM);
            this.grDSPM.Location = new System.Drawing.Point(257, 10);
            this.grDSPM.Margin = new System.Windows.Forms.Padding(2);
            this.grDSPM.Name = "grDSPM";
            this.grDSPM.Padding = new System.Windows.Forms.Padding(2);
            this.grDSPM.Size = new System.Drawing.Size(667, 500);
            this.grDSPM.TabIndex = 12;
            this.grDSPM.TabStop = false;
            this.grDSPM.Text = "Danh Sách Phiếu Mượn";
            // 
            // dgvDSPM
            // 
            this.dgvDSPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPM.Location = new System.Drawing.Point(5, 20);
            this.dgvDSPM.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSPM.Name = "dgvDSPM";
            this.dgvDSPM.RowHeadersWidth = 51;
            this.dgvDSPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPM.Size = new System.Drawing.Size(657, 476);
            this.dgvDSPM.TabIndex = 0;
            // 
            // grTTPM
            // 
            this.grTTPM.Controls.Add(this.label2);
            this.grTTPM.Controls.Add(this.dtpNgayTra);
            this.grTTPM.Controls.Add(this.txtIDPhieuMuon);
            this.grTTPM.Controls.Add(this.cboMaSach);
            this.grTTPM.Controls.Add(this.cboMaDG);
            this.grTTPM.Controls.Add(this.dtpNgayMuon);
            this.grTTPM.Controls.Add(this.lblNgayTra);
            this.grTTPM.Controls.Add(this.txtMaPM);
            this.grTTPM.Controls.Add(this.label1);
            this.grTTPM.Controls.Add(this.lblNgayMuon);
            this.grTTPM.Controls.Add(this.lblMaDG);
            this.grTTPM.Controls.Add(this.lblMaPM);
            this.grTTPM.Location = new System.Drawing.Point(9, 9);
            this.grTTPM.Margin = new System.Windows.Forms.Padding(2);
            this.grTTPM.Name = "grTTPM";
            this.grTTPM.Padding = new System.Windows.Forms.Padding(2);
            this.grTTPM.Size = new System.Drawing.Size(243, 213);
            this.grTTPM.TabIndex = 13;
            this.grTTPM.TabStop = false;
            this.grTTPM.Text = "Thông Tin Phiếu Mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "**Tô đỏ: Quá hạn trả sách";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(104, 136);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(135, 22);
            this.dtpNgayTra.TabIndex = 3;
            // 
            // txtIDPhieuMuon
            // 
            this.txtIDPhieuMuon.Location = new System.Drawing.Point(105, 136);
            this.txtIDPhieuMuon.Name = "txtIDPhieuMuon";
            this.txtIDPhieuMuon.Size = new System.Drawing.Size(100, 22);
            this.txtIDPhieuMuon.TabIndex = 6;
            this.txtIDPhieuMuon.Visible = false;
            // 
            // cboMaSach
            // 
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(104, 76);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(135, 24);
            this.cboMaSach.TabIndex = 5;
            // 
            // cboMaDG
            // 
            this.cboMaDG.FormattingEnabled = true;
            this.cboMaDG.Location = new System.Drawing.Point(104, 47);
            this.cboMaDG.Name = "cboMaDG";
            this.cboMaDG.Size = new System.Drawing.Size(135, 24);
            this.cboMaDG.TabIndex = 5;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(104, 108);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(135, 22);
            this.dtpNgayMuon.TabIndex = 3;
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(5, 136);
            this.lblNgayTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(64, 16);
            this.lblNgayTra.TabIndex = 4;
            this.lblNgayTra.Text = "Ngày Trả";
            // 
            // txtMaPM
            // 
            this.txtMaPM.Enabled = false;
            this.txtMaPM.Location = new System.Drawing.Point(104, 20);
            this.txtMaPM.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(135, 22);
            this.txtMaPM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sách";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(5, 114);
            this.lblNgayMuon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(76, 16);
            this.lblNgayMuon.TabIndex = 2;
            this.lblNgayMuon.Text = "Ngày Mượn";
            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Location = new System.Drawing.Point(5, 50);
            this.lblMaDG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Size = new System.Drawing.Size(77, 16);
            this.lblMaDG.TabIndex = 0;
            this.lblMaDG.Text = "Mã Độc Giả";
            // 
            // lblMaPM
            // 
            this.lblMaPM.AutoSize = true;
            this.lblMaPM.Location = new System.Drawing.Point(5, 22);
            this.lblMaPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaPM.Name = "lblMaPM";
            this.lblMaPM.Size = new System.Drawing.Size(99, 16);
            this.lblMaPM.TabIndex = 0;
            this.lblMaPM.Text = "Mã Phiếu Mượn";
            // 
            // grChucNangKH
            // 
            this.grChucNangKH.Controls.Add(this.btnRefresh);
            this.grChucNangKH.Controls.Add(this.txtTimPM);
            this.grChucNangKH.Controls.Add(this.lblTimPM);
            this.grChucNangKH.Controls.Add(this.btnTimPM);
            this.grChucNangKH.Controls.Add(this.btnXoaPM);
            this.grChucNangKH.Controls.Add(this.btnSuaPM);
            this.grChucNangKH.Controls.Add(this.btnThemPM);
            this.grChucNangKH.Location = new System.Drawing.Point(9, 227);
            this.grChucNangKH.Margin = new System.Windows.Forms.Padding(2);
            this.grChucNangKH.Name = "grChucNangKH";
            this.grChucNangKH.Padding = new System.Windows.Forms.Padding(2);
            this.grChucNangKH.Size = new System.Drawing.Size(243, 282);
            this.grChucNangKH.TabIndex = 14;
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
            // 
            // txtTimPM
            // 
            this.txtTimPM.Location = new System.Drawing.Point(5, 220);
            this.txtTimPM.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimPM.Name = "txtTimPM";
            this.txtTimPM.Size = new System.Drawing.Size(195, 22);
            this.txtTimPM.TabIndex = 3;
            // 
            // lblTimPM
            // 
            this.lblTimPM.AutoSize = true;
            this.lblTimPM.Location = new System.Drawing.Point(2, 203);
            this.lblTimPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimPM.Name = "lblTimPM";
            this.lblTimPM.Size = new System.Drawing.Size(103, 16);
            this.lblTimPM.TabIndex = 2;
            this.lblTimPM.Text = "Tìm Phiếu Mượn";
            // 
            // btnTimPM
            // 
            this.btnTimPM.Location = new System.Drawing.Point(5, 246);
            this.btnTimPM.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimPM.Name = "btnTimPM";
            this.btnTimPM.Size = new System.Drawing.Size(109, 32);
            this.btnTimPM.TabIndex = 1;
            this.btnTimPM.Text = "Tìm";
            this.btnTimPM.UseVisualStyleBackColor = true;
            // 
            // btnXoaPM
            // 
            this.btnXoaPM.Location = new System.Drawing.Point(5, 102);
            this.btnXoaPM.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPM.Name = "btnXoaPM";
            this.btnXoaPM.Size = new System.Drawing.Size(231, 37);
            this.btnXoaPM.TabIndex = 0;
            this.btnXoaPM.Text = "Xóa Phiếu Mượn";
            this.btnXoaPM.UseVisualStyleBackColor = true;
            // 
            // btnSuaPM
            // 
            this.btnSuaPM.Location = new System.Drawing.Point(5, 61);
            this.btnSuaPM.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPM.Name = "btnSuaPM";
            this.btnSuaPM.Size = new System.Drawing.Size(231, 37);
            this.btnSuaPM.TabIndex = 0;
            this.btnSuaPM.Text = "Sửa Phiếu Mượn";
            this.btnSuaPM.UseVisualStyleBackColor = true;
            // 
            // btnThemPM
            // 
            this.btnThemPM.Location = new System.Drawing.Point(5, 20);
            this.btnThemPM.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPM.Name = "btnThemPM";
            this.btnThemPM.Size = new System.Drawing.Size(231, 37);
            this.btnThemPM.TabIndex = 0;
            this.btnThemPM.Text = "Thêm Phiếu Mượn";
            this.btnThemPM.UseVisualStyleBackColor = true;
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(201)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.grChucNangKH);
            this.Controls.Add(this.grTTPM);
            this.Controls.Add(this.grDSPM);
            this.Name = "PhieuMuon";
            this.Text = "PhieuMuon";
            this.grDSPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPM)).EndInit();
            this.grTTPM.ResumeLayout(false);
            this.grTTPM.PerformLayout();
            this.grChucNangKH.ResumeLayout(false);
            this.grChucNangKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grDSPM;
        private System.Windows.Forms.DataGridView dgvDSPM;
        private System.Windows.Forms.GroupBox grTTPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.TextBox txtIDPhieuMuon;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.ComboBox cboMaDG;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.Label lblMaPM;
        private System.Windows.Forms.GroupBox grChucNangKH;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtTimPM;
        private System.Windows.Forms.Label lblTimPM;
        private System.Windows.Forms.Button btnTimPM;
        private System.Windows.Forms.Button btnXoaPM;
        private System.Windows.Forms.Button btnSuaPM;
        private System.Windows.Forms.Button btnThemPM;
    }
}