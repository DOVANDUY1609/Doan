using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Untility;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    class GiabanDAL : IDGiabanDAL
    {
        //Xác định đường dẫn của tệp dữ liệu SanPham.txt
        private string txtfile = "Data/Giaban.txt";
        //lay du lieu tu gia ban dua vao danh sach

        public List<Gia_ban> LayDSGiaban()
        {
            List<Gia_ban> list = new List<Gia_ban>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Gia_ban(int.Parse(a[0]), a[1], int.Parse(a[2])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }

        //Chèn một bản ghi học sinh vào tệp
        public void ThemGiaban(Gia_ban sp)
        {
            string mahang = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahang + "#" + sp.tenhang + "#" + sp.Giaban);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Gia_ban> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].mahang + "#" + list[i].tenhang + "#" + list[i].Giaban);
            fwrite.Close();
        }
    }
}
