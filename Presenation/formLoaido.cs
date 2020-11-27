using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Business;
using MyStore.Entities;

namespace MyStore.Presenation
{
    public class formLoaido
    {
        private IDLoaidoBLL spDLL = new LoaidoBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN LOAI DO");
            Loaido sp = new Loaido();
            Console.Write("Nhap ten loai:"); sp.tenloai = Console.ReadLine();
            Console.Write("Nhap dac diem :"); sp.dacdiem = Console.ReadLine();
            spDLL.ThemLoaido(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("               HIEN THI THONG TIN LOAI DO");
            Console.WriteLine("\t"+"maloai" + "\t" + "tenloai" + "\t\t" + "dacdiem");
            List<Loaido> list = spDLL.LayDSLoaido();
            foreach (var sp in list)
                Console.WriteLine("\t"+sp.maloai + "\t" + sp.tenloai + "\t\t" + sp.dacdiem);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN LOAI DO ");
            List<Loaido> list = spDLL.LayDSLoaido();
            int ma;
            Console.Write("Nhap ma loai can sua:");
            ma = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].maloai == ma) break;

            if (i < list.Count)
            {
                Loaido sp = new Loaido(list[i]);
                Console.Write("Nhap ten loai moi:");
                string ten = Console.ReadLine();
                if (ten != "") sp.tenloai = ten;
                Console.Write("Dac diem:");
                string dacdiem = Console.ReadLine();
                if (dacdiem != "") sp.dacdiem = dacdiem;
                spDLL.SuaLoaido(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN LOAI DO");
            List<Loaido> list = spDLL.LayDSLoaido();
            int ma;
            Console.Write("Nhap ma loai can xoa:");
            ma = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].maloai == ma) break;

            if (i < list.Count)
            {
                Loaido b = new Loaido(list[i]);
                spDLL.XoaLoaido(b);
            }
        }
    }
}
