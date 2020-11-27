using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.Presenation;

namespace Quanlidodientu
{
    public class menu
    {
        private static formGiaban gb = new formGiaban();
        private static formHoadonban hdb = new formHoadonban();
        private static formHoadonnhap hdn = new formHoadonnhap();
        private static formKhachhang kh = new formKhachhang();
        private static formLoaido ld = new formLoaido();
        private static form_mathang mh = new form_mathang();
        private static form_nhacungcap ncc = new form_nhacungcap();
        private static formNhanvien nv = new formNhanvien();
        public static void HienMN()
        {
            ConsoleKeyInfo key;
            string[][] mn = new string[8][];
            mn[0] = new string[] { "1.Nhan vien►", "A.Nhập nhân viên", "B.Sửa nhân viên", "C.Xóa nhân viên", "D.Hiển thị nhân viên", "E.Tim kiem" };

            mn[1] = new string[] { "2.Khach hang ►", "X.Nhập khách hàng", "Y.Sửa khách hàng", "J.Xóa Khachhang", "W.Hien thi", "F.Tim kiem" };

            mn[2] = new string[] { "3.Loai do ►", "+.Nhập Loại đồ", "-.Sửa loại đồ", "!.Xóa loại đồ", ">.Hiển thị", "<.Tim kiem" };

            mn[3] = new string[] { "4.Mat hang ►", "(.Nhập mặt hàng", ").Sửa mặt hàng", "&.Xóa mặt hàng", "%.Hiển thị", "$.Tim kiem" };

            mn[4] = new string[] { "5.Gia ban ►", "R.Nhập giá bán", "S.Sửa giá bán", "T.Xóa giá bán", "U.Hiển thị", "V.Tim kiem",":.Hientimkiem" };

            mn[5] = new string[] { "6.Hoa don ban ►", "G.Nhập hóa đơn bán", "H.Sửa hóa đơn bán", "I.Xóa hóa đơn bán", "K.Hiển thị", "L.Tim kiem" };

            mn[6] = new string[] { "7.Hoa don nhap ►", "M.Nhập hóa đơn nhập", "N.Sửa hóa đơn nhập", "O.Xóa hóa đơn nhập", "P.Hiển thị", "Q.Tim kiem" };

            mn[7] = new string[] { "8.Nha cung cap ►", "@.Nhập nhà cung cấp", "#.Sửa nhà cung cấp ", "/.Xóa nhà cung cấp", "*.Hiển thị", "?.Tim kiem" };
           //Hien thi chuc năng đầu tiên
            int muc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\t     TRUONG TRINH QUAN LY DO DIEN TU\n\n");
                //Hiển thị các chức năng
                for (int i = 0; i < mn.Length; ++i)
                {
                    Console.WriteLine("\t\t" + mn[i][0]);
                    if (i == muc)
                        for (int j = 1; j < mn[i].Length; ++j)
                            Console.WriteLine("\t\t\t" + mn[i][j]);
                }
                key = Console.ReadKey(true);
                if (key.KeyChar >= '0' && key.KeyChar <= '9')
                    muc = key.KeyChar - 49;
                else if (key.Key == ConsoleKey.X && key.Modifiers == ConsoleModifiers.Alt)
                    Environment.Exit(0);
                else
                {
                    ThucHien(key.KeyChar);
                }
            } while (true);
        }
        public static void ThucHien(char ch)
        {
            switch (char.ToUpper(ch))
            {
                case 'A':
                    Console.Clear();
                    nv.Nhap();
                    break;
                case 'B':
                    Console.Clear();
                    nv.Sua();
                    break;
                case 'C':
                    Console.Clear();
                    nv.xoa(); break;
                case 'D':
                    Console.Clear();
                    nv.Hien();
                    Console.ReadKey(); break;
                case 'G':
                    Console.Clear();
                    hdb.Nhap();
                    break;
                case 'H':
                    Console.Clear();
                    hdb.Sua();
                    break;
                case 'I':
                    Console.Clear();
                    hdb.xoa(); break;
                case 'K':
                    Console.Clear();
                    hdb.Hien();
                    Console.ReadKey(); break;
                case 'M':
                    Console.Clear();
                    hdn.Nhap();
                    break;
                case 'N':
                    Console.Clear();
                    hdn.Sua();
                    break;
                case 'O':
                    Console.Clear();
                    hdn.xoa(); break;
                case 'P':
                    Console.Clear();
                    hdn.Hien();
                    Console.ReadKey(); break;
                case 'R':
                    Console.Clear();
                    gb.Nhap();
                    break;
                case 'S':
                    Console.Clear();
                    gb.Sua();
                    break;
                case 'T':
                    Console.Clear();
                    gb.xoa(); break;
                case 'U':
                    Console.Clear();
                    gb.Hien();
                    Console.ReadKey(); break;
                case 'E':
                    Console.Clear();
                    gb.Hientimkiem();
                    Console.ReadKey(); break;
                case 'X':
                    Console.Clear();
                    kh.Nhap();
                    break;
                case 'Y':
                    Console.Clear();
                    kh.Sua();
                    break;
                case 'J':
                    Console.Clear();
                    kh.xoa(); break;
                case 'W':
                    Console.Clear();
                    kh.Hien();
                    Console.ReadKey(); break;
                case '+':
                    Console.Clear();
                    ld.Nhap();
                    break;
                case '-':
                    Console.Clear();
                    ld.Sua();
                    break;
                case '!':
                    Console.Clear();
                    ld.xoa(); break;
                case '>':
                    Console.Clear();
                    ld.Hien();
                    Console.ReadKey(); break;
                case '(':
                    Console.Clear();
                    mh.Nhap();
                    break;
                case ')':
                    Console.Clear();
                    mh.Sua();
                    break;
                case '&':
                    Console.Clear();
                    mh.xoa(); break;
                case '%':
                    Console.Clear();
                    mh.Hien();
                    Console.ReadKey(); break;
                case '@':
                    Console.Clear();
                    ncc.Nhap();
                    break;
                case '#':
                    Console.Clear();
                    ncc.Sua();
                    break;
                case '/':
                    Console.Clear();
                    ncc.xoa(); break;
                case '*':
                    Console.Clear();
                    ncc.Hien();
                    Console.ReadKey(); break;

            }
        }
    }
}


