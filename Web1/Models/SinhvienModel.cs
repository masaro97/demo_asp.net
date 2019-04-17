using Models.FW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SinhvienModel
    {
         private QuanLySinhVien context = null;
        public SinhvienModel()
        {
            context = new QuanLySinhVien();
        }
        public List<SINHVIEN> ListAll()
        {
            var list = context.Database.SqlQuery<SINHVIEN>("sp_SinhVien_ListAll").ToList();
            return list;
        }

        public object ListAl()
        {
            throw new NotImplementedException();
        }
    }
}
