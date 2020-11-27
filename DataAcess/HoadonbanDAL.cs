using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    class HoadonbanDAL : IDHoadonbanDAL
    {
        //Xác định đường dẫn của tệp dữ liệu SanPham.txt
        private string txtfile = "Data/Hoadonban.txt";
        //lay du lieu tu gia ban dua vao danh sach

        public List<Hoadonban> LayDSHoadonban()
        {
            List<Hoadonban> list = new List<Hoadonban>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Hoadonban(a[0], a[1],DateTime.Parse( a[2]), int.Parse(a[3]), double.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi học sinh vào tệp
        public void Themhoadonban(Hoadonban sp)
        {
            string mahdb = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahdb + "#" + sp.manvb + "#" + sp.ngayban + "#" + sp.Soluong + "#" + sp.Gia);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Hoadonban> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].mahdb + "#" + list[i].manvb + "#" + list[i].ngayban + "#" + list[i].Soluong + "#" + list[i].Gia );
            fwrite.Close();
        }
    }
}
