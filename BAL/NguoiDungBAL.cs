using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenDucQuangHuy_doan.BEL;
using NguyenDucQuangHuy_doan.DAL;

namespace NguyenDucQuangHuy_doan.BAL
{
    public class NguoiDungBAL
    {
        NguoiDungDAL dal = new NguoiDungDAL();
        public List<NguoiDungBEL> ReadTaiKhoan()
        {
            List<NguoiDungBEL> lstCus = dal.ReadTaiKhoan();
            return lstCus;
        }
    }
}
