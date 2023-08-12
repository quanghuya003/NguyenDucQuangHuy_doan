namespace NguyenDucQuangHuy_doan.GUI
{
    partial class PhieuTra
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
            this.grDSPT = new System.Windows.Forms.GroupBox();
            this.dgvDSPT = new System.Windows.Forms.DataGridView();
            this.grTTPM = new System.Windows.Forms.GroupBox();
            this.txtIDPhieuTra = new System.Windows.Forms.TextBox();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.cboMaDG = new System.Windows.Forms.ComboBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.grChucNangPT = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtTimPT = new System.Windows.Forms.TextBox();
            this.lblTimPT = new System.Windows.Forms.Label();
            this.btnTimPT = new System.Windows.Forms.Button();
            this.btnXoaPT = new System.Windows.Forms.Button();
            this.btnSuaPT = new System.Windows.Forms.Button();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.grDSPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).BeginInit();
            this.grTTPM.SuspendLayout();
            this.grChucNangPT.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDSPT
            // 
            this.grDSPT.Controls.Add(this.dgvDSPT);
            this.grDSPT.Location = new System.Drawing.Point(257, 10);
            this.grDSPT.Margin = new System.Windows.Forms.Padding(2);
            this.grDSPT.Name = "grDSPT";
            this.grDSPT.Padding = new System.Windows.Forms.Padding(2);
            this.grDSPT.Size = new System.Drawing.Size(667, 500);
            this.grDSPT.TabIndex = 15;
            this.grDSPT.TabStop = false;
            this.grDSPT.Text = "Danh Sách Phiếu Trả";
            // 
            // dgvDSPT
            // 
            this.dgvDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPT.Location = new System.Drawing.Point(5, 20);
            this.dgvDSPT.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSPT.Name = "dgvDSPT";
            this.dgvDSPT.RowHeadersWidth = 51;
            this.dgvDSPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPT.Size = new System.Drawing.Size(657, 476);
            this.dgvDSPT.TabIndex = 0;
            // 
            // grTTPM
            // 
            this.grTTPM.Controls.Add(this.txtIDPhieuTra);
            this.grTTPM.Controls.Add(this.cboMaSach);
            this.grTTPM.Controls.Add(this.cboMaDG);
            this.grTTPM.Controls.Add(this.dtpNgayTra);
            this.grTTPM.Controls.Add(this.txtMaPT);
            this.grTTPM.Controls.Add(this.label1);
            this.grTTPM.Controls.Add(this.lblNgayTra);
            this.grTTPM.Controls.Add(this.lblMaDG);
            this.grTTPM.Controls.Add(this.lblMaPT);
            this.grTTPM.Location = new System.Drawing.Point(9, 9);
            this.grTTPM.Margin = new System.Windows.Forms.Padding(2);
            this.grTTPM.Name = "grTTPM";
            this.grTTPM.Padding = new System.Windows.Forms.Padding(2);
            this.grTTPM.Size = new System.Drawing.Size(243, 213);
            this.grTTPM.TabIndex = 16;
            this.grTTPM.TabStop = false;
            this.grTTPM.Text = "Thông Tin Phiếu Trả";
            // 
            // txtIDPhieuTra
            // 
            this.txtIDPhieuTra.Location = new System.Drawing.Point(24, 171);
            this.txtIDPhieuTra.Name = "txtIDPhieuTra";
            this.txtIDPhieuTra.Size = new System.Drawing.Size(100, 22);
            this.txtIDPhieuTra.TabIndex = 6;
            this.txtIDPhieuTra.Visible = false;
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
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(104, 108);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(135, 22);
            this.dtpNgayTra.TabIndex = 3;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Enabled = false;
            this.txtMaPT.Location = new System.Drawing.Point(104, 20);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(135, 22);
            this.txtMaPT.TabIndex = 1;
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
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(5, 114);
            this.lblNgayTra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(64, 16);
            this.lblNgayTra.TabIndex = 2;
            this.lblNgayTra.Text = "Ngày Trả";
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
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(5, 22);
            this.lblMaPT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(87, 16);
            this.lblMaPT.TabIndex = 0;
            this.lblMaPT.Text = "Mã Phiếu Trả";
            // 
            // grChucNangPT
            // 
            this.grChucNangPT.Controls.Add(this.btnRefresh);
            this.grChucNangPT.Controls.Add(this.txtTimPT);
            this.grChucNangPT.Controls.Add(this.lblTimPT);
            this.grChucNangPT.Controls.Add(this.btnTimPT);
            this.grChucNangPT.Controls.Add(this.btnXoaPT);
            this.grChucNangPT.Controls.Add(this.btnSuaPT);
            this.grChucNangPT.Controls.Add(this.btnThemPT);
            this.grChucNangPT.Location = new System.Drawing.Point(9, 227);
            this.grChucNangPT.Margin = new System.Windows.Forms.Padding(2);
            this.grChucNangPT.Name = "grChucNangPT";
            this.grChucNangPT.Padding = new System.Windows.Forms.Padding(2);
            this.grChucNangPT.Size = new System.Drawing.Size(243, 282);
            this.grChucNangPT.TabIndex = 17;
            this.grChucNangPT.TabStop = false;
            this.grChucNangPT.Text = "Chức Năng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(5, 144);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(231, 37);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtTimPT
            // 
            this.txtTimPT.Location = new System.Drawing.Point(5, 220);
            this.txtTimPT.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimPT.Name = "txtTimPT";
            this.txtTimPT.Size = new System.Drawing.Size(195, 22);
            this.txtTimPT.TabIndex = 3;
            // 
            // lblTimPT
            // 
            this.lblTimPT.AutoSize = true;
            this.lblTimPT.Location = new System.Drawing.Point(2, 203);
            this.lblTimPT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimPT.Name = "lblTimPT";
            this.lblTimPT.Size = new System.Drawing.Size(91, 16);
            this.lblTimPT.TabIndex = 2;
            this.lblTimPT.Text = "Tìm Phiếu Trả";
            // 
            // btnTimPT
            // 
            this.btnTimPT.Location = new System.Drawing.Point(5, 246);
            this.btnTimPT.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimPT.Name = "btnTimPT";
            this.btnTimPT.Size = new System.Drawing.Size(109, 32);
            this.btnTimPT.TabIndex = 1;
            this.btnTimPT.Text = "Tìm";
            this.btnTimPT.UseVisualStyleBackColor = true;
            // 
            // btnXoaPT
            // 
            this.btnXoaPT.Location = new System.Drawing.Point(5, 102);
            this.btnXoaPT.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(231, 37);
            this.btnXoaPT.TabIndex = 0;
            this.btnXoaPT.Text = "Xóa Phiếu Trả";
            this.btnXoaPT.UseVisualStyleBackColor = true;
            // 
            // btnSuaPT
            // 
            this.btnSuaPT.Location = new System.Drawing.Point(5, 61);
            this.btnSuaPT.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPT.Name = "btnSuaPT";
            this.btnSuaPT.Size = new System.Drawing.Size(231, 37);
            this.btnSuaPT.TabIndex = 0;
            this.btnSuaPT.Text = "Sửa Phiếu Trả";
            this.btnSuaPT.UseVisualStyleBackColor = true;
            // 
            // btnThemPT
            // 
            this.btnThemPT.Location = new System.Drawing.Point(5, 20);
            this.btnThemPT.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(231, 37);
            this.btnThemPT.TabIndex = 0;
            this.btnThemPT.Text = "Thêm Phiếu Trả";
            this.btnThemPT.UseVisualStyleBackColor = true;
            // 
            // PhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(201)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.grChucNangPT);
            this.Controls.Add(this.grTTPM);
            this.Controls.Add(this.grDSPT);
            this.Name = "PhieuTra";
            this.Text = "PhieuTra";
            this.grDSPT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).EndInit();
            this.grTTPM.ResumeLayout(false);
            this.grTTPM.PerformLayout();
            this.grChucNangPT.ResumeLayout(false);
            this.grChucNangPT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grDSPT;
        private System.Windows.Forms.DataGridView dgvDSPT;
        private System.Windows.Forms.GroupBox grTTPM;
        private System.Windows.Forms.TextBox txtIDPhieuTra;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.ComboBox cboMaDG;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.GroupBox grChucNangPT;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtTimPT;
        private System.Windows.Forms.Label lblTimPT;
        private System.Windows.Forms.Button btnTimPT;
        private System.Windows.Forms.Button btnXoaPT;
        private System.Windows.Forms.Button btnSuaPT;
        private System.Windows.Forms.Button btnThemPT;
    }
}