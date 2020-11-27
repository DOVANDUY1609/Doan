using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Business;
using MyStore.Entities;

namespace MyStore.Presenation
{
    public class formKhachhang
    {
        private IDKhachhangBLL spDLL = new KhachhangBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN KHACH HANG");
            Khachhang sp = new Khachhang();
            // Console.Write("Nhap ma khach hang:"); sp.makh = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten khach hang:"); sp.tenkhachhang = Console.ReadLine();
            Console.Write("Nhap sdt :"); sp.sdt = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi :"); sp.diachi = Console.ReadLine();
            spDLL.ThemKhachHang(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                     HIEN THI THONG TIN KHACH HANG");
            Console.WriteLine("\t"+"makh" + "\t" + "tenkhachhang" + "\t\t" + "sdt" + "\t\t" + "diachi");
            List<Khachhang> list = spDLL.LayDSKhachhang();
            foreach (var sp in list)
                Console.WriteLine("\t"+sp.makh + "\t" + sp.tenkhachhang + "\t\t" + sp.sdt + "\t\t" + sp.diachi);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN KHACH HANG");
            List<Khachhang> list = spDLL.LayDSKhachhang();
            string makh;
            Console.Write("Nhap ma khach hang can sua:");
            makh = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].makh == makh) break;

            if (i < list.Count)
            {
                Khachhang sp = new Khachhang(list[i]);
                Console.Write("Nhap ten khach hang moi:");
                string ten = Console.ReadLine();
                if (ten != "") sp.tenkhachhang = ten;
                Console.Write("SDT moi:");
                int SDT = int.Parse(Console.ReadLine());
                if (SDT > 0) sp.sdt = SDT;
                spDLL.SuaKhachhang(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN KHACH HANG ");
            List<Khachhang> list = spDLL.LayDSKhachhang();
            string ma;
            Console.Write("Nhap ma khach hang can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].makh == ma) break;
            if (i < list.Count)
            {
                Khachhang x = new Khachhang(list[i]);
                spDLL.XoaKhachhang(x);
            }
        }

    }
}
