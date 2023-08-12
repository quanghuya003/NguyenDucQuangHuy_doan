using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using NguyenDucQuangHuy_doan.BAL;
using NguyenDucQuangHuy_doan.BEL;

namespace NguyenDucQuangHuy_doan.GUI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        NguoiDungBAL cusBAL = new NguoiDungBAL();

        private void btnDN_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTK.Text;
            string MatKhau = txtMK.Text;
            if (TenDangNhap == "" && MatKhau == "")
            {
                lblTK.Visible = true;
                lblMK.Visible = true;
                lblTB.Visible = false;
                return;
            }
            if (TenDangNhap == "")
            {
                lblTK.Visible = true;
                lblTB.Visible = false;
                return;
            }
            else
            {
                lblTK.Visible = false;
            }
            if (MatKhau == "")
            {
                lblMK.Visible = true;
                lblTB.Visible = false;
                return;
            }
            else
            {
                lblMK.Visible = false;
            }
            List<NguoiDungBEL> lstCus = cusBAL.ReadTaiKhoan();
            if (lstCus != null)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                Main f = new Main();
                this.Hide();
                f.ShowDialog();

                this.Show();
                txtTK.Clear();
                txtMK.Clear();
                txtTK.Focus();
                lblTB.Visible = false;
            }
            else
            {
                lblTB.Visible = true;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
