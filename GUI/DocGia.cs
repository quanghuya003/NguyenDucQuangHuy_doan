using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenDucQuangHuy_doan.BAL;
using NguyenDucQuangHuy_doan.BEL;

namespace NguyenDucQuangHuy_doan.GUI
{
    public partial class DocGia : Form
    {
        private DocGiaBAL docGiaBAL = new DocGiaBAL();
        public DocGia()
        {
            InitializeComponent();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            LoadDSDocGia();
        }
        private void LoadDSDocGia()
        {
            List<DocGiaBEL> lstDocGia = docGiaBAL.ReadDocGia();
            dgvDSDG.DataSource = lstDocGia;
        }

        private void dgvDSDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSDG.Rows[e.RowIndex];
                txtMaDG.Text = row.Cells["sMaDG"].Value.ToString();
                txtTenDG.Text = row.Cells["sTenDG"].Value.ToString();
                if (row.Cells["sGioiTinh"].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["dtNgaySinh"].Value);
                txtDCDG.Text = row.Cells["sDiaChi"].Value.ToString();
                txtSDTDG.Text = row.Cells["sSDT"].Value.ToString();
                txtEmailDG.Text = row.Cells["sEmail"].Value.ToString();
            }
        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDG.Text) || string.IsNullOrEmpty(txtTenDG.Text) ||
                string.IsNullOrEmpty(txtDCDG.Text) || string.IsNullOrEmpty(txtSDTDG.Text) ||
                string.IsNullOrEmpty(txtEmailDG.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin độc giả.");
                return;
            }

            DocGiaBEL docGia = new DocGiaBEL();
            docGia.sMaDG = txtMaDG.Text;
            docGia.sTenDG = txtTenDG.Text;
            docGia.sGioiTinh = radNam.Checked ? "Nam" : "Nữ";
            docGia.dtNgaySinh = dtpNgaySinh.Value;
            docGia.sDiaChi = txtDCDG.Text;
            docGia.sSDT = txtSDTDG.Text;
            docGia.sEmail = txtEmailDG.Text;

            docGiaBAL.AdddocGia(docGia);
            LoadDSDocGia();
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            txtDCDG.Text = "";
            txtSDTDG.Text = "";
            txtEmailDG.Text = "";
        }

        private void btnSuaDG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDG.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa.");
                return;
            }

            DocGiaBEL docGia = new DocGiaBEL();
            docGia.sMaDG = txtMaDG.Text;
            docGia.sTenDG = txtTenDG.Text;
            docGia.sGioiTinh = radNam.Checked ? "Nam" : "Nữ";
            docGia.dtNgaySinh = dtpNgaySinh.Value;
            docGia.sDiaChi = txtDCDG.Text;
            docGia.sSDT = txtSDTDG.Text;
            docGia.sEmail = txtEmailDG.Text;

            docGiaBAL.EditdocGia(docGia);
            LoadDSDocGia();
            ClearInputFields();
        }

        private void btnXoaDG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDG.Text))
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa độc giả này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maDG = txtMaDG.Text;
                docGiaBAL.DeletedocGia(maDG);
                LoadDSDocGia();
                ClearInputFields();
            }
        }

        private void btnTimDG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimkiem.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.");
                return;
            }

            string tenDGTimKiem = txtTimkiem.Text;
            List<DocGiaBEL> lstDocGia = docGiaBAL.ReadDocGia();
            List<DocGiaBEL> ketQuaTimKiem = new List<DocGiaBEL>();

            foreach (DocGiaBEL docGia in lstDocGia)
            {
                if (docGia.sTenDG.ToLower().Contains(tenDGTimKiem.ToLower()))
                {
                    ketQuaTimKiem.Add(docGia);
                }
            }
            dgvDSDG.DataSource = ketQuaTimKiem;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadDSDocGia();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
