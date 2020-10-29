using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Presenation
{
    class fromkhachhang
    {
        public class Formkhachhang
        {
            DoHoa dh = new DoHoa(140, 55);
            public static MenuChinh menu = new MenuChinh();
            #region Chuc nang quan ly cua hang
            public void ChucNangQLNhanVien()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                dh.ve1("╔", 20, 0);
                dh.ve1("╚", 20, 39);
                dh.ve1("╚", 20, 39);
                dh.ve1("╗", 119, 0);
                dh.ve1("╝", 119, 39);

                dh.ve1("══════════════════════════════════════════════════════════════════════════════════════════════════", 21, 0);
                dh.ve1("══════════════════════════════════════════════════════════════════════════════════════════════════", 21, 3);
                dh.ve1("══════════════════════════════════════════════════════════════════════════════════════════════════", 21, 39);

                for (int i = 1; i < 39; ++i)
                {
                    dh.ve1("║", 20, i);
                    dh.ve1("║", 119, i);
                }
                dh.ve1("╠", 20, 3);
                dh.ve1("╣", 119, 3);
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("                 ***CHUONG TRINH QUAN LY CUA HANG BAN THIET BI DIEN TU***      ", 22, 1);
                /////===============================================================================================
                Console.ForegroundColor = ConsoleColor.Green;
                dh.ve1("╔", 24, 5);
                dh.ve1("╚", 24, 37);
                dh.ve1("╗", 115, 5);
                dh.ve1("╝", 115, 37);

                dh.ve1("══════════════════════════════════════════════════════════════════════════════════════════", 25, 5);
                dh.ve1("══════════════════════════════════════════════════════════════════════════════════════════", 25, 37);

                for (int i = 6; i < 37; ++i)
                {
                    dh.ve1("║", 24, i);
                    dh.ve1("║", 115, i);
                }
                ///====================================================================================================

                Console.ForegroundColor = ConsoleColor.Green;

                dh.ve1("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 22, 4);
                dh.ve1("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ", 22, 38);

                for (int i = 4; i < 38; ++i)
                {
                    dh.ve1("*", 22, i);
                    dh.ve1("*", 117, i);
                }
                dh.ve1("╔", 39, 12);
                dh.ve1("╚", 39, 24);
                dh.ve1("╗", 99, 12);
                dh.ve1("╝", 99, 24);

                dh.ve1("═══════════════════════════════════════════════════════════", 40, 12);
                dh.ve1("═══════════════════════════════════════════════════════════", 40, 24);

                for (int i = 13; i < 24; ++i)
                {
                    dh.ve1("║", 39, i);
                    dh.ve1("║", 99, i);
                }
                dh.ve1("╠", 39, 20);
                dh.ve1("╠", 39, 22);
                dh.ve1("╠", 39, 18);
                dh.ve1("╠", 39, 16);
                dh.ve1("╣", 99, 22);
                dh.ve1("╣", 99, 20);
                dh.ve1("╣", 99, 18);
                dh.ve1("╣", 99, 16);
                dh.ve1("═══════════════════════════════════════════════════════════", 40, 22);
                dh.ve1("═══════════════════════════════════════════════════════════", 40, 20);
                dh.ve1("═══════════════════════════════════════════════════════════", 40, 18);
                dh.ve1("═══════════════════════════════════════════════════════════", 40, 16);

                for (int i = 17; i < 24; ++i)
                {
                    dh.ve1("║", 47, i);
                }
                dh.ve1("╦", 47, 16);
                dh.ve1("╩", 47, 24);
                dh.ve1("╬", 47, 22);
                dh.ve1("╬", 47, 20);
                dh.ve1("╬", 47, 18);
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("CAC CHUC NANG QUAN LY NHAN VIEN", 57, 14);
                dh.ve1("F1", 43, 17); dh.ve1("Them NHAN Vien", 55, 17);
                dh.ve1("F2", 43, 19); dh.ve1("Sua thong tin nhan vien", 55, 19);
                dh.ve1("F3", 43, 21); dh.ve1("Xoa nhan vien", 55, 21);
                dh.ve1("F4", 43, 23); dh.ve1("Hien Thi danh sach nhan vien", 55, 23);
                Console.ForegroundColor = ConsoleColor.White;
                dh.ve1("Tro ve menu chinh nhan F10", 43, 27);
                dh.ve1("Thoat khoi chuong trinh nhan Esc", 43, 28);
                dh.ve1("Ban nhap mot phim chuc nang: ", 65, 35);
            tem: Console.SetWindowSize(135, 55);
                ConsoleKeyInfo kt = Console.ReadKey();

                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        ThemSV();
                        break;


                }
            }
        }
    }
}
