using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Entities
{

        public class SanPham
        {
            #region Các thành phần dữ liệu
            private string masanpham;
            private string tensanpham;
            private int dongia;
            #endregion

            #region Các thuộc tính
            public string MaSanPham
            {
                get { return masanpham; }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                        masanpham = value;
                }
            }
            public string TenSanPham
            {
                get { return tensanpham; }
                set
                {
                    if (!string.IsNullOrEmpty(value))
                        tensanpham = value;
                }
            }
            public int DonGia
            {
                get { return dongia; }
                set
                {
                    if (value > 0)
                        dongia = value;
                }
            }
            #endregion

            #region Các thương thức             
            public SanPham() { }
            //Phương thức thiết lập sao chép
            public SanPham(SanPham sp)
            {
                this.masanpham = sp.masanpham;
                this.tensanpham = sp.tensanpham;
                this.dongia = sp.dongia;
            }
            public SanPham(string masanpham, string tensanpham, int dongia)
            {
                this.masanpham = masanpham;
                this.tensanpham = tensanpham;
                this.dongia = dongia;
            }
            #endregion
        }
}

