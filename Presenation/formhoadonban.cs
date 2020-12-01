using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Business;
using MyStore.Entities;

namespace MyStore.Presenation
{
    public class formHoadonban
    {
        private IDHoadonbanBLL spDLL = new HoadonbanBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("           NHAP THONG TIN HOA DON BAN    ");
            Hoadonban sp = new Hoadonban();
          //  Console.Write("Nhap ma hoa don ban:"); sp.mahdb = int.Parse(Console.ReadLine());
            Console.Write("Nhap ma nvb:"); sp.manvb = Console.ReadLine();
            Console.Write("Nhap ngay ban :"); sp.ngayban =DateTime.Parse( Console.ReadLine());
            Console.Write(" Nhap so luong :"); sp.Soluong = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia :"); sp.Gia = double.Parse(Console.ReadLine());
            spDLL.Themhoadonban(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                    HIEN THI THONG TIN HOA DON BAN");
            Console.WriteLine("\t"+"mahdb" + "\t" + "manvb" + "\t" + "ngayban" + "\t\t\t" + "Soluong"+"\t\t"+"Gia" );
            List<Hoadonban> list = spDLL.LayDSHoadonban();
            foreach (var sp in list)
                Console.WriteLine("\t"+sp.mahdb + "\t" + sp.manvb + "\t" + sp.ngayban + "\t" + sp.Soluong +"\t\t"+sp.Gia);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HOA DON BAN");
            List<Hoadonban> list = spDLL.LayDSHoadonban();
            string ma;
            Console.Write("Nhap ma hoa don ban can sua:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahdb==ma) break;

            if (i < list.Count)
            {
                Hoadonban sp = new Hoadonban(list[i]);
                Console.Write("Nhap ma nvb:");
                string manvb = Console.ReadLine();
                if (manvb != "") sp.manvb = manvb;
                Console.Write("ngay ban moi:");
                DateTime nb =DateTime.Parse( Console.ReadLine());
                sp.ngayban = nb;
                Console.Write("Nhap so luong:");
                int slg = int.Parse(Console.ReadLine());
                if (slg > 0) sp.Soluong = slg;
                Console.Write("Nhap gia moi:");
                int g = int.Parse(Console.ReadLine());
                if (g > 0) sp.Soluong = g;
                spDLL.Suahoadonban(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma hoa don ban nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN HOA DON BAN ");
            List<Hoadonban> list = spDLL.LayDSHoadonban();
            string ma;
            Console.Write("Nhap ma hoa don ban can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahdb == ma) break;

            if (i < list.Count)
            {
                Hoadonban b = new Hoadonban(list[i]);
                spDLL.Xoahoadonban(b);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }
        }
         public void timkiem()
        {
            Console.Clear();
            Console.Write("Nhap ma hoa don ban can tim :");
            string ma = Console.ReadLine();
            Console.WriteLine("                    HIEN THI THONG TIN TIM KIEM");
            Console.WriteLine("\t" + "mahdb" + "\t" + "manvb" + "\t" + "ngayban" + "\t\t\t" + "Soluong" + "\t" + "Gia");
            foreach (var sp in spDLL.LayDSHoadonban())
                if (sp.mahdb.Contains(ma))
                    Console.WriteLine("\t" + sp.mahdb + "\t" + sp.manvb + "\t" + sp.ngayban + "\t" + sp.Soluong + "\t" + sp.Gia);
            Console.ReadLine();
        }
    }
}
