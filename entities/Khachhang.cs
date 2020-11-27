using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Entities
{
    public class Khachhang
    {
        private string Makh;
        private string TenKH;
        private int SDT;
        private string Diachi;
        public string makh
        {
            get
            {
                return Makh;
            }
            set
            {
                if (value!="")
                    Makh = value;
            }
        }

        public string tenkhachhang
        {
            get
            {
                return TenKH;
            }
            set
            {
                if (value != "")
                    TenKH = value;
            }
        }

        public int sdt
        {
            get
            {
                return SDT;
            }
            set
            {
                if (value > 0)
                    SDT = value;
            }
        }
        public string diachi
        {
            get
            {
                return Diachi;
            }
            set
            {
                if (value != "")
                    Diachi = value;
            }
        }
        public Khachhang()
        {
        }
        public Khachhang(Khachhang kh)
        {
            Makh =string.Copy( kh.makh);
            TenKH =string.Copy( kh.tenkhachhang);
            SDT = kh.sdt;
            Diachi =string.Copy( kh.diachi);
        }
        public Khachhang(string makh, string tenkh, int sdt, string diachi)
        {
            Makh = makh;
            TenKH = tenkh;
            SDT = sdt;
            Diachi = diachi;
        }
    }
}
