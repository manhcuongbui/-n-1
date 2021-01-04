using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.DataAccessLayer.Interface;
using đồ_án_1.DataAccessLayer;
using đồ_án_1.Business.Interface;
using đồ_án_1.Entities;



namespace đồ_án_1.Business
{
    namespace QLĐT.BusinessLayer.Interface
    {
        //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IKhachHangBLL
        public class KhachHangBLL : IKhachHangBLL
        {
            private IKhachHangDAL khDA = new KhachHangDAL();
            //Thực thi các yêu cầu
            public List<KhachHang> GetAllKhachHang()
            {
                return khDA.GetAllKhachHang();
            }
            public void ThemKhachHang(KhachHang kh)
            {
                if (!string.IsNullOrEmpty(kh.Hoten))
                {
                    //Tiến hành chuẩn hóa dữ liệu nếu cần
                    khDA.ThemKhachHang(kh);
                }
                else
                    throw new Exception("Dữ liệu sai!!!");
            }

            public void XoaKhachHang(string makhachhang)
            {
                int i;
                List<KhachHang> list = GetAllKhachHang();
                for (i = 0; i < list.Count; ++i)
                    if (list[i].MaKhach == makhachhang) break;
                if (i < list.Count)
                {
                    list.RemoveAt(i);
                    khDA.Update(list);
                }
                else
                    throw new Exception("Không tồn tại mã khách hàng này!!!");
            }
            public void SuaKhachHang(KhachHang kh)
            {
                int i;
                List<KhachHang> list = GetAllKhachHang();
                for (i = 0; i < list.Count; ++i)
                    if (list[i].MaKhach == kh.MaKhach) break;
                if (i < list.Count)
                {
                    list.RemoveAt(i);
                    list.Add(kh);
                    khDA.Update(list);
                }
                else
                    throw new Exception("Không tồn tại mã khách hàng này!!!");
            }
            public List<KhachHang> TimKhachHang(KhachHang kh)
            {
                List<KhachHang> list = GetAllKhachHang();
                List<KhachHang> kq = new List<KhachHang>();
                if (string.IsNullOrEmpty(kh.MaKhach) && string.IsNullOrEmpty(kh.Hoten))
                {
                    kq = list;
                }
                //Tìm theo tên khách hàng
                if (!string.IsNullOrEmpty(kh.Hoten))
                {
                    for (int i = 0; i < list.Count; ++i)
                        if (list[i].Hoten.IndexOf(kh.Hoten) >= 0)
                        {
                            kq.Add(new KhachHang(list[i]));
                        }
                }
                return kq;
            }

        }
    }
}
