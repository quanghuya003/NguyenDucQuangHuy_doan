using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenDucQuangHuy_doan.BEL;
using NguyenDucQuangHuy_doan.DAL;

namespace NguyenDucQuangHuy_doan.BAL
{
    public class SachBAL
    {
        private SachDAL dal = new SachDAL();
        public List<SachBEL> ReadSach()
        {
            List<SachBEL> lstSach = dal.ReadSach();
            return lstSach;
        }

        public void AddSach(SachBEL sach)
        {
            dal.AddSach(sach);
        }

        public void DeleteSach(string maSach)
        {
            dal.DeleteSach(maSach);
        }

        public void EditSach(SachBEL sach)
        {
            dal.EditSach(sach);
        }
    }
}
