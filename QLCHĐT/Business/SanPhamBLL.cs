using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;
using đồ_án_1.DataAccessLayer.Interface;
using đồ_án_1.Business.Interface;
using đồ_án_1.DataAccessLayer;
namespace đồ_án_1.Business
{
   
    public class SanPhamBLL : ISanPhamBLL
    {
        private ISanPhamDAL spDA = new SanPhamDAL();
        //Thực thi các yêu cầu
        public List<SanPham> GetAllSanPham()
        {
            return spDA.GetAllSanPham();
        }
        public void ThemSanPham(SanPham sp)
        {
            if (!string.IsNullOrEmpty(sp.Tensp))
            {
                //Tiến hành chuẩn hóa dữ liệu nếu cần
                spDA.ThemSanPham(sp);
            }
            else
                throw new Exception("Dữ liệu sai!!!");
        }

        public void XoaSanPham(string masp)
        {
            int i;
            List<SanPham> list = GetAllSanPham();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Masp == masp) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                spDA.Update(list);
            }
            else
                throw new Exception("Không tồn tại mã điện thoại này!!!");
        }
        public void SuaSanPham(SanPham dt)
        {
            int i;
            List<SanPham> list = GetAllSanPham();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Masp == dt.Masp) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(dt);
                spDA.Update(list);
            }
            else
                throw new Exception("Không tồn tại mã điện thoại này!!!");
        }
        public List<SanPham> TimSanPham(SanPham sp)
        {
            List<SanPham> list = GetAllSanPham();
            List<SanPham> kq = new List<SanPham>();
            if (string.IsNullOrEmpty(sp.Masp) && string.IsNullOrEmpty(sp.Masp) && sp.Giaban == 0)
            {
                kq = list;
            }

            //Tìm theo tên 
            if (!string.IsNullOrEmpty(sp.Tensp))
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Tensp.IndexOf(sp.Tensp) >= 0)
                    {
                        kq.Add(new SanPham(list[i]));
                    }
            }

            //Tìm theo giá 
            else if (sp.Giaban > 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Giaban == sp.Giaban)
                    {
                        kq.Add(new SanPham(list[i]));
                    }
            }
            return kq;
        }

    }
}

