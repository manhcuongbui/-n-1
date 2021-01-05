using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Business;
using đồ_án_1.Business.Interface;


namespace đồ_án_1.Entities
{
    public class SanPham
    {
        private string masp, tensp;
        private int  giaban;
        
        public string Masp
        {
            get { return masp; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    masp = value;
            }
        }
        
        public string Tensp
        {
            get { return tensp; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tensp = value;
            }
        }
       
        public int Giaban
        {
            get { return giaban; }
            set
            {
                if (value > 0)
                    giaban = value;
            }
        }
       
        //Phương thức thiết lập 
        public SanPham() { }
        public SanPham(SanPham sp)
        {
            this.masp = sp.masp;
           
            this.tensp = sp.tensp;
          
            this.giaban = sp.giaban;
         
        }
        public SanPham(string masp,  string tensp, int giaban)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.giaban = giaban;
        }
    }
}

