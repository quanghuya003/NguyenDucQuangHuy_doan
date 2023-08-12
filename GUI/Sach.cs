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
using NguyenDucQuangHuy_doan.DAL;

namespace NguyenDucQuangHuy_doan.GUI
{
    public partial class Sach : Form
    {
        SachBAL sachBAL = new SachBAL();
        LoaiSachBAL loaiSachBAL = new LoaiSachBAL();
        private string selectedMaLoaiSach = "";

        public Sach()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            LoadDSSach();
            LoadLoaiSachComboBox();
        }
        private void LoadLoaiSachComboBox()
        {
            List<LoaiSachBEL> lstLoaiSach = loaiSachBAL.ReadLoaiSach();
            cboLoaiSach.DataSource = lstLoaiSach;
            cboLoaiSach.ValueMember = "sMaLoaiSach";
        }
        private void LoadDSSach()
        {
            List<SachBEL> lstSach = sachBAL.ReadSach();
            dgvDSSach.DataSource = lstSach;
        }

        private void dgvDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDSSach.Rows[e.RowIndex];
                string maSach = selectedRow.Cells["sMaSach"].Value.ToString();
                string tenSach = selectedRow.Cells["sTenSach"].Value.ToString();
                string tacGia = selectedRow.Cells["sTacGia"].Value.ToString();
                string maloaisach = selectedRow.Cells["sMaLoaiSach"].Value.ToString();
                string nhaXuatBan = selectedRow.Cells["sNhaXuatBan"].Value.ToString();
                float giaSach = Convert.ToSingle(selectedRow.Cells["fGiaSach"].Value);
                int soLuong = Convert.ToInt32(selectedRow.Cells["iSoLuong"].Value);
                string tinhTrang = selectedRow.Cells["sTinhTrang"].Value.ToString();
                

                // Cập nhật các điều khiển với dữ liệu đã chọn
                txtMaSach.Text = maSach;
                txtTenSach.Text = tenSach;
                txtTacGia.Text = tacGia;
                txtMaLoaiSach.Text = maloaisach;
                txtNXB.Text = nhaXuatBan;
                txtDonGia.Text = giaSach.ToString();
                txtSoLuong.Text = soLuong.ToString();
                txtTinhTrang.Text = tinhTrang;
            }
        }
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSach.Text) && !string.IsNullOrEmpty(txtTenSach.Text) && !string.IsNullOrEmpty(txtTacGia.Text)
        && !string.IsNullOrEmpty(txtMaLoaiSach.Text) && !string.IsNullOrEmpty(txtNXB.Text) && !string.IsNullOrEmpty(txtDonGia.Text)
        && !string.IsNullOrEmpty(txtSoLuong.Text) && !string.IsNullOrEmpty(txtTinhTrang.Text))
            {
                SachBEL sach = new SachBEL();
                sach.sMaSach = txtMaSach.Text;
                sach.sTenSach = txtTenSach.Text;
                sach.sTacGia = txtTacGia.Text;
                sach.sMaLoaiSach = txtMaLoaiSach.Text;
                sach.sNhaXuatBan = txtNXB.Text;
                sach.fGiaSach = Convert.ToSingle(txtDonGia.Text);
                sach.iSoLuong = Convert.ToInt32(txtSoLuong.Text);
                sach.sTinhTrang = txtTinhTrang.Text;

                sachBAL.AddSach(sach);
                LoadDSSach();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sách.");
            }
        }
        private void ClearInputFields()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtMaLoaiSach.Text = "";
            txtNXB.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtTinhTrang.Text = "";
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSach.Text))
            {
                SachBEL sach = new SachBEL();
                sach.sMaSach = txtMaSach.Text;
                sach.sTenSach = txtTenSach.Text;
                sach.sTacGia = txtTacGia.Text;
                sach.sMaLoaiSach = txtMaLoaiSach.Text;
                sach.sNhaXuatBan = txtNXB.Text;
                sach.fGiaSach = Convert.ToSingle(txtDonGia.Text);
                sach.iSoLuong = Convert.ToInt32(txtSoLuong.Text);
                sach.sTinhTrang = txtTinhTrang.Text;

                sachBAL.EditSach(sach);
                LoadDSSach();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa.");
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSach.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maSach = txtMaSach.Text;
                    sachBAL.DeleteSach(maSach);
                    LoadDSSach();
                    ClearInputFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.");
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDSSach();
            ClearInputFields();
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            string maSachCanTim = txtTimSach.Text;

            List<SachBEL> lstSach = sachBAL.ReadSach();
            List<SachBEL> ketQuaTimKiem = new List<SachBEL>();

            foreach (SachBEL sach in lstSach)
            {
                if (sach.sMaSach == maSachCanTim)
                {
                    ketQuaTimKiem.Add(sach);
                }
            }
            dgvDSSach.DataSource = ketQuaTimKiem;
            ClearInputFields();
        }
        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiSach.SelectedIndex >= 0)
            {
                selectedMaLoaiSach = cboLoaiSach.SelectedValue.ToString();
            }
        }
    }
}
