using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Business;
using MyStore.Entities;

namespace MyStore.Presenation
{
    public class formGiaban
    {
        private IDGiabanBLL spDLL = new GiabanBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN GIA BAN");
            Gia_ban sp = new Gia_ban();
            Console.Write("Nhap ten hang:"); sp.tenhang = Console.ReadLine();
            Console.Write("Nhap gia ban :"); sp.Giaban = int.Parse(Console.ReadLine());
            spDLL.Themgiaban(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("               HIEN THI THONG TIN GIA BAN");
            Console.WriteLine("\t"+"mahang" + "\t\t" + "tenhang" + "\t\t" + "Giaban");
            List<Gia_ban> list = spDLL.LayDSGiaban();
            foreach (var sp in list)
                Console.WriteLine("\t"+sp.mahang + "\t" + sp.tenhang + "\t\t" + sp.Giaban);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN GIA BAN");
            List<Gia_ban> list = spDLL.LayDSGiaban();
            int tenh;
            Console.Write("Nhap ma san pham can sua:");
            tenh = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang==tenh) break;

            if (i < list.Count)
            {
                Gia_ban sp = new Gia_ban(list[i]);
                Console.Write("Nhap ten moi:");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten)) sp.tenhang = ten;
                Console.Write("Gia moi:");
                int gia = int.Parse(Console.ReadLine());
                if (gia > 0) sp.Giaban = gia;
                spDLL.Suagiaban(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN GIA BAN ");
            List<Gia_ban> list = spDLL.LayDSGiaban();
            int ma;
            Console.Write("Nhap ma hang can xoa:");
            ma = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang == ma) break;

            if (i < list.Count)
            {
                Gia_ban b = new Gia_ban(list[i]);
                spDLL.Xoagiaban(b);
            }
        }
        public void timkiem()
        {
            Console.Clear();
            Console.WriteLine(" THONG TIN TIM KIEM");
            List<Gia_ban> list = spDLL.LayDSGiaban();
            int ma;
            Console.Write("Nhap ma hang can tim:");
            ma =int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang == ma) break;

            if (i < list.Count)
            {
                Gia_ban b = new Gia_ban(list[i]);
                spDLL.Timkiem(b);
            }
        }
        public void  Hientimkiem()
        {
            Console.Clear();
            Console.WriteLine("HIEN THONG TIN TIM KIEM");
            List<Gia_ban> list = spDLL.LayDSGiaban();
            int ma;
            Console.Write("Nhap ma hang can hien thi:");
            ma = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang ==ma ) break;
            if (i < list.Count)
            {

                Gia_ban b = new Gia_ban(list[i]);
                spDLL.Hientimkiem(b);
            }
         
        }
    }
}
