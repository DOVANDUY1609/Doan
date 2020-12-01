using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Business;
using MyStore.Entities;

namespace MyStore.Presenation
{
    public class formHoadonnhap
    {
        private IDHoadonnhapBLL spDLL = new HoadonnhapBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("           NHAP THONG TIN HOA DON NHAP    ");
            Hoadonnhap sp = new Hoadonnhap();
            Console.Write("Nhap ma nha cung cap:"); sp.mancc =int.Parse(Console.ReadLine());
            Console.Write("Nhap mann :"); sp.mann = Console.ReadLine();
            Console.Write(" Nhap ngay nhan :"); sp.ngaynhan =DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ghi chu :"); sp.ghichu = Console.ReadLine();
            spDLL.Themhoadonnhap(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                   HIEN THI THONG TIN HOA DON NHAP");
            Console.WriteLine("\t"+"mahdn" + "\t" + "mancc" + "\t" + "mann" + "\t" + "ngaynhan"+ "\t\t\t" + "ghichu");
            List<Hoadonnhap> list = spDLL.LayDSHoadonnhap();
            foreach (var sp in list)
                Console.WriteLine("\t"+sp.mahdn + "\t" + sp.mancc + "\t" + sp.mann + "\t" + sp.ngaynhan  + "\t\t" + sp.ghichu);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HOA DON NHAP");
            List<Hoadonnhap> list = spDLL.LayDSHoadonnhap();
            string ma;
            Console.Write("Nhap ma hoa don nhap can sua:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahdn == ma) break;

            if (i < list.Count)
            {
                Hoadonnhap sp = new Hoadonnhap(list[i]);
                Console.Write("Nhap ma ncc:");
                int macc =int.Parse(Console.ReadLine());
                if (macc != 0) sp.mancc = macc;
                Console.Write("ngay mann moi:");
                string mann = Console.ReadLine();
                if (mann != "") sp.mann = mann;
                Console.Write("Nhap ngay ban:");
                DateTime nn =DateTime.Parse( Console.ReadLine());
                sp.ngaynhan = nn;
                Console.Write("Nhap ghi chu moi :");
                string gc = Console.ReadLine();
                if (gc != "") sp.ghichu = gc;
                spDLL.Suahoadonnhap(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma hoa don ban nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN HOA DON NHAP ");
            List<Hoadonnhap> list = spDLL.LayDSHoadonnhap();
            string ma;
            Console.Write("Nhap ma hoa don nhap can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahdn == ma) break;

            if (i < list.Count)
            {
                Hoadonnhap b = new Hoadonnhap(list[i]);
                spDLL.Xoahoadonnhap(b);
            }
        }
         public void timkiem()
        {
            Console.Clear();
            Console.Write("Nhap ma hoa don nhap can tim :");
            string ma = Console.ReadLine();
            Console.WriteLine("                    HIEN THI THONG TIN TIM KIEM");
            Console.WriteLine("\t" + "mahdn" + "\t" + "mancc" + "\t" + "mann" + "\t" + "ngaynhan" + "\t\t\t" + "ghichu");
            foreach (var sp in spDLL.LayDSHoadonnhap())
                if (sp.mahdn.Contains(ma))
                    Console.WriteLine("\t" + sp.mahdn + "\t" + sp.mancc + "\t" + sp.mann + "\t" + sp.ngaynhan + "\t\t" + sp.ghichu);
            Console.ReadLine();
        }
    }
}
