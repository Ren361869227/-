using BLL;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;

namespace Demo_Piece_Api.Controllers
{
    public class LoginController : ApiController
    {
        LoginBll bll = new LoginBll();
        //登录
        [HttpPost]
        public int Login(R_Login r)
        {
            string JiaMi = Md5Encrypt(r.LPwd);
           
            return bll.Login(r);
        }
        //dm5加密
        private string Md5Encrypt(string strSource)
        {
            //把字符串放到byte数组中     
            byte[] bytIn = System.Text.Encoding.Default.GetBytes(strSource);
            //建立加密对象的密钥和偏移量             
            byte[] iv = { 102, 16, 93, 156, 78, 4, 218, 32 };//定义偏移量     
            byte[] key = { 55, 103, 246, 79, 36, 99, 167, 3 };//定义密钥     
            //实例DES加密类     
            DESCryptoServiceProvider mobjCryptoService = new DESCryptoServiceProvider();
            mobjCryptoService.Key = iv;
            mobjCryptoService.IV = key;
            ICryptoTransform encrypto = mobjCryptoService.CreateEncryptor();
            //实例MemoryStream流加密密文件     
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();
            return System.Convert.ToBase64String(ms.ToArray());
        }

        //忘记密码
        [HttpPost]
        public int UptLogin(R_Login r)
        {
            return bll.UptLogin(r);
        }
    }
}
