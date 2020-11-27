using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    class LoaidoDAL : IDLoaidoDAL
    {
        //Xác định đường dẫn của tệp dữ liệu SanPham.txt
        private string txtfile = "Data/Loaido.txt";
        //lay du lieu tu gia ban dua vao danh sach

        public List<Loaido> LayDSLoaido()
        {
            List<Loaido> list = new List<Loaido>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Loaido(int.Parse(a[0]), a[1], a[2]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
//Chèn một bản ghi học sinh vào tệp
        public void Themdo(Loaido sp)
        {
            string maloai = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(maloai + "#" + sp.tenloai + "#" + sp.dacdiem);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Loaido> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].maloai + "#" + list[i].tenloai + "#" + list[i].dacdiem);
            fwrite.Close();
        }
    }
}
