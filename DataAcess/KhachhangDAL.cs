using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    class KhachhangDAL : IDKhachhangDAL
    {
        //Xác định đường dẫn của tệp dữ liệu SanPham.txt
        private string txtfile = "Data/Khachhang.txt";
        //lay du lieu tu gia ban dua vao danh sach

        public List<Khachhang> LayDSKhachhang()
        {
            List<Khachhang> list = new List<Khachhang>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Khachhang(a[0], a[1], int.Parse(a[2]), a[3]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi học sinh vào tệp
        public void Themkhachhang(Khachhang sp)
        {
            string makh = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(makh + "#" + sp.tenkhachhang + "#" + sp.sdt + "#" + sp.diachi);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Khachhang> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].makh + "#" + list[i].tenkhachhang + "#" + list[i].sdt + "#" + list[i].diachi);
            fwrite.Close();
        }
    }
}
