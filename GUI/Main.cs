﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDucQuangHuy_doan.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btDocGia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DocGia());

        }

        private void btLoaiSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoaiSach());

        }

        private void btSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sach());

        }
    }
}
