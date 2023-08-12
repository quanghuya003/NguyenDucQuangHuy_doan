using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenDucQuangHuy_doan.BEL;
using NguyenDucQuangHuy_doan.DAL;

namespace NguyenDucQuangHuy_doan.BAL
{
    public class PhieuMuonBAL
    {
        private PhieuMuonDAL dal = new PhieuMuonDAL();

        public List<PhieuMuonBEL> ReadPhieuMuon()
        {
            List<PhieuMuonBEL> lstPhieuMuon = dal.ReadPhieuMuon();
            return lstPhieuMuon;
        }

        public void AddPhieuMuon(PhieuMuonBEL phieuMuon)
        {
            dal.AddPhieuMuon(phieuMuon);
        }

        public void DeletePhieuMuon(int iIDPhieuMuon)
        {
            dal.DeletePhieuMuon(iIDPhieuMuon);
        }

        public void EditPhieuMuon(PhieuMuonBEL phieuMuon)
        {
            dal.EditPhieuMuon(phieuMuon);
        }
    }
}
