using đồ_án_1.Presenation;
using System;
using đồ_án_1.Utility;

namespace đồ_án_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            LogIn lg = new LogIn();
            bool ok = lg.Hien(10, 5, "1", "1");
            if (ok)
            {
                Hien();
            }
            else Environment.Exit(0);

        }
        public static void Hien()
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            string[] mn ={
                "F1.Quan ly khach hang ",
                " F2.Quan ly san pham ",
                "F3.Quan ly hoa doan ",
                " F4.Bao cao/Thong ke ",
                " F5.Ket thuc "
            };


            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}

        