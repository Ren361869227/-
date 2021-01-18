using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Demo_Piece_Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        /// <summary>
        /// ��������
        /// </summary>
        protected void Application_BeginRequest()
        {
            //OPTIONS���󷽷�����Ҫ���ã�
            //1����ȡ������֧�ֵ�HTTP���󷽷���Ҳ�Ǻڿ;���ʹ�õķ�����
            //2�������������������ܡ��磺AJAX���п�������ʱ��Ԥ�죬��Ҫ������һ����������Դ����һ��HTTP OPTIONS����ͷ�������ж�ʵ�ʷ��͵������Ƿ�ȫ��
            if (Request.Headers.AllKeys.Contains("Origin") && Request.HttpMethod == "OPTIONS")
            {
                //��ʾ����������ݽ��л��壬ִ��page.Response.Flush()ʱ������������ݻ�����ϣ������ݷ��͵��ͻ��ˡ�
                //�����Ͳ�����������ҳ�濨��״̬�����û������Ƶĵ���ȥ
                Response.Flush();
            }
        }


    }
}