using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Entities
{
    public class NhanVien
    {
        #region Các thành phần dữ liệu
        private int _manhanvien;
        private string _tennhanvien;
        private string _diachi;
        private string _sodienthoai;
        private string _email;
        private double _hesoluong;
        private static int _luongcoban;
        #endregion
        #region Các thuộc tính
        public int Manhanvien
        {
            get { return _manhanvien; }
            set
            {
                _manhanvien = value;
            }
        }
        public string Tennhanvien
        {
            get { return _tennhanvien; }
            set
            {
                _tennhanvien = value;
            }
        }
        public string Diachi
        {
            get { return _diachi; }
            set
            {
                _diachi = value;
            }
        }
        public string Sodienthoai
        {
            get { return _sodienthoai; }
            set
            {
                _sodienthoai = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }
        public double Hesoluong
        {
            get { return _hesoluong; }
            set
            {
                if (value > 0)
                    _hesoluong = value;
            }
        }
        public static int Luongcoban
        {
            get { return _luongcoban; }
            set
            {
                if (value >= 0)
                    _luongcoban = value;
            }
        }
        #endregion
        #region Các phương thức
        public NhanVien() { }
        public NhanVien(int _manhanvien, string _tennhanvien, string _diachi, string _sodienthoai, string _email, double _hesoluong)
        {
            this._manhanvien = _manhanvien;
            this._tennhanvien = _tennhanvien;
            this._diachi = _diachi;
            this._sodienthoai = _sodienthoai;
            this._email = _email;
            this._hesoluong = _hesoluong;
           
        }
        public NhanVien(NhanVien t)
        {
            this._manhanvien = t._manhanvien;
            this._tennhanvien = t._tennhanvien;
            this._diachi = t._diachi;
            this._sodienthoai = t._sodienthoai;
            this._email = t._email;
            this._hesoluong = t._hesoluong;
      
        }
        public NhanVien(int _manhanvien, string _tennhanvien, string _diachi, string _sodienthoai, string _email, double _hesoluong)
        {
            this._manhanvien = _manhanvien;
            this._tennhanvien = _tennhanvien;
            this._diachi = _diachi;
            this._sodienthoai = _sodienthoai;
            this._email = _email;
            this._hesoluong = _hesoluong;
        }
        public double Luong()
        {
            return _luongcoban * _hesoluong;
        }
        #endregion
    }
}
