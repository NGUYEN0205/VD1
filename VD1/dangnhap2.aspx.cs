using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD1
{
    public partial class dangnhap2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            List<TaiKhoan> ds = (List<TaiKhoan>)Application["dstk"];
            string tendn = Request.Form["tendn"];
            string mk = Request.Form["mk"];
            int d = 0;
            if (IsPostBack)
            {
                foreach (TaiKhoan t in ds)
                {
                    if (tendn == t.Tendangnhap && mk == t.Matkhau)
                    {
                        Response.Write("Dang nhap thanh cong");
                        d = 1;
                    }
                }
                if (d == 0)
                {
                    Response.Write("Dang nhap that bai");
                }
            }
           
        }
    }
}