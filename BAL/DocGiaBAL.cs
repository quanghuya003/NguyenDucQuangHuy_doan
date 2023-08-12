using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenDucQuangHuy_doan.BEL;
using NguyenDucQuangHuy_doan.DAL;

namespace NguyenDucQuangHuy_doan.BAL
{
    public class DocGiaBAL
    {
        private DocGiaDAL dal = new DocGiaDAL();

        public bool CheckDocGiaExists(string docGia)
        {
            List<DocGiaBEL> lstDocGia = ReadDocGia();

            foreach (DocGiaBEL dg in lstDocGia)
            {
                if (dg.sMaDG == docGia)
                {
                    return true;
                }
            }
            return false;
        }

        public List<DocGiaBEL> ReadDocGia()
        {
            List<DocGiaBEL> lstDocGia = dal.ReadDocGia();
            return lstDocGia;
        }

        public void AdddocGia(DocGiaBEL docGia)
        {
            dal.AdddocGia(docGia);
        }

        public void DeletedocGia(string maDG)
        {
            dal.DeletedocGia(maDG);
        }


        public void EditdocGia(DocGiaBEL docGia)
        {
            dal.EditdocGia(docGia);
        }
    }
}
