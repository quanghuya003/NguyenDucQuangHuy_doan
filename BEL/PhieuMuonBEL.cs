using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDucQuangHuy_doan.BEL
{
    public class PhieuMuonBEL
    {
        public int iIDPhieuMuon { get; set; }
        public string sMaPhieuMuon { get; set; }

        public string sMaDG{ get; set; }

        public string sTenDG { get; set; }

        public string sMaSach { get; set; }

        public string sTenSach { get; set; }

        public DateTime dtNgayMuon { get; set; }

        public DateTime dtNgayTra { get; set; }
    }
}
