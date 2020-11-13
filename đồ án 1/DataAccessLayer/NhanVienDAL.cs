using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;
using đồ_án_1.DataAccessLayer.Interface;


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
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new NhanVien(int.Parse(a[0]), a[1], a[2], a[3], a[4], double.Parse(a[5])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Lấy mã nhân viên của bản ghi cuối cùng phục vụ cho đánh mã tự động
        public int GetMaNV()
        {
            try
            {
                StreamReader fread = File.OpenText(txtfile);
                string s = fread.ReadLine();
                string tmp = "";
                while (s != null)
                {
                    if (s != "") tmp = s;
                    s = fread.ReadLine();
                }
                fread.Close();
                if (tmp == "") return 0;
                else
                {
                    string[] a = tmp.Split('#');
                    return int.Parse(a[0]);
                }
            }
            catch
            {
                return 0;
            }
        }
        //Chèn một bản ghi nhân viên vào tệp
        //Mã nhân viên, họ tên, địa chỉ, số điện thoại, email, hệ số lương
        public void Insert(NhanVien nv)
        {
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(nv.Manhanvien + "#" + nv.Tennhanvien + "#" + nv.Diachi + "#" + nv.Sodienthoai + "#" + nv.Email + "#" + nv.Hesoluong);
            fwrite.Close();
        }
        //Xóa một nhân viên khi biết mã
        public void Delete(int manv)
        {
            List<NhanVien> list = GetAllNhanVien();
            StreamWriter fwrite = File.CreateText(txtfile); fwrite.Close();
            foreach (NhanVien nv in list)
                if (nv.Manhanvien != manv)
                    Insert(nv);
            fwrite.Close();
        }
    }
}

