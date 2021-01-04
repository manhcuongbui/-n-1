using System;
using System.Collections.Generic;
using System.Text;

using đồ_án_1.Entities;

namespace đồ_án_1.Business.Interface
{
    public interface ISanPhamBLL
    {
        List<SanPham> GetAllSanPham();
        void ThemSanPham(SanPham sp);
        void XoaSanPham(string masanpham);
        void SuaSanPham(SanPham sp);
        List<SanPham> TimSanPham(SanPham sp);
    }
}
