using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStore.Entities
{
    public class Nhà_cung_cấp
    {
        private int MaNCC;
        private string TenNCC;
        private int SDT;
        private string Diachi;
        public int mancc
        {
            get
            {
                return MaNCC;
            }
            set
            {
                if (value > 0)
                    MaNCC = value;
            }
        }

    
        public string tenncc
        {
            get
            {
                return TenNCC;
            }
            set
            {
                if (value!= "")
                    TenNCC = value;
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
        public Nhà_cung_cấp()
        {
        }
        public Nhà_cung_cấp(Nhà_cung_cấp ncc)
        {
            MaNCC =ncc.mancc;
            TenNCC = string.Copy(ncc.tenncc);
            SDT = ncc.sdt;
            Diachi = string.Copy(ncc.diachi);
        }
        public Nhà_cung_cấp(int ma, string tncc, int sd, string dc)
        {
            MaNCC = ma;
            TenNCC = tncc;
            sdt = sd;
            Diachi = dc;
        }
    }
}
