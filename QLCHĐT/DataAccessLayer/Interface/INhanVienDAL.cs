using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using đồ_án_1.Entities;

namespace đồ_án_1.DataAccessLayer
{
    public interface INhanVienDAL
    {
        List<NhanVien> GetAllNhanVien();
        void ThemNhanVien(NhanVien nv);
        void Update(List<NhanVien> list);
    }
}