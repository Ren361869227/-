
using DAL;
using DataModel;
using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBll : ILogin
    {
        //实例化dal
        LoginDal dal = new LoginDal();
      

        public int Login(R_Login r)
        {
            return dal.Login(r);
        }

        public int UptLogin(R_Login r)
        {
            return dal.UptLogin(r);
        }
    }
}
