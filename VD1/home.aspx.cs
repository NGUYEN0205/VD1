using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VD1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["tendn"] == "admin")
            {
                Response.Write("Xin chhao: " + Session["tendn"]);
                Application["dem"] = (int)Application["dem"] + 1;
                Response.Write("So lan dang nhap thanh cong: " + Application["dem"]);
            }
            else
            {
                Response.Redirect("danhnhap.aspx");
            }
        }
    }
}