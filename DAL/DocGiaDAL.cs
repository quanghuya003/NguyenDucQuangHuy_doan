using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenDucQuangHuy_doan.BAL;
using NguyenDucQuangHuy_doan.BEL;

namespace NguyenDucQuangHuy_doan.DAL
{
    public class DocGiaDAL : DBConnection
    {
        public List<DocGiaBEL> ReadDocGia()
        {
            List<DocGiaBEL> lstDocGia = new List<DocGiaBEL>();
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DOCGIA", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DocGiaBEL docGia = new DocGiaBEL();
                docGia.sMaDG = reader["MaDG"].ToString();
                docGia.sTenDG = reader["TenDG"].ToString();
                docGia.sGioiTinh = reader["GioiTinh"].ToString();
                docGia.dtNgaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                docGia.sDiaChi = reader["DiaChi"].ToString();
                docGia.sSDT = reader["SDT"].ToString();
                docGia.sEmail = reader["Email"].ToString();
                lstDocGia.Add(docGia); ;
            }
            return lstDocGia;
        }
        public void AdddocGia(DocGiaBEL docGia)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DOCGIA (MaDG, TenDG, GioiTinh, NgaySinh, DiaChi, SDT, Email) " +
                                                "VALUES (@MaDG, @TenDG, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email)", conn);

                cmd.Parameters.AddWithValue("@MaDG", docGia.sMaDG);
                cmd.Parameters.AddWithValue("@TenDG", docGia.sTenDG);
                cmd.Parameters.AddWithValue("@GioiTinh", docGia.sGioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", docGia.dtNgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", docGia.sDiaChi);
                cmd.Parameters.AddWithValue("@SDT", docGia.sSDT);
                cmd.Parameters.AddWithValue("@Email", docGia.sEmail);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeletedocGia(string maDG)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM DOCGIA WHERE MaDG = @MaDG", conn);
                cmd.Parameters.AddWithValue("@MaDG", maDG);
                cmd.ExecuteNonQuery();
            }
        }
        public void EditdocGia(DocGiaBEL docGia)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DOCGIA SET TenDG = @TenDG, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, " +
                                                "DiaChi = @DiaChi, SDT = @SDT, Email = @Email WHERE MaDG = @MaDG", conn);

                cmd.Parameters.AddWithValue("@TenDG", docGia.sTenDG);
                cmd.Parameters.AddWithValue("@GioiTinh", docGia.sGioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", docGia.dtNgaySinh);
                cmd.Parameters.AddWithValue("@DiaChi", docGia.sDiaChi);
                cmd.Parameters.AddWithValue("@SDT", docGia.sSDT);
                cmd.Parameters.AddWithValue("@Email", docGia.sEmail);
                cmd.Parameters.AddWithValue("@MaDG", docGia.sMaDG);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
