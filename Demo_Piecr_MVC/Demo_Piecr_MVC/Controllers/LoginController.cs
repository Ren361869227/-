using Demo_Piecr_MVC.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Demo_Piecr_MVC.Controllers
{
    public class LoginController : Controller
    {

  
        //登录
        // GET: Login
        public ActionResult Login()
        {
           
            return View();
        }
        //忘记密码
        public ActionResult Forget()
        {
            return View();
        }

        //验证码
        public ActionResult GetImg()
        {
            int width = 90;
            int height = 25;
            int fontsize = 10;
           string code = string.Empty;
            byte[] bytes = ValidateCode.CreateValidateGraphic(out code, 4, width, height, fontsize);
            Session["ValidateCode"] = code;
            return File(bytes, @"image/jpeg");
        }
        public bool CheckValidateCode(string num)
        {
            
            string cnum = Session["ValidateCode"] == null ? "" : Session["ValidateCode"].ToString();

            if (num.ToLower() == cnum.ToLower() && !string.IsNullOrEmpty(num))
            {               
                return true;
            }
            else
            {

                return false;
            }
        }

    }
}