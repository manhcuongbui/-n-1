using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;

namespace đồ_án_1.DataAccessLayer.Interface
{
    public interface IHoaDonDAL
    {
        List<HoaDon> GetAllHoaDon();
        void ThemHoaDon(HoaDon hd);
        void Update(List<HoaDon> list);
    }

}
