using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    class NhanvienDAL : IDNhanvienDAL
    {
        //Xác định đường dẫn của tệp dữ liệu SanPham.txt
        private string txtfile = "Data/Nhanvien.txt";
        //lay du lieu tu gia ban dua vao danh sach

        public List<Nhan_vien> LayDSNhanvien()
        {
            List<Nhan_vien> list = new List<Nhan_vien>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Nhan_vien(a[0], a[1], a[2], DateTime.Parse(a[3])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }

        //Chèn một bản ghi học sinh vào tệp
        public void Themnhanvien(Nhan_vien gb)
        {
            string Manv = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(Manv + "#" + gb.tennv + "#" + gb.gioitinh + "#" + gb.ngaysinh);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<Nhan_vien> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].manv + "#" + list[i].tennv + "#" + list[i].gioitinh + "#" + list[i].ngaysinh);
            fwrite.Close();
        }
    }
}
