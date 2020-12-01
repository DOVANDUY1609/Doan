using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Business;
using MyStore.Entities;

namespace MyStore.Presenation
{
    public class formNhanvien
    {
        private IDNhanvienBLL spDLL = new NhanvienBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN NHAN VIEN");
            Nhan_vien sp = new Nhan_vien();
            Console.Write("Nhap ten nhan vien:"); sp.tennv = Console.ReadLine();
            Console.Write("Nhap gioi tinh :"); sp.gioitinh = Console.ReadLine();
            Console.Write("Nhap ngay sinh :");sp.ngaysinh=DateTime.Parse(Console.ReadLine());
            spDLL.Themnhanvien(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                    HIEN THI THONG TIN NHAN VIEN");
            Console.WriteLine("\t"+"Manv" +"\t" + "tennv" + "\t" + "Gioitinh" + "\t" + "ngaysinh");
            List<Nhan_vien> list = spDLL.LayDSnhanvien();
            foreach (var sp in list)
                Console.WriteLine("\t"+sp.manv + "\t" + sp.tennv + "\t" + sp.gioitinh + "\t\t" + sp.ngaysinh);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN NHAN VIEN ");
            List<Nhan_vien> list = spDLL.LayDSnhanvien();
            string ma;
            Console.Write("Nhap ma nv can sua:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].manv == ma) break;

            if (i < list.Count)
            {
                Nhan_vien sp = new Nhan_vien(list[i]);
                Console.Write("Nhap ten nhan vien moi:");
                string ten = Console.ReadLine();
                if (ten != "") sp.tennv = ten;
                Console.Write("gioi tinh moi:");
                string gioitinh = Console.ReadLine();
                if (gioitinh != "") sp.gioitinh = gioitinh;
                Console.Write("Ngay sinh moi:");
                DateTime ns = DateTime.Parse(Console.ReadLine());
                sp.ngaysinh = ns;
                spDLL.Suanhanvien(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN NHAN VIEN ");
            List<Nhan_vien> list = spDLL.LayDSnhanvien();
            string ma;
            Console.Write("Nhap ma nv can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].manv == ma) break;

            if (i < list.Count)
            {
                Nhan_vien b = new Nhan_vien(list[i]);
                spDLL.Xoanhanvien(b);
            }
        }
        public void timkiem()
        {
            Console.Clear();
            Console.Write("Nhap ma nhan vien can tim :");
            string ma = Console.ReadLine();
            Console.WriteLine("                HIEN THI THONG TIN TIM KIEM");
            Console.WriteLine("\t" + "Manv" + "\t" + "tennv" + "\t" + "Gioitinh" + "\t" + "ngaysinh");
            foreach (var sp in spDLL.LayDSnhanvien())
                if (sp.manv.Contains(ma))
                    Console.WriteLine("\t" + sp.manv + "\t" + sp.tennv + "\t" + sp.gioitinh + "\t\t" + sp.ngaysinh);
            Console.ReadLine();
        }
    }
}

