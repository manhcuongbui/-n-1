using System;
using System.Collections.Generic;
using System.Text;
using đồ_án_1.Entities;
using đồ_án_1.DataAccessLayer.Interface;



namespace đồ_án_1.DataAccessLayer
{
    class SanPhamDAL : ISanPhamDAL
    {
        //Xác định đường dẫn của tệp dữ liệu SanPham.txt
        private string txtfile = "Data/SanPham.txt";
        //Lấy toàn bộ dữ liệu có trong file SanPham.txt đưa vào một danh sách 
        public List<SanPham> GetAllSanPham()
        {
            List<SanPham> list = new List<SanPham>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new SanPham(a[0], a[1], int.Parse(a[2])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi học sinh vào tệp
        public void ThemSanPham(SanPham sp)
        {
            string masanpham = "SP" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(masanpham + "#" + sp.TenSanPham + "#" + sp.DonGia);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<SanPham> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].MaSanPham + "#" + list[i].TenSanPham + "#" + list[i].DonGia);
            fwrite.Close();
        }
    }
}
