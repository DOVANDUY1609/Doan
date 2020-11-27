using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    class NhacungcapDAL : IDNhacungcapDAL
    {
        //Xác định đường dẫn của tệp dữ liệu SanPham.txt
        private string txtfile = "Data/Nhacungcap.txt";
        //lay du lieu tu gia ban dua vao danh sach

        public List<Nhà_cung_cấp> LayDSNhacungcap()
        {
            List<Nhà_cung_cấp> list = new List<Nhà_cung_cấp>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Nhà_cung_cấp(int.Parse(a[0]), a[1],int.Parse( a[2]), a[3]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }

        //Chèn một bản ghi học sinh vào tệp
        public void Them_nha_cung_cap(Nhà_cung_cấp sp)
        {
            string mancc = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mancc + "#" + sp.tenncc + "#" + sp.sdt + "#" + sp.diachi);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Nhà_cung_cấp> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].mancc + "#" + list[i].tenncc + "#" + list[i].sdt + "#" + list[i].diachi);
            fwrite.Close();
        }
    }
}
