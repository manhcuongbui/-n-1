using System;
using System.Collections.Generic;
using System.Text;

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
