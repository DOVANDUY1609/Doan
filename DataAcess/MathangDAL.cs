using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    class MathangDAL : IDMathangDAL
    {
        //Xác định đường dẫn của tệp dữ liệu SanPham.txt
        private string txtfile = "Data/Mathang.txt";
        //lay du lieu tu gia ban dua vao danh sach

        public List<Mathang> LayDSMathang()
        {
            List<Mathang> list = new List<Mathang>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Mathang(int.Parse(a[0]), a[1],int.Parse(a[2]), int.Parse(a[3]), int.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }

        //Chèn một bản ghi học sinh vào tệp
        public void Themmathang(Mathang mh)
        {
            string mahang = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahang + "#" + mh.tenhang + "#" + mh.maloai + "#" + mh.soluonghienco + "#" + mh.soluongnhapve);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Mathang> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].mahang + "#" + list[i].tenhang + "#" + list[i].maloai + "#" + list[i].soluonghienco + "#" + list[i].soluongnhapve);
            fwrite.Close();
        }
    }
}
