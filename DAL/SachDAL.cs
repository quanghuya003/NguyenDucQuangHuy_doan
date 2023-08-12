using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using NguyenDucQuangHuy_doan.BEL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace NguyenDucQuangHuy_doan.DAL
{
    public class SachDAL : DBConnection
    {
        public List<SachBEL> ReadSach()
        {
            List<SachBEL> lstSach = new List<SachBEL>();
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SACH", conn); // Assuming "SACH" is the table name for books
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                SachBEL sach = new SachBEL();
                sach.sMaSach = reader["MaSach"].ToString();
                sach.sTenSach = reader["TenSach"].ToString();
                sach.sTacGia = reader["TacGia"].ToString();
                sach.sMaLoaiSach = reader["MaLoaiSach"].ToString();
                sach.sNhaXuatBan = reader["NhaXuatBan"].ToString();
                sach.fGiaSach = Convert.ToSingle(reader["GiaSach"]);
                sach.iSoLuong = Convert.ToInt32(reader["SoLuong"]);
                sach.sTinhTrang = reader["TinhTrang"].ToString();
                lstSach.Add(sach);
            }
            conn.Close();
            return lstSach;
        }

        public void AddSach(SachBEL sach)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();

            string query = "INSERT INTO SACH (MaSach, TenSach, TacGia, MaLoaiSach, NhaXuatBan, GiaSach, SoLuong, TinhTrang) " +
                           "VALUES (@MaSach, @TenSach, @TacGia, @MaLoaiSach, @NhaXuatBan, @GiaSach, @SoLuong, @TinhTrang)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSach", sach.sMaSach);
            cmd.Parameters.AddWithValue("@TenSach", sach.sTenSach);
            cmd.Parameters.AddWithValue("@TacGia", sach.sTacGia);
            cmd.Parameters.AddWithValue("@MaLoaiSach", sach.sMaLoaiSach);
            cmd.Parameters.AddWithValue("@NhaXuatBan", sach.sNhaXuatBan);
            cmd.Parameters.AddWithValue("@GiaSach", sach.fGiaSach);
            cmd.Parameters.AddWithValue("@SoLuong", sach.iSoLuong);
            cmd.Parameters.AddWithValue("@TinhTrang", sach.sTinhTrang);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteSach(string maSach)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();

            string query = "DELETE FROM SACH WHERE MaSach = @MaSach";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSach", maSach);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditSach(SachBEL sach)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();

            string query = "UPDATE SACH SET TenSach = @TenSach, TacGia = @TacGia, MaLoaiSach = @MaLoaiSach, NhaXuatBan = @NhaXuatBan, GiaSach = @GiaSach, SoLuong = @SoLuong, TinhTrang = @TinhTrang WHERE MaSach = @MaSach";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TenSach", sach.sTenSach);
            cmd.Parameters.AddWithValue("@TacGia", sach.sTacGia);
            cmd.Parameters.AddWithValue("@MaLoaiSach", sach.sMaLoaiSach);
            cmd.Parameters.AddWithValue("@NhaXuatBan", sach.sNhaXuatBan);
            cmd.Parameters.AddWithValue("@GiaSach", sach.fGiaSach);
            cmd.Parameters.AddWithValue("@SoLuong", sach.iSoLuong);
            cmd.Parameters.AddWithValue("@TinhTrang", sach.sTinhTrang);
            cmd.Parameters.AddWithValue("@MaSach", sach.sMaSach);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
