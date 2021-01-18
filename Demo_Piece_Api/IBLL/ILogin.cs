using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface ILogin
    {
        //登录
        int Login(R_Login r);
        //忘记密码
        int UptLogin(R_Login r);
    }
}
