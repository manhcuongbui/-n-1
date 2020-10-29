using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Presenation
{
    public class MenuGD : menu
    {
        public MenuGD(string[] mn) : base(mn) { }
        public override void ThucHien(int vitri)
        {
            Formkhachhang khachhang = new Formkhachhang();
            switch (vitri)
            {
                case 0:
                    khachhang.NhapKH();
                    break;
                case 1:
                    khachhang.TimKH();
                    break;
                case 2:
                    khachhang.XoaKH();
                    break;
                case 3:
                    khachhang.hien();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

