using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenDucQuangHuy_doan.BEL;
using NguyenDucQuangHuy_doan.DAL;

namespace NguyenDucQuangHuy_doan.BAL
{
    public class LoaiSachBAL
    {
        private LoaiSachDAL dal = new LoaiSachDAL();

        public List<LoaiSachBEL> ReadLoaiSach()
        {
            List<LoaiSachBEL> lstLoaiSach = dal.ReadLoaiSach();
            return lstLoaiSach;
        }

        public void AddLoaiSach(LoaiSachBEL loaiSach)
        {
            dal.AddLoaiSach(loaiSach);
        }

        public void DeleteLoaiSach(string maLoaiSach)
        {
            dal.DeleteLoaiSach(maLoaiSach);
        }

        public void EditLoaiSach(LoaiSachBEL loaiSach)
        {
            dal.EditLoaiSach(loaiSach);
        }
    }
}
