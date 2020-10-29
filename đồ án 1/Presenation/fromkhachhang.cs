using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Presenation
{
    class fromkhachhang
    {
        public class Formkhachhang
        {
            private IHkhachhangBLL khachhang = new khachhhangBLL();
            public void MaxHTQQ(List<khachhang> list, out int maxhoten, out int maxquequan)
            {
                if (list.Count == 0)
                {
                    maxhoten = 10;
                    maxquequan = 10;
                }
                else
                {
                    maxhoten = list[0].Hoten.Length;
                    maxquequan = list[0].QueQuan.Length;
                    for (int i = 1; i < list.Count; ++i)
                    {
                        if (maxhoten < list[i].Hoten.Length)
                            maxhoten = list[i].Hoten.Length;
                        if (maxquequan < list[i].QueQuan.Length)
                            maxquequan = list[i].QueQuan.Length;
                    }
                }
            }
            public int HienHS(List<khachhang> list, int x, int y, string tieudedau, string tieudecuoi, int n)
            {
                int maxhoten;
                int maxquequan;
                int maxtencuahang;
                Console.WriteLine();
                MaxHTQQ(list, out maxhoten, out maxquequan,out maxtencuahang);
                Console.WriteLine();
                Console.WriteLine(tieudedau);
                Console.WriteLine("------------------------------------------------------");
                y = y + 4;
                Console.SetCursorPosition(x + 1, y); Console.Write("MAHS");
                Console.SetCursorPosition(x + 8, y); Console.Write("HO TEN");
                Console.SetCursorPosition(x + 10 + maxhoten, y); Console.Write("QUE QUAN");
                Console.SetCursorPosition(x + 12 + maxhoten + maxquequan, y); Console.Write("TEN CUA HANG");
                int d = 0;
                for (int i = list.Count - 1; i >= 0; --i)
                {
                    y = y + 1;
                    Console.SetCursorPosition(8, y); Console.Write(list[i].Hoten);
                    Console.SetCursorPosition(10 + maxhoten, y); Console.Write(list[i].QueQuan);
                    Console.SetCursorPosition(10 + maxhoten, y); Console.Write(list[i].QueQuan);
                    Console.SetCursorPosition(12 + maxhoten + maxquequan, y); Console.Write(list[i].QUEQUAN);
                   
                    if ((++d) == n) break;
                }
                Console.WriteLine();
                Console.Write(tieudecuoi);
                return Console.CursorTop;
            }
            public void NhapHS()
            {
                do
                {
                    IkhachhangBLL hocsinh = new khachhangBLL();
                    Console.Clear();
                    Console.WriteLine("                NHAP THONG TIN CUA HANG             ");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Ho ten:                    Que quan:                  ");
                    Console.WriteLine();
                    Console.WriteLine("TEN CUA HANG:                                         ");
                    Console.WriteLine();
                    int x = 0, y = 7;
                    int v = HienHS(hocsinh.GetAllData(), x, y, "                 DANH SACH DA NHAP                      ", "Nhan Esc de thoat, Enter de luu!", 5);
                    khachhang hs = new khachhang();
                    Console.SetCursorPosition(7, 3); hs.Hoten = Console.ReadLine();
                    Console.SetCursorPosition(37, 3); hs.QueQuan = Console.ReadLine();
                    Console.SetCursorPosition(10, 5); hs.TenCuaHang = Console.ReadLine());
                    ConsoleKeyInfo kt = Console.ReadKey();
                    if (kt.Key == ConsoleKey.Escape) return;
                    else if (kt.Key == ConsoleKey.Enter)
                        hocsinh.Insert(hs);
                } while (true);
            }
            public void XoaHS()
            {
                do
                {
                    Console.Clear();
                    IkhachhangBLL hocsinh = new khachhangBLL();
                    HienHS(hocsinh.GetAllData(), 0, 0, "                 DANH HANG HOA TRONG KHO                  ", "Nhap MaKH can xoa, thoat nhap 0!", 20);
                    int makh = int.Parse("0" + Console.ReadLine());
                    if (makh == 0) return;
                    else khachhang.Delete(makh);
                } while (true);
            }
            public void TimKH()
            {
                string hoten = "";
                do
                {
                    Console.Clear();
                    IkhachhangBLL hocsinh = new khachhangBLL();
                    List<khachhang> list = hocsinh.Timkhachhang(new khachhang(0, hoten, null, 0, 0, 0));
                    HienHS(list, 0, 0, "                 DANH SACH KHACH HANG                      ", "Nhap Ho va Ten can tim, Nhan vay Enter de thoat!", 30);
                    hoten = Console.ReadLine();
                    if (hoten == "") return;
                } while (true);
            }
            public void Hien()
            {

                Console.Clear();
                IkhachhangBLL khachhang = new khachhangBLL();
                HienKH(list, 0, 0, "                 DANH SACH KHACH HANG                       ", "Nhan Enter de thoat!", 25);
                Console.ReadLine();
            }
        }
    }


}
}
