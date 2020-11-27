using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Business;
using MyStore.Entities;

namespace MyStore.Presenation
{
    public class form_nhacungcap
    {
        private IDNhacungcapBLL spDLL = new NhacungcapBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN NHA CUNG CAP");
            Nhà_cung_cấp sp = new Nhà_cung_cấp();
            Console.Write("Nhap SDT nha cung cap :"); sp.sdt = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten nha cung cap:"); sp.tenncc = Console.ReadLine();
            Console.Write("Nhap dia chi nha cung cap : "); sp.diachi = Console.ReadLine();
            spDLL.Themnhacungcap(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                   HIEN THI THONG TIN NHA CUNG CAP");
            Console.WriteLine("\t"+"mancc" + "\t" + "tenncc" + "\t" + "sdt"+ "\t\t" + "diachi");
            List<Nhà_cung_cấp> list = spDLL.LayDSNhacungcap();
            foreach (var sp in list)
                Console.WriteLine("\t"+sp.mancc + "\t" + sp.tenncc + "\t" + sp.sdt + "\t\t" + sp.diachi);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN NHA CUNG CAP ");
            List<Nhà_cung_cấp> list = spDLL.LayDSNhacungcap();
            int ma;
            Console.Write("Nhap ma nha cung cap can sua:");
            ma =int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mancc == ma) break;

            if (i < list.Count)
            {
                Nhà_cung_cấp sp = new Nhà_cung_cấp(list[i]);
                Console.Write("Nhap ten ncc moi:");
                string ten = Console.ReadLine();
                if (ten != "") sp.tenncc = ten;
                Console.Write("sdt moi:");
                int sdt = int.Parse(Console.ReadLine());
                if (sdt > 0) sp.sdt = sdt;
                Console.Write("dia chi moi :");
                string dc = Console.ReadLine();
                if (dc != "") sp.diachi = dc;
                spDLL.Suanhacungcap(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN NHA CUNG CAP ");
            List<Nhà_cung_cấp> list = spDLL.LayDSNhacungcap();
            int ma;
            Console.Write("Nhap ma  nha cung cap can xoa:");
            ma = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mancc == ma) break;

            if (i < list.Count)
            {
                Nhà_cung_cấp b = new Nhà_cung_cấp(list[i]);
                spDLL.XoaNhacungcap(b);
            }
        }
    }
}
