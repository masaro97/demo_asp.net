using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models.FW;

namespace Models
{
    public class UserModel
    {
        private QuanLySinhVien context = null;
        public UserModel()
        {
            context = new QuanLySinhVien();
        }
        public bool login(string taikhoan, string matkhau)
        {
            object[] sqlpara=
            {
                new SqlParameter ("@Taikhoan",taikhoan),
                new SqlParameter ("@Matkhau",matkhau),
            };
            var res = context.Database.SqlQuery<bool>("sp_account_login @Taikhoan,@Matkhau", sqlpara).SingleOrDefault();
            return res;
        }
    }
}
