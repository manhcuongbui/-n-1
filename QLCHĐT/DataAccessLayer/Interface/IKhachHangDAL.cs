using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;
using đồ_án_1.Presenation;


namespace đồ_án_1.DataAccessLayer.Interface
{
    public interface IKhachHangDAL
    {
        List<KhachHang> GetAllKhachHang();
        void ThemKhachHang(KhachHang kh);
        void Update(List<KhachHang> list);
    }
}
