using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;
using đồ_án_1.Business.Interface;
using đồ_án_1.Business;

namespace đồ_án_1.Presenation
{
    public class fromSanPham
    {
        private ISanPhamBLL spDLL = new SanPhamBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN SAN PHAM");
            SanPham sp = new SanPham();
            Console.Write("Nhap ten san pham:"); sp.Tensp = Console.ReadLine();
            Console.Write("Nhap gia san pham:"); sp.Giaban = int.Parse(Console.ReadLine());
            spDLL.ThemSanPham(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN SAN PHAM");
            List<SanPham> list = spDLL.GetAllSanPham();
            foreach (var sp in list)
                Console.WriteLine(sp.Masp + "\t" + sp.Tensp + "\t" + sp.Giaban);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN SAN PHAM");
            List<SanPham> list = spDLL.GetAllSanPham();
            string masanpham;
            Console.Write("Nhap ma san pham can sua:");
            masanpham = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Masp == masanpham) break;

            if (i < list.Count)
            {
                SanPham sp = new SanPham(list[i]);
                Console.Write("Nhap ten moi:");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten)) sp.Tensp = ten;
                Console.Write("Gia moi:");
                int gia = int.Parse(Console.ReadLine());
                if (gia > 0) sp.Giaban = gia;
                spDLL.SuaSanPham(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }
        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("QUAN LY THONG TIN SAN PHAM");
                Console.WriteLine(" F1.Nhap san pham ");
                Console.WriteLine(" F2.Sua san pham ");
                Console.WriteLine(" F3.Xoa san pham ");
                Console.WriteLine(" F4.Hien danh sach ");
                Console.WriteLine(" F5.Tim kiem ");
                Console.WriteLine(" F6.Back ");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        Nhap();
                        Hien();
                        Console.WriteLine("Nhap phim bat ky de tiep tuc...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F4:
                        Hien();
                        Console.WriteLine("Nhap phim bat ky de tiep tuc...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F2:
                        Sua();
                        Hien();
                        Console.WriteLine("Nhap phim bat ky de tiep tuc...");
                        Console.ReadKey();
                        break;
                   
                }
            } while (true);
        }
    }
}
