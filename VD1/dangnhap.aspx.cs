using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD1
{
    public partial class dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<TaiKhoan> ds = (List<TaiKhoan>)Application["dstk"];

            if (IsPostBack)
            {
                string tendn = Request.Form["tendk"];
                string mk = Request.Form["mk"];
                TaiKhoan tk = new TaiKhoan();
                tk.Tendangnhap = tendn;
                tk.Matkhau = mk;
                ds.Add(tk);
                Application["dstk"] = ds;
                
                /*string ten = Request.Form.Get("tendn");
                string mk = (string)Request.Form.Get("mk");

               /* if (ten == "admin" && mk == "123456")
                {
                    Session["tendn"] = ten;
                    Response.Redirect("home.aspx");
                }
                else
                {
                    if (Session["dem"] == null)
                    {
                        Session["dem"] = 1;
                    }
                    else
                    {
                        Session["dem"] = (int)Session["dem"] + 1;
                    }
                    Response.Write("ban nhap sai lan: " + Session["dem"]);

                    if ((int)Session["dem"] >= 10)
                    {
                        Response.Redirect("thongbanloi.aspx");
                    }
                }*/
            }

            foreach (TaiKhoan tk in ds)
            {
                Response.Write("Ten dn: " + tk.Tendangnhap + " - MK: " + tk.Matkhau);
            }
        }

    }
}