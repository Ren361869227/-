using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDal
    {
        //登录
        public int Login(R_Login r)
        {
            string sql = $"select count(*) from  R_Login where LName='{r.LName}'and LPwd='{r.LPwd}' ";
            return (int)DBHelper.ExecuteScalar(sql);
        }
        //忘记密码
        public int UptLogin(R_Login r)
        {
            string sql = $"update R_Login set LPwd='{r.LPwd}' where LName='{r.LName}'";
            return DBHelper.ExecuteNonQuery(sql);
        }

    }
}
