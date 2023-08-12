using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenDucQuangHuy_doan.BEL;

namespace NguyenDucQuangHuy_doan.DAL
{
    public class LoaiSachDAL : DBConnection
    {
            public List<LoaiSachBEL> ReadLoaiSach()
            {
                List<LoaiSachBEL> lstLoaiSach = new List<LoaiSachBEL>();
                SqlConnection conn = CreateConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LOAISACH", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LoaiSachBEL loaiSach = new LoaiSachBEL();
                    loaiSach.sMaLoaiSach = reader["MaLoaiSach"].ToString();
                    loaiSach.sTenLoaiSach = reader["TenLoaiSach"].ToString();
                    lstLoaiSach.Add(loaiSach);
                }
                conn.Close();
                return lstLoaiSach;
            }

        public void AddLoaiSach(LoaiSachBEL loaiSach)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO LOAISACH (MaLoaiSach, TenLoaiSach) " +
                                                "VALUES (@MaLoaiSach, @TenLoaiSach)", conn);

                cmd.Parameters.AddWithValue("@MaLoaiSach", loaiSach.sMaLoaiSach);
                cmd.Parameters.AddWithValue("@TenLoaiSach", loaiSach.sTenLoaiSach);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteLoaiSach(string maLoaiSach)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM LOAISACH WHERE MaLoaiSach = @MaLoaiSach", conn);
                cmd.Parameters.AddWithValue("@MaLoaiSach", maLoaiSach);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditLoaiSach(LoaiSachBEL loaiSach)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LOAISACH SET TenLoaiSach = @TenLoaiSach WHERE MaLoaiSach = @MaLoaiSach", conn);

                cmd.Parameters.AddWithValue("@TenLoaiSach", loaiSach.sTenLoaiSach);
                cmd.Parameters.AddWithValue("@MaLoaiSach", loaiSach.sMaLoaiSach);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
