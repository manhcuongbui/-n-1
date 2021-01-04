using đồ_án_1.Presenation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đồ_án_1
{
    public class Program
    {
        public static void Menu()
        {
            {
                Console.Clear();
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+-----------------------------ĐỒ ÁN 1:XÂY DỰNG CHƯƠNG TRÌNH QUẢN LÝ CỬA HÀNG BÁN------------------------------+");
                Console.WriteLine("+                                             THIẾT BỊ ĐIỆN TỬ                                                +");
                Console.WriteLine("+                                 ┌─────────────────────────────────────────┐                                 +");
                Console.WriteLine("+                                 |           F1.QUẢN LÝ SẢN PHẨM           |                                 +");
                Console.WriteLine("+                                 ├─────────────────────────────────────────┤                                 +");
                Console.WriteLine("+                                 |           F2.QUẢN LÝ KHÁCH HÀNG         |                                 +");
                Console.WriteLine("+                                 ├─────────────────────────────────────────┤                                 +");
                Console.WriteLine("+                                 |           F3.QUẢN LÝ NHÂN VIÊN          |                                 +");
                Console.WriteLine("+                                 ├─────────────────────────────────────────┤                                 +");
                Console.WriteLine("+                                 |           F4.QUẢN LÝ HÓA ĐƠN            |                                 +");
                Console.WriteLine("+                                 ├─────────────────────────────────────────┤                                 +");
                Console.WriteLine("+                                 |           F5.BÁO CÁO/THỐNG KÊ           |                                 +");
                Console.WriteLine("+                                 |_________________________________________|                                 +");
                Console.WriteLine("+                                 |           F6.THOÁT                      |                                 +");        
                Console.WriteLine("+                                 └─────────────────────────────────────────┘                                 +");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.KeyChar)
                {
                    case '1':
                        fromSanPham frsp = new fromSanPham();
                        frsp.Menu();
                        break;
                    case '2':
                        FromKhachHang frmkh = new FromKhachHang();
                        frmkh.Menu();
                        break;
                    case '3':
                        FromNhanVien frnv = new FromNhanVien();
                        frnv.Menu();
                        break;
                    case '4':
                        FromHoaDon frmhd = new FromHoaDon();
                        frmhd.Menu();
                        break;
                    case '5':
                        FromBaoCao frmbc = new FromBaoCao();
                        frmbc.Menu();
                        Console.ReadKey();
                        break;
                    case '6':
                        Environment.Exit(0);
                        break;
                }
            } while (true) ;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            do
            {
                Console.WriteLine("                                 ┌─────────────────────────────────────────┐");
                Console.WriteLine("                                 |                Đăng nhập                |");
                Console.WriteLine("                                 └─────────────────────────────────────────┘");
                Console.Write("                                           Tài khoản:");
                String tk = Console.ReadLine();
                Console.Write("                                           Mật khẩu:");
                String mk = Console.ReadLine();
                if (tk == "123" && mk == "123")
                {
                    Console.Clear();
                    Menu();
                }
                else
                {

                    Console.WriteLine("                                Tài khoản hoặc mật khẩu không chính xác!");
                    Console.WriteLine("                                VUI LÒNG NHẬP LẠI!                      ");
                    Console.WriteLine("                                Chọn 0 để tiếp tục đăng nhập OR Chọn 1 để thoát");
                    String chon = Console.ReadLine();
                    if (chon == "1")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (chon == "2")
                    {
                        break;
                    }
                }
            } while (true);
        }
    }
}
