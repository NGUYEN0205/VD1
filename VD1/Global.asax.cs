using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace VD1
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["dem"] = 0;
            Application["dstk"] = new List<TaiKhoan>();
            TaiKhoan tk = new TaiKhoan();
            tk.Tendangnhap = "admin";
            tk.Matkhau = "admin";
            List<TaiKhoan> ds = new List<TaiKhoan>(); 
            ds.Add(tk);
            Application["dstk"] = ds;
        }
    }
}