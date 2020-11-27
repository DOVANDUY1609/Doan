using System;
using System.Collections.Generic;
using MyStore.DataAcess;
using MyStore.Entities;
namespace MyStore.Business
{
    //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IDLoaihangBLL
    public class LoaidoBLL : IDLoaidoBLL
    {
        private IDLoaidoDAL lhBLL = new LoaidoDAL();
        //Thực thi các yêu cầu
        public List<Loaido> LayDSLoaido()
        {
            return lhBLL.LayDSLoaido();

        }
        public void ThemLoaido(Loaido lh)
        {
            if (lh.tenloai != "" && lh.dacdiem != "")
            {
                lhBLL.Themdo(lh);
            }
            else
                throw new Exception("Du lieu sai");
        }

        public void XoaLoaido(Loaido malh)
        {
            int i;
            List<Loaido> list = lhBLL.LayDSLoaido();
            for (i = 0; i < list.Count; ++i)
                if (list[i].maloai == malh.maloai) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhBLL.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void SuaLoaido(Loaido lh)
        {
            int i;
            List<Loaido> list = lhBLL.LayDSLoaido();
            for (i = 0; i < list.Count; ++i)
                if (list[i].maloai == lh.maloai) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(lh);
                lhBLL.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<Loaido> Timloaido(Loaido lh)
        {
            List<Loaido> list = lhBLL.LayDSLoaido();
            List<Loaido> kq = new List<Loaido>();
            //Voi gai tri ngam dinh ban dau
            if (lh.tenloai == null && lh.dacdiem == null && lh.maloai == 0)
            {
                kq = list;
            }
            //Tim theo ho ten
            if (lh.tenloai != null )
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].tenloai.IndexOf(lh.tenloai) >= 0)
                    {
                        kq.Add(new Loaido(list[i]));
                    }
            }
            // Tim theo đaciem
            else if (lh.dacdiem != null )
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].dacdiem.IndexOf(lh.dacdiem) >= 0)
                    {
                        kq.Add(new Loaido(list[i]));
                    }
            }
            //Tim theo ma
            else if (lh.maloai != 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].maloai == lh.maloai)
                    {
                        kq.Add(new Loaido(list[i]));
                    }
            }

            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
    }
}

