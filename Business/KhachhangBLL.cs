using System;
using System.Collections.Generic;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IDLoaihangBLL
    public class KhachhangBLL : IDKhachhangBLL
    {
        private IDKhachhangDAL lhDA = new KhachhangDAL();
        //Thực thi các yêu cầu
        public List<Khachhang> LayDSKhachhang()
        {
            return lhDA.LayDSKhachhang();
        }
        public void ThemKhachHang(Khachhang kh)
        {
            if (kh.tenkhachhang != "" && kh.diachi != "")
            {
                lhDA.Themkhachhang(kh);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void XoaKhachhang(Khachhang malh)
        {
            int i;
            List<Khachhang> list = lhDA.LayDSKhachhang();
            for (i = 0; i < list.Count; ++i)
                if (list[i].makh == malh.makh) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void SuaKhachhang(Khachhang kh)
        {
            int i;
            List<Khachhang> list = lhDA.LayDSKhachhang();
            for (i = 0; i < list.Count; ++i)
                if (list[i].makh == kh.makh) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(kh);
                lhDA.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<Khachhang> Timkhachhang(Khachhang kh)
        {
            List<Khachhang> list = lhDA.LayDSKhachhang();
            List<Khachhang> kq = new List<Khachhang>();
            //Voi gai tri ngam dinh ban dau
            if (kh.makh==null&&kh.tenkhachhang == null && kh.diachi == null && kh.sdt == 0)
            {
                kq = list;
            }
            //Tim theo ho ten
            if (kh.tenkhachhang != null )
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].tenkhachhang.IndexOf(kh.tenkhachhang) >= 0)
                    {
                        kq.Add(new Khachhang(list[i]));
                    }
            }
            //Tim theo diachi
            else if ( kh.diachi != null )
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].diachi == kh.diachi)
                    {
                        kq.Add(new Khachhang(list[i]));
                    }
            }
            else if ( kh.sdt > 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].makh == kh.makh)
                    {
                        kq.Add(new Khachhang(list[i]));
                    }
            }
          
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
    }
}
