using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;
using đồ_án_1.Business.Interface;
using đồ_án_1.Business;
using đồ_án_1.DataAccessLayer.Interface;
using đồ_án_1.DataAccessLayer;
namespace đồ_án_1.Presenation
{
    public class FromKhachHang
    {
        private IKhachHangBLL khBLL = new KhachHangBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("------------------------------NHẬP THÔNG TIN KHÁCH HÀNG------------------------------");
            KhachHang kh = new KhachHang();
            Console.Write("Mã khách hàng:"); kh.MaKhach = Console.ReadLine();
            Console.Write("Tên khách hàng:"); kh.Hoten= Console.ReadLine();
            Console.Write("Quê quán:"); kh.QueQuan = Console.ReadLine();
            Console.Write("Địa chỉ:"); kh.DiaChi = Console.ReadLine();
            Console.Write("SĐT:"); kh.SodienThoai = Console.ReadLine();
            khBLL.ThemKhachHang(kh);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("------------------------------HIỂN THỊ THÔNG TIN KHÁCH HÀNG------------------------------");
            List<KhachHang> list = khBLL.GetAllKhachHang();
            foreach (var kh in list)
                Console.WriteLine(kh.MaKhach + "\t" + kh.Hoten + "\t" + kh.QueQuan + "\t" + kh.DiaChi + "\t" + kh.SodienThoai);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("------------------------------SỬA THÔNG TIN KHÁCH HÀNG------------------------------");
            List<KhachHang> list = khBLL.GetAllKhachHang();
            string makhachhang;
            Console.Write("Nhập mã khách hàng cần sửa:");
            makhachhang = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].MaKhach == makhachhang) break;

            if (i < list.Count)
            {
                KhachHang kh = new KhachHang(list[i]);
                Console.Write("Tên mới:");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten)) kh.Hoten = ten;
                Console.Write("Quê quán:");
                string qq = Console.ReadLine();
                if (!string.IsNullOrEmpty(qq)) kh.QueQuan = qq;
                Console.Write("Địa chỉ:");
                string dc = Console.ReadLine();
                if (!string.IsNullOrEmpty(dc)) kh.DiaChi = dc;
                Console.Write("SĐT:");
                string sdt = Console.ReadLine();
                if (!string.IsNullOrEmpty(sdt)) kh.SodienThoai = sdt;
                khBLL.SuaKhachHang(kh);
            }
            else
            {
                Console.WriteLine("Thông tin nhập chưa chính xác - Không tồn tại mã khách hàng này!!!");
            }
        }
        public void Xoa()
        {
            Console.Clear();
            Console.WriteLine("------------------------------XÓA THÔNG TIN KHÁCH HÀNG------------------------------");
            List<KhachHang> list = khBLL.GetAllKhachHang();
            string makhachhang;
            Console.Write("Nhập mã khách hàng cần xóa:");
            makhachhang = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].MaKhach == makhachhang) break;

            if (i < list.Count)
            {
                list.RemoveAt(i);
                khBLL.XoaKhachHang(makhachhang);
            }
            else
            {
                Console.WriteLine("                         Không tồn tại mã khách hàng này!!!");
            }
        }
        public void TimKiem()
        {
            Console.Clear();
            Console.WriteLine("------------------------------TÌM KIẾM KHÁCH HÀNG------------------------------");
            List<KhachHang> list = khBLL.GetAllKhachHang();

            Console.Write("Nhập tên khách hàng cần tìm kiếm:");
            string tt = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; i++)
                if (list[i].Hoten == tt) break;
            if (i < list.Count)
            {
                List<KhachHang> grt = khBLL.TimKhachHang(new KhachHang(list[i]));
                foreach (var x in grt)

                    Console.WriteLine(x.MaKhach + "\t" + x.Hoten + "\t" + x.QueQuan + "\t" + x.DiaChi + "\t" + x.SodienThoai);
            }

            else Console.WriteLine("                         Tên khách hàng này không tồn tại!!!");


        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("+-----------------------------QUẢN LÝ THÔNG TIN KHÁCH HÀNG--------------------------------+");
                Console.WriteLine("+                      ┌──────────────────────────────────────────┐                       +");
                Console.WriteLine("+                      |              F1.Nhập khách hàng          |                       +");
                Console.WriteLine("+                      ├──────────────────────────────────────────┤                       +");
                Console.WriteLine("+                      |            F2.Sửa khách hàng             |                       +");
                Console.WriteLine("+                      ├──────────────────────────────────────────┤                       +");
                Console.WriteLine("+                      |            F3.Xóa khách hàng             |                       +");
                Console.WriteLine("+                      ├──────────────────────────────────────────┤                       +");
                Console.WriteLine("+                      |            F4.Hiển thị danh sách         |                       +");
                Console.WriteLine("+                      ├──────────────────────────────────────────┤                       +");
                Console.WriteLine("+                      |            F5.Tìm kiếm                   |                       +");
                Console.WriteLine("+                      ├──────────────────────────────────────────┤                       +");
                Console.WriteLine("+                      |            F6.THOAT                      |                       +");
                Console.WriteLine("+                      └──────────────────────────────────────────┘                       +");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.KeyChar)
                {
                    case '1':
                        Nhap();
                        Hien();
                        Console.WriteLine("                         Nhấn phím bất kì để tiếp tục...");
                        Console.ReadKey();
                        break;
                    case '4':
                        Hien();
                        Console.WriteLine("                         Nhấn phím bất kì để tiếp tục...");
                        Console.ReadKey();
                        break;
                    case '2':
                        Sua();
                        Hien();
                        Console.WriteLine("                         Nhấn phím bất kì để tiếp tục...");
                        Console.ReadKey();
                        break;
                    case '3':
                        Xoa();
                        Hien();
                        Console.WriteLine("                         Nhấn phím bất kì để tiếp tục...");
                        Console.ReadKey();
                        break;
                    case '5':
                        TimKiem();
                        Console.WriteLine("                         Nhấn phím bất kì để tiếp tục...");
                        Console.ReadKey();
                        break;
                    case '6':
                        Program.Menu();
                        break;
                }
            } while (true);
        }

    }
}


