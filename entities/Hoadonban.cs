using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Entities
{
    public class Hoadonban
    {
        private string Mahdb;
        private string Manvb;
        private DateTime Ngayban;
        private int soluong;
        private double gia;
        public string mahdb
        {
            get
            {
                return Mahdb;
            }
            set
            {
                if (value != "")
                    Mahdb = value;
            }
        }

        public string manvb
        {
            get
            {
                return Manvb;
            }
            set
            {
                if (value != "")
                    Manvb = value;
            }
        }

        public DateTime ngayban
        {
            get
            {
                return Ngayban;
            }
            set
            {

                Ngayban = value;
            }
        }
        public int Soluong
        {
            get
            {
                return soluong;
            }
            set
            {
                if (value > 0)
                    soluong = value;
            }
        }
        public double Gia
        {
            get
            {
                return gia;
            }
            set
            {
                if (value > 0)
                    gia = value;
            }
        }
        public Hoadonban()
        {
        }
        public Hoadonban(Hoadonban hdb)
        {
            Mahdb =hdb.mahdb;
            Manvb = hdb.Manvb;
            Ngayban = hdb.ngayban;
            soluong = hdb.Soluong;
            gia = hdb.Gia;
            //  Tongtien = hdb.tongtien;
        }
        public Hoadonban(string mahdb, string manvb, DateTime ngayban, int Soluong, double Gia)
        {
            Mahdb = mahdb;
            Manvb = manvb;
            Ngayban = ngayban;
            soluong = Soluong;
            gia = Gia;
        }
    }
}
