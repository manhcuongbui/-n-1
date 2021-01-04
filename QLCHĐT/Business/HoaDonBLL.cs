using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;
using đồ_án_1.Business.Interface;
using đồ_án_1.DataAccessLayer.Interface;
using đồ_án_1.DataAccessLayer;

namespace đồ_án_1.Business
{
    //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IHoaDonBLL
    public class HoaDonBLL : IHoaDonBLL
    {
        private IHoaDonDAL hdDA = new HoaDonDAL();
        //Thực thi các yêu cầu
        public List<HoaDon> GetAllHoaDon()
        {
            return hdDA.GetAllHoaDon();
        }
        public void ThemHoaDon(HoaDon hd)
        {
            if (!string.IsNullOrEmpty(hd.MaHoaDon))
            {
                //Tiến hành chuẩn hóa dữ liệu nếu cần
                hdDA.ThemHoaDon(hd);
            }
            else
                throw new Exception("Dữ liệu sai!!!");
        }

        public void XoaHoaDon(string mahoadon)
        {
            int i;
            List<HoaDon> list = GetAllHoaDon();
            for (i = 0; i < list.Count; ++i)
                if (list[i].MaHoaDon == mahoadon) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hdDA.Update(list);
            }
            else
                throw new Exception("Không tồn tại mã hóa đơn này!!!");
        }
        public void SuaHoaDon(HoaDon hd)
        {
            int i;
            List<HoaDon> list = GetAllHoaDon();
            for (i = 0; i < list.Count; ++i)
                if (list[i].MaHoaDon == hd.MaHoaDon) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hd);
                hdDA.Update(list);
            }
            else
                throw new Exception("Không tồn tại mã hóa đơn này!!!");
        }
        public List<HoaDon> TimHoaDon(HoaDon hdn)
        {
            List<HoaDon> list = GetAllHoaDon();
            List<HoaDon> kq = new List<HoaDon>();
            if (string.IsNullOrEmpty(hdn.MaHoaDon))
            {
                kq = list;
            }

            //Tìm theo mã hóa đơn
            if (!string.IsNullOrEmpty(hdn.MaHoaDon))
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].MaHoaDon.IndexOf(hdn.MaHoaDon) >= 0)
                    {
                        kq.Add(new HoaDon(list[i]));
                    }
            }
            return kq;
        }
    }
}
