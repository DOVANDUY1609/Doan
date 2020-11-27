using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    class HoadonnhapDAL : IDHoadonnhapDAL
    {
        //Xác định đường dẫn của tệp dữ liệu SanPham.txt
        private string txtfile = "Data/Hoadonnhap.txt";
        //lay du lieu tu gia ban dua vao danh sach

        public List<Hoadonnhap> LayDSHoadonnhap()
        {
            List<Hoadonnhap> list = new List<Hoadonnhap>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Hoadonnhap(a[0],int.Parse(a[1]),a[2], DateTime.Parse(a[3]),a[4]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }

        //Chèn một bản ghi học sinh vào tệp
        public void Themhoadonnhap(Hoadonnhap sp)
        {
            string mahdn = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahdn + "#" + sp.mancc + "#" + sp.mann + "#" + sp.ngaynhan + "#" + sp.ghichu);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Hoadonnhap> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].mahdn + "#" + list[i].mancc + "#" + list[i].mann + "#" + list[i].ngaynhan  + "#" + list[i].ghichu);
            fwrite.Close();
        }
    }
}
