using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using đồ_án_1.Entities;
using đồ_án_1.Business;
namespace đồ_án_1.Business.Interface
{
    public interface INhanVienBLL
    {
        List<NhanVien> GetAllNhanVien();
        void ThemNhanVien(NhanVien nv);
        void XoaNhanVien(string manv);
        void SuaNhanVien(NhanVien nv);
        List<NhanVien> TimNhanVien(NhanVien nv);

    }
}