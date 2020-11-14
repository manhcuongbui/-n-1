using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;

namespace đồ_án_1.DataAccessLayer.Interface
{
    class ISanPhamDAL
    {
        public interface ISanPhamDAL
        {
            List<SanPham> GetAllSanPham();
            void ThemSanPham(SanPham hs);
            void Update(List<SanPham> list);
        }
    }
}
