using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStore.Entities
{
    public class Gia_ban
    {
        private int Mahang;
        private string Tenhang;
        private int giaban;
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
                return Tenhang;
            }
            set
            {
                if (value != "")
                    Tenhang = value;
            }
        }

        public int Giaban
        {
            get
            {
                return giaban;
            }
            set
            {
                if (value > 0)
                    giaban = value;
            }
        }
        public Gia_ban()
        {
        }
        public Gia_ban(Gia_ban gb)
        {
            Mahang = gb.mahang;
            Tenhang = string.Copy(gb.tenhang);
            giaban = gb.Giaban;

        }
        public Gia_ban(int mahang, string tenhang, int giaban)
        {
            Mahang = mahang;
            Tenhang = tenhang;
            Giaban = giaban;
        }
    }
}
