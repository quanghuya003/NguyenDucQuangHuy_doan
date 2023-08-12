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
    public partial class LoaiSach : Form
    {
        LoaiSachBAL loaiSachBAL = new LoaiSachBAL();


        public LoaiSach()
        {
            InitializeComponent();
        }

        private void btnThemLS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiSach.Text) || string.IsNullOrEmpty(txtTenLoaiSach.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin loại sách.");
                return;
            }

            LoaiSachBEL loaiSach = new LoaiSachBEL();
            loaiSach.sMaLoaiSach = txtMaLoaiSach.Text;
            loaiSach.sTenLoaiSach = txtTenLoaiSach.Text;

            loaiSachBAL.AddLoaiSach(loaiSach);
            LoadDSLS();
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            txtMaLoaiSach.Text = "";
            txtTenLoaiSach.Text = "";
        }


        private void LoaiSach_Load(object sender, EventArgs e)
        {
            LoadDSLS();
        }
        private void LoadDSLS()
        {
            List<LoaiSachBEL> lstLs = loaiSachBAL.ReadLoaiSach();
            dgvDSLS.DataSource = lstLs;
        }

        private void btnSuaLS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiSach.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sách cần sửa.");
                return;
            }

            LoaiSachBEL loaiSach = new LoaiSachBEL();
            loaiSach.sMaLoaiSach = txtMaLoaiSach.Text;
            loaiSach.sTenLoaiSach = txtTenLoaiSach.Text;

            loaiSachBAL.EditLoaiSach(loaiSach);
            LoadDSLS();
            ClearInputFields();
        }

        private void btnXoaLS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiSach.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sách cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa loại sách này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maLoaiSach = txtMaLoaiSach.Text;
                loaiSachBAL.DeleteLoaiSach(maLoaiSach);
                LoadDSLS();
                ClearInputFields();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadDSLS();
        }

        private void btnTimLS_Click(object sender, EventArgs e)
        {
            string maLoaiSachCanTim = txtTimLoaiSach.Text;
            List<LoaiSachBEL> lstLoaiSach = loaiSachBAL.ReadLoaiSach();
            List<LoaiSachBEL> ketQuaTimKiem = new List<LoaiSachBEL>();
            foreach (LoaiSachBEL loaiSach in lstLoaiSach)
            {
                if (loaiSach.sMaLoaiSach == maLoaiSachCanTim)
                {
                    ketQuaTimKiem.Add(loaiSach);
                }
            }
            dgvDSLS.DataSource = ketQuaTimKiem;
        }

        private void txtTimLoaiSach_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvDSLS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSLS.Rows[e.RowIndex];
                txtMaLoaiSach.Text = row.Cells["sMaLoaiSach"].Value.ToString();
                txtTenLoaiSach.Text = row.Cells["sTenLoaiSach"].Value.ToString();
            }
        }
    }
}
