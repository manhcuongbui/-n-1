using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;

namespace đồ_án_1.Business.Interface
{
    public interface IHoaDonBLL
    {
        List<HoaDon> GetAllHoaDon();
        void ThemHoaDon(HoaDon hd);
        void XoaHoaDon(string mahoadon);
        void SuaHoaDon(HoaDon hd);
        List<HoaDon> TimHoaDon(HoaDon hd);
    }

}
