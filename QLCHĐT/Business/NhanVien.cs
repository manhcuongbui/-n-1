//using System;
//using System.Collections.Generic;
//using System.Text;
//using đồ_án_1.DataAccessLayer.Interface;
//using đồ_án_1.DataAccessLayer;
//using đồ_án_1.Business.Interface;
//using đồ_án_1.Entities;


//namespace đồ_án_1.Business
//{
//    namespace QLĐT.BusinessLayer.Interface
//    {
//        //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại INHANVIEN
//        public class NhanVienBLL : INhanVienBLL
//        {
//            private INhanVienDAL nvDA = new NhanVienDAL();
//            //Thực thi các yêu cầu
//            public List<NhanVien> GetAllNhanVien()
//            {
//                return nvDA.GetAllNhanVien();
//            }
//            public void ThemNhanVien(NhanVien nv)
//            {
//                if (!string.IsNullOrEmpty(nv.Tennhanvien))
//                {
//                    //Tiến hành chuẩn hóa dữ liệu nếu cần
//                    nvDA.ThemNhanVien(nv);
//                }
//                else
//                    throw new Exception("Dữ liệu sai!!!");
//            }

//            public void XoaNhanVien(string manhanvien)
//            {
//                int i;
//                List<NhanVien> list = GetAllNhanVien();
//                for (i = 0; i < list.Count; ++i)
//                    if (list[i].Manhanvien == manhanvien) break;
//                if (i < list.Count)
//                {
//                    list.RemoveAt(i);
//                    nvDA.Update(list);
//                }
//                else
//                    throw new Exception("Không tồn tại mã khách hàng này!!!");
//            }
//            public void SuaNhanVien(NhanVien nv)
//            {
//                int i;
//                List<NhanVien> list = GetAllNhanVien();
//                for (i = 0; i < list.Count; ++i)
//                    if (list[i].Manhanvien == nv.Manhanvien) break;
//                if (i < list.Count)
//                {
//                    list.RemoveAt(i);
//                    list.Add(nv);
//                    nvDA.Update(list);
//                }
//                else
//                    throw new Exception("Không tồn tại mã khách hàng này!!!");
//            }
//            public List<NhanVien> TimNhanVien(NhanVien nv)
//            {
//                List<NhanVien> list = GetAllNhanVien();
//                List<NhanVien> kq = new List<NhanVien>();
//                if (string.IsNullOrEmpty(nv.Manhanvien) && string.IsNullOrEmpty(nv.Tennhanvien))
//                {
//                    kq = list;
//                }
//                //Tìm theo tên khách hàng
//                if (!string.IsNullOrEmpty(nv.Tennhanvien))
//                {
//                    for (int i = 0; i < list.Count; ++i)
//                        if (list[i].Tennhanvien.IndexOf(nv.Tennhanvien) >= 0)
//                        {
//                            kq.Add(new NhanVien(list[i]));
//                        }
//                }
//                return kq;
//            }

//        }
//    }
//}

