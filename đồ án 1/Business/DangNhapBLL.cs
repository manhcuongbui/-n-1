using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Business
{
    
    
        class DanhNhapBLL
        {
            DangNhapDAL login = new DangNhapDAL();
            public bool KiemTraNick(string user, string pass)
            {
                DangNhap t = login.Read("Data/Login.txt");
                bool kt = false;
                if ((t.Urser == user) && (t.Pass == pass))
                { kt = true; }
                return kt;
            }
        }
}

