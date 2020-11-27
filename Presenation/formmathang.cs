using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyStore.Business;
using MyStore.Entities;

namespace MyStore.Presenation
{
    public class form_mathang
    {
        private IDMathangBLL spDLL = new MathangBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN MAT HANG");
            Mathang sp = new Mathang();
            Console.Write("Nhap ten hang:"); sp.tenhang = Console.ReadLine();
            Console.Write("Nhap ma loai :"); sp.maloai = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong hien co:"); sp.soluonghienco = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong nhap ve:"); sp.soluongnhapve = int.Parse(Console.ReadLine());
            spDLL.ThemMathang(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                            HIEN THI THONG TIN MAT HANG");
            Console.WriteLine("\t"+"mahang" + "\t" + "tenhang" + "\t\t" + "maloai" + "\t" + "soluonghienco "+ "\t" + "soluongnhapve");
             List<Mathang> list = spDLL.LayDSMathang();
            foreach (var sp in list)
                Console.WriteLine("\t"+sp.mahang + "\t" + sp.tenhang + "\t" + sp.maloai + "\t" + sp.soluonghienco + "\t\t" + sp.soluongnhapve);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN GIA BAN");
            List<Mathang> list = spDLL.LayDSMathang();
            int ma;
            Console.Write("Nhap ma mat hang can sua:");
            ma =int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang == ma) break;

            if (i < list.Count)
            {
                Mathang sp = new Mathang(list[i]);
                Console.Write("Nhap ten moi:");
                string ten = Console.ReadLine();
                if (ten != "") sp.tenhang = ten;
                Console.Write("ma loai moi:");
                int ml =int.Parse(Console.ReadLine());
                if (ml != 0) sp.maloai = ml;
                spDLL.SuaMathang(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }

        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN MAT HANG ");
            List<Mathang> list = spDLL.LayDSMathang();
            int ma;
            Console.Write("Nhap ma nv can xoa:");
            ma = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang == ma) break;

            if (i < list.Count)
            {
                Mathang b = new Mathang(list[i]);
                spDLL.XoaMathang(b);
            }
        }
    }
}
