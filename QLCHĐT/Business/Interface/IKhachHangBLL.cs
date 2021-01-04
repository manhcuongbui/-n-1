using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;
namespace đồ_án_1.Business.Interface
{
    public interface IKhachHangBLL
    {
        List<KhachHang> GetAllKhachHang();
        void ThemKhachHang(KhachHang kh);
        void XoaKhachHang(string makhachhang);
        void SuaKhachHang(KhachHang kh);
        List<KhachHang> TimKhachHang(KhachHang kh);
    }
}