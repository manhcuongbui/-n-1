using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Utility
{
    public class CongCu
    {
        public static MenuChinh menu = new MenuChinh();
        public static string ChuanHoaXau(string xau)
        {
            string s = xau.Trim();
            while (s.IndexOf("  ") >= 0) s = s.Remove(s.IndexOf("  "), 1);
            string[] a = s.Split(' ');
            s = "";
            for (int i = 0; i < a.Length; ++i)
                s = s + " " + char.ToUpper(a[i][0]) + a[i].Substring(1).ToLower();
            return s.Trim();
        }
        public static string CatXau(string xau)
        {
            string s = xau.Trim();
            while (s.IndexOf("  ") >= 0) s = s.Remove(s.IndexOf("  "), 1);
            return s;
        }
        public static string ChuanHoaXau(string xau, int max)
        {
            string s = CatXau(xau);
            while (s.Length < max) s = s + " ";
            return s;
        }
        public static void trogiup()
        {
            Console.ForegroundColor = ConsoleColor.White;
            String str = "CAM ON CAC BAN DA SU DUNG PHAN MEM \n\n\t\t GIAO VIEN HUONG DAN : NGUYEN HUU DONG \n\n\t\t";
            int len = str.Length;
            String s = "";
            for (int i = 0; i < 80; i++)
                s += " ";
            str = s + str + s;
            Console.Title = "PHAM MEM QUAN LY CUA HANG BAN THIET BI DIEN TU !";
            Console.Clear();

            for (int i = 0; i < 81 + len; i++)
            {
                if (Console.KeyAvailable == false)
                {
                    String tmp = "";
                    tmp = str.Substring(i, 80);
                    Console.SetCursorPosition(0, 8);
                    Console.Write(tmp);
                    System.Threading.Thread.Sleep(105);
                    Console.Clear();
                }
                else
                {
                    Console.ReadKey();
                    break;
                }
                continue;
            }
            Console.Write("Ban nhan phim bat ki de quay lai!");
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                default:
                    Console.Clear();
                    menu.MenuChinh1();
                    break;
            }
        }
    }
}