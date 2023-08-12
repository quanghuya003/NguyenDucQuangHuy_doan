using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenDucQuangHuy_doan.BEL;


namespace NguyenDucQuangHuy_doan.DAL
{
    public class NguoiDungDAL : DBConnection
    {
        public List<NguoiDungBEL> ReadTaiKhoan()
        {
            SqlConnection conn = CreateConnection();

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOIDUNG", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<NguoiDungBEL> lstCus = new List<NguoiDungBEL>();
            while (reader.Read())
            {
                NguoiDungBEL cus = new NguoiDungBEL();
                cus.sTenDangNhap = reader["TenDangNhap"].ToString();
                cus.sTenHienThi = reader["TenHienThi"].ToString();
                cus.sMatKhau = reader["MatKhau"].ToString();
                cus.iLoai = reader["Loai"].ToString();
                lstCus.Add(cus);
            }
            conn.Close();
            return lstCus;
        }
    } 
}