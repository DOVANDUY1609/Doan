using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Entities
{
    public class Hoadonnhap
    {
        private string Mahdn;
        private int Mancc;
        private string Mann;
        private DateTime Ngaynhan;
        private string Ghichu;
        public string mahdn
        {
            get
            {
                return Mahdn;
            }
            set
            {
                if (value !="")
                    Mahdn = value;
            }
        }

        public int mancc
        {
            get
            {
                return Mancc;
            }
            set
            {
                if (value > 0)
                    Mancc = value;
            }
        }

        public string mann
        {
            get
            {
                return Mann;
            }
            set
            {
                if (value != "")
                    Mann = value;
            }
        }
        public DateTime ngaynhan
        {
            get
            {
                return Ngaynhan;
            }
            set
            {
                //if (Ngaynhan != "")
                    Ngaynhan = value;
            }
        }
        public string ghichu
        {
            get
            {
                return Ghichu;
            }
            set
            {
                if (Ghichu != "")
                    Ghichu = value;
            }
        }

        public Hoadonnhap()
        {
        }
        public Hoadonnhap(Hoadonnhap hdn)
        {
            Mahdn = string.Copy(hdn.mahdn);
            Mancc = hdn.mancc;
            Mann = string.Copy(hdn.mann);
            Ngaynhan = hdn.ngaynhan;
            Ghichu = string.Copy(hdn.ghichu);
        }
        public Hoadonnhap(string mahdn, int mancc, string mann, DateTime ngaynhan, string ghichu)
        {
            Mahdn = mahdn;
            Mancc = mancc;
            Mann = mann;
            Ngaynhan = ngaynhan;
            Ghichu = ghichu;
        }
    }
}
