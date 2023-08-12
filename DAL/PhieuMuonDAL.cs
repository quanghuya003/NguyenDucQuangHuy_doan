using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenDucQuangHuy_doan.BEL;

namespace NguyenDucQuangHuy_doan.DAL
{
    public class PhieuMuonDAL : DBConnection
    {
        public List<PhieuMuonBEL> ReadPhieuMuon()
        {
            List<PhieuMuonBEL> lstPhieuMuon = new List<PhieuMuonBEL>();
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEUMUON", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PhieuMuonBEL phieuMuon = new PhieuMuonBEL();
                    phieuMuon.iIDPhieuMuon = Convert.ToInt32(reader["IDPhieuMuon"]);
                    phieuMuon.sMaPhieuMuon = reader["MaPhieuMuon"].ToString();
                    phieuMuon.sMaDG = reader["MaDG"].ToString();
                    phieuMuon.sTenDG = reader["TenDG"].ToString();
                    phieuMuon.sMaSach = reader["MaSach"].ToString();
                    phieuMuon.sTenSach = reader["TenSach"].ToString();
                    phieuMuon.dtNgayMuon = Convert.ToDateTime(reader["NgayMuon"]);
                    phieuMuon.dtNgayTra = Convert.ToDateTime(reader["NgayTra"]);
                    lstPhieuMuon.Add(phieuMuon);
                }
            }
            return lstPhieuMuon;
        }
        public void AddPhieuMuon(PhieuMuonBEL phieuMuon)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PHIEUMUON (MaPhieuMuon, MaDG, TenDG, MaSach, TenSach, NgayMuon, NgayTra) VALUES (@MaPhieuMuon, @MaDG, @TenDG, @MaSach, @TenSach, @NgayMuon, @NgayTra)", conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", phieuMuon.sMaPhieuMuon);
                cmd.Parameters.AddWithValue("@MaDG", phieuMuon.sMaDG);
                cmd.Parameters.AddWithValue("@TenDG", phieuMuon.sTenDG);
                cmd.Parameters.AddWithValue("@MaSach", phieuMuon.sMaSach);
                cmd.Parameters.AddWithValue("@TenSach", phieuMuon.sTenSach);
                cmd.Parameters.AddWithValue("@NgayMuon", phieuMuon.dtNgayMuon);
                cmd.Parameters.AddWithValue("@NgayTra", phieuMuon.dtNgayTra);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeletePhieuMuon(int iIDPhieuMuon)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM PHIEUMUON WHERE IDPhieuMuon = @IDPhieuMuon", conn);
                cmd.Parameters.AddWithValue("@IDPhieuMuon", iIDPhieuMuon);
                cmd.ExecuteNonQuery();
            }
        }
        public void EditPhieuMuon(PhieuMuonBEL phieuMuon)
        {
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE PHIEUMUON SET MaPhieuMuon = @MaPhieuMuon, MaDG = @MaDG, TenDG = @TenDG, MaSach = @MaSach, TenSach = @TenSach, NgayMuon = @NgayMuon, NgayTra = @NgayTra WHERE IDPhieuMuon = @IDPhieuMuon", conn);
                cmd.Parameters.AddWithValue("@MaPhieuMuon", phieuMuon.sMaPhieuMuon);
                cmd.Parameters.AddWithValue("@MaDG", phieuMuon.sMaDG);
                cmd.Parameters.AddWithValue("@TenDG", phieuMuon.sTenDG);
                cmd.Parameters.AddWithValue("@MaSach", phieuMuon.sMaSach);
                cmd.Parameters.AddWithValue("@TenSach", phieuMuon.sTenSach);
                cmd.Parameters.AddWithValue("@NgayMuon", phieuMuon.dtNgayMuon);
                cmd.Parameters.AddWithValue("@NgayTra", phieuMuon.dtNgayTra);
                cmd.Parameters.AddWithValue("@IDPhieuMuon", phieuMuon.iIDPhieuMuon);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

