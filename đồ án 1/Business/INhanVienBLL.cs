using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;

namespace đồ_án_1.Business
{
    public interface INhanVienBLL
    {
        List<NhanVien> GetAllNhanVien();
        void Insert(NhanVien nv);
        void Delete(int manv);
     
    }
}