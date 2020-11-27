using System;
using System.Collections.Generic;
using MyStore.DataAcess;
using MyStore.Entities;
namespace MyStore.Business
{
    //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IDLoaihangBLL
    public class MathangBLL : IDMathangBLL
    {
        private IDMathangDAL lhhh = new MathangDAL();

        //Thực thi các yêu cầu
        public List<Mathang> LayDSMathang()
        {
            return lhhh.LayDSMathang();
        }
        public void ThemMathang(Mathang hh)
        {
            if (!string.IsNullOrEmpty(hh.tenhang))
            {
                lhhh.Themmathang(hh);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void XoaMathang(Mathang xmh)
        {
            int i;
            List<Mathang> list = lhhh.LayDSMathang();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang == xmh.mahang) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhhh.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void SuaMathang(Mathang hh)
        {
            int i;
            List<Mathang> list = lhhh.LayDSMathang();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang == hh.mahang) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hh);
                lhhh.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<Mathang> Timmathang(Mathang hh)
        {
            List<Mathang> list = lhhh.LayDSMathang();
            List<Mathang> kq = new List<Mathang>();
            //Voi gai tri ngam dinh ban dau
            if (hh.tenhang == null && hh.maloai == 0 && hh.soluongnhapve == 0 && hh.soluonghienco == 0 && hh.mahang == 0)
            {
                kq = list;
            }
            //Tim theo tenhang
            if (hh.tenhang != null )
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].tenhang.IndexOf(hh.tenhang) >= 0)
                    {
                        kq.Add(new Mathang(list[i]));
                    }
            }
            // Tim theo ma hNG
            if (hh.mahang != 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].mahang>=0)
                    {
                        kq.Add(new Mathang(list[i]));
                    }
            }
            //Tim theo ma
            if ( hh.maloai != 0 )
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].maloai >=0)
                    {
                        kq.Add(new Mathang(list[i]));
                    }
            }
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
    }
}
