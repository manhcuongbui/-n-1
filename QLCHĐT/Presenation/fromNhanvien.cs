//using System;
//using System.Collections.Generic;
//using System.Text;
//using đồ_án_1.Entities;
//using đồ_án_1.Business.Interface;
//using đồ_án_1.Business;
//using đồ_án_1.DataAccessLayer.Interface;
//using đồ_án_1.DataAccessLayer;

//namespace đồ_án_1.Presenation
//{
//    public class FromNhanVien
//    {
//        private INhanVienBLL nhanvien = new NhanVienBLL();
//        public void Them()
//        {
//            Console.Clear();
//            NhanVien nv = new NhanVien();
//            Console.WriteLine("Nhap thong tin cho nhan vien");
//            Console.WriteLine("Nhap ma nhan vien:");nv.Manhanvien =(Console.ReadLine());
//            Console.Write("Ho ten:"); nv.Tennhanvien = Console.ReadLine();
//            Console.Write("Dia chi:"); nv.Diachi = Console.ReadLine();
//            Console.Write("Email:"); nv.Email = Console.ReadLine();
//            Console.Write("So dien thoai:"); nv.Sodienthoai = Console.ReadLine();
//            Console.Write("He so luong:"); nv.Hesoluong = double.Parse(Console.ReadLine());
         
//        }
//        public void Hien()
//        {
//            Console.Clear();
//            List<NhanVien> ds = nhanvien.GetAllNhanVien();
//            int stt = 0;

//            foreach (NhanVien nv in ds)
//            {
//                Console.WriteLine("{0}:{1}\t{2}\t{3}\t{4}", (++stt), nv.Tennhanvien, nv.Diachi, nv.Hesoluong, nv.Luong());

//            }

//            Console.ReadKey();
//        }
//        public void Sua()
//        {
//            Console.Clear();
//            Console.WriteLine("------------------------------SỬA THÔNG TIN KHÁCH HÀNG------------------------------");
//            List<NhanVien> list = nhanvien.GetAllNhanVien();
//            string makhachhang;
//            Console.Write("Nhập mã nhân viên cần sửa:");
//            makhachhang = Console.ReadLine();
//            int i = 0;
//            for (i = 0; i < list.Count; ++i)
//                if (list[i].Manhanvien==manhanvien) break;

//            if (i < list.Count)
//            {
//                NhanVien nv = new NhanVien(list[i]);
//                Console.Write("Tên mới:");
//                string ten = Console.ReadLine();
//                if (!string.IsNullOrEmpty(ten)) nv.Tennhanvien= ten;
//                Console.Write("Địa chỉ:");
//                string dc = Console.ReadLine();
//                if (!string.IsNullOrEmpty(dc)) nv.Diachi = dc;
//                Console.Write("SĐT:");
//                string sdt = Console.ReadLine();
//                if (!string.IsNullOrEmpty(sdt)) nv.Tennhanvien = sdt;
//                nhanvien.Sua(nv);
//            }
//            else
//            {
//                Console.WriteLine(" Thông tin nhập chưa chính xác - Không tồn tại mã nhân viên này!");
//            }
//        }
    
//        public void Xoa()
//        {
//            ConsoleKeyInfo kt;
//            do
//            {
//                Console.Clear();
//                List<NhanVien> ds = nhanvien.GetAllNhanVien();
//                foreach (NhanVien nv in ds)
//                    Console.WriteLine("{0}:{1}\t{2}\t{3}\t{4}", nv.Manhanvien, nv.Tennhanvien, nv.Diachi, nv.Hesoluong, nv.Luong());
//                Console.Write("Nhap ma nhan vien can xoa:");
//                int manv = int.Parse(Console.ReadLine());
//                nhanvien.Delete(manv);
//                Console.Write("Ban muon xoa nua khong C/K?");
//                kt = Console.ReadKey();
//                if (char.ToUpper(kt.KeyChar) == 'K') break;
//            } while (true);
//            Console.ReadKey();
//        }
//    }
//}



