using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Entities
{
    public class HoaDon
    {
        #region Các thành phần dữ liệu
        private string mahoadon;
        private string makhachhang;
        private string tensanpham;
        private int soluong;
        private string ngayxuat;
        private int tongsotien;
        #endregion

        #region Các thuộc tính
        public string MaHoaDon
        {
            get { return mahoadon; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    mahoadon = value;
            }
        }
        public string MaKhachHang
        {
            get { return makhachhang; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    makhachhang = value;
            }
        }
        public string Tensanpham
        {
            get { return tensanpham; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tensanpham = value;
            }
        }
        public int SoLuong
        {
            get { return soluong; }
            set
            {
                if (value > 0)
                    soluong = value;
            }
        }



        public string NgayXuat
        {
            get { return ngayxuat; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    ngayxuat = value;
            }
        }
        public int TongSoTien
        {
            get { return tongsotien; }
            set
            {
                if (value > 0)
                    tongsotien = value;
            }
        }

        #endregion

        #region Các thương thức             
        public HoaDon() { }
        //Phương thức thiết lập sao chép
        public HoaDon(HoaDon hd)
        {
            this.mahoadon = hd.mahoadon;
            this.makhachhang = hd.makhachhang;
            this.ngayxuat = hd.ngayxuat;
        }
        public HoaDon(string mahoadon, string makhachhang, string ngayxuat)
        {
            this.mahoadon = mahoadon;
            this.makhachhang = makhachhang;
            this.ngayxuat = ngayxuat;
        }
        #endregion
    }
}


