using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;
using đồ_án_1.DataAccessLayer.Interface;
using đồ_án_1.DataAccessLayer;




namespace đồ_án_1.DataAccessLayer
{
    public class NhanVienDAL : INhanVienDAL
    {
        //Xác định đường dẫn của tệp dữ liệu Nhân viên.txt 
        private string txtfile = "Data/NhanVien.txt";
        //Lấy toàn bộ dữ liệu có trong file NhanVien.txt đưa vào một danh sách 
        public List<NhanVien> GetAllNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            StreamReader fread = File.OpenText(txtNhanVien);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new NhanVien ((a[0]), a[1], a[2], a[3], a[4]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi nhan vien vào tệp
        public void ThemNhanVien(NhanVien nv )
        {
            string manhanvien = nv.Manhanvien;
            StreamWriter fwrite = File.AppendText(txtNhanVien);
            fwrite.WriteLine();
            fwrite.Write(manhanvien + "#" + nv.Tennhanvien +  "#" + nv.Diachi + "#" + nv.Sodienthoai);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<NhanVien> list)
        {
            StreamWriter fwrite = File.CreateText(txtNhanVien);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Manhanvien+ "#" + list[i].Tennhanvien +"#" + list[i].Diachi + "#" + list[i].Sodienthoai);
            fwrite.Close();
        }
    }
}
