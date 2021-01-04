using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.DataAccessLayer;
using đồ_án_1.Business.Interface;
using đồ_án_1.DataAccessLayer.Interface;
using đồ_án_1.Entities;
using đồ_án_1.Business;

namespace đồ_án_1.Presenation
{
    public class FromBaoCao
    {
        private IHoaDonBLL hdBLL = new HoaDonBLL();
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("------------------------------HIỂN THỊ BÁO CÁO + THỐNG KÊ------------------------------");
            string day = DateTime.Now.ToString("dd/MM/yyyy_hh:mm:ss");
            Console.WriteLine(day);
            List<HoaDon> list = hdBLL.GetAllHoaDon();
            foreach (var hd in list)
                Console.WriteLine(hd.MaHoaDon + "\t" + hd.Tensanpham + "\t" + hd.NgayXuat + "\t" + hd.SoLuong + "\t" + hd.TongSoTien);
        }
        public void SoLuongSP()
        {
            Console.WriteLine("");
        }
        public void TongTienThuNhap()
        {

        }
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------+BÁO CÁO/ THỐNG KÊ!+-----------------------------------");
                Console.WriteLine("                      |++++++++++++++++++++++++++++++++++++++++++++++++++++|                       ");
                Console.WriteLine("                      |            F1.HIỂN THỊ THÔNG TIN                            |                       ");
                Console.WriteLine("                      |____________________________________________________┤                       ");
                Console.WriteLine("                      |            F2.Tổng số lượng sản phẩm bán ra        |                       ");
                Console.WriteLine("                      ├────────────────────────────────────────────────────|            ┤                       ");
                Console.WriteLine("                      |            F3.Tổng tiền thu nhập                   |                       ");
                Console.WriteLine("                      ├────────────────────────────────────────────────────|           ┤                       ");
                Console.WriteLine("                      |            F4.Thoat                                |                       ");
                Console.WriteLine("                      └────────────────────────────────────────────────────┘                       ");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.KeyChar)
                {
                    case '1':
                        Hien();
                        Console.WriteLine("                         Nhấn phím bất kì để tiếp tục...");
                        Console.ReadKey();
                        break;
                    case '2':
                        SoLuongSP();
                        break;
                    case '4':
                        Program.Menu();
                        break;
                }
            } while (true);
        }

    }
}

