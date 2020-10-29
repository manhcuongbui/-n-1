using System;

namespace đồ_án_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mn ={
                            " 1.Nhap danh sach khach hang ",
                            " 2.Tim khach hang ",
                            " 3.Xoa thong tin khach hang ",
                            " 4.Hien thi ",
                            " 5.Ket thuc "
                        };
            Demo.Presenation.MenuDemo mndemo = new Demo.Presenation.MenuDemo(mn);
            mndemo.HienMeNu(10, 10, ConsoleColor.Black, ConsoleColor.White, ConsoleColor.DarkBlue, ConsoleColor.White);
        }
    }
}
