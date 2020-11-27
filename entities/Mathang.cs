using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStore.Entities
{

    public class Mathang
    {
        private int Mahang;
        private string TenHang;
        private int MaLoai;
        private int Soluongnhapve;
        private int Soluonghienco;
        public int mahang
        {
            get
            {
                return Mahang;
            }
            set
            {
                if (value >0)
                    Mahang = value;
            }
        }
        public string tenhang
        {
            get
            {
                return TenHang;
            }
            set
            {
                if (value != "")
                    TenHang = value;
            }
        }

        public int maloai
        {
            get
            {
                return MaLoai;
            }
            set
            {
                if (value > 0)
                    MaLoai = value;
            }
        }
        public int soluongnhapve
        {
            get
            {
                return Soluongnhapve;
            }
            set
            {
                if (value > 0)
                    Soluongnhapve = value;
            }
        }
        public int soluonghienco
        {
            get
            {
                return Soluonghienco;
            }
            set
            {
                if (value > 0)
                    Soluonghienco = value;
            }
        }

        public Mathang()
        {

        }
        public Mathang(Mathang hh)
        {
            Mahang = hh.mahang;
            TenHang = string.Copy(hh.tenhang);
            MaLoai =hh.maloai;
            Soluongnhapve = hh.soluongnhapve;
            Soluonghienco = hh.soluonghienco;

        }
        public Mathang(int mh, string th, int ml, int slnv, int slhc)
        {
            Mahang = mh;
            TenHang = th;
            MaLoai = ml;
            Soluonghienco = slhc;
            Soluongnhapve = slnv;

        }
    }
}
