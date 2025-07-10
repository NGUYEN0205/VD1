using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VD1
{
    public class TaiKhoan
    {
        string tendangnhap;
        string matkhau;

        public string Tendangnhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
    }
}