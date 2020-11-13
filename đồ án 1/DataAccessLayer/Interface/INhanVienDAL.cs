using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;

namespace đồ_án_1.DataAccessLayer
{
    public interface NhanVienDAL
    {
        List<NhanVien> GetAllNhanVien();
        void Insert(NhanVien nv);
        void Delete(int manv);
        int GetMaNV();
    }
}