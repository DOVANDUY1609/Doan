using System;
using System.Collections.Generic;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IDLoaihangBLL
    public class NhacungcapBLL : IDNhacungcapBLL
    {
        private IDNhacungcapDAL lhncc = new NhacungcapDAL();
        //Thực thi các yêu cầu
        public List<Nhà_cung_cấp> LayDSNhacungcap()
        {
            return lhncc.LayDSNhacungcap();
        }
        public void Themnhacungcap(Nhà_cung_cấp ncc)
        {
            if (ncc.tenncc != "" && ncc.diachi != "")
            {
                lhncc.Them_nha_cung_cap(ncc);
            }
            else
                throw new Exception("Du lieu sai");
        }

        public void XoaNhacungcap(Nhà_cung_cấp xncc)
        {
            int i;
            List<Nhà_cung_cấp> list = lhncc.LayDSNhacungcap();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mancc == xncc.mancc) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhncc.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void Suanhacungcap(Nhà_cung_cấp ncc)
        {
            int i;
            List<Nhà_cung_cấp> list = lhncc.LayDSNhacungcap();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mancc == ncc.mancc) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(ncc);
                lhncc.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<Nhà_cung_cấp> Timnhacungcap(Nhà_cung_cấp ncc)
        {
            List<Nhà_cung_cấp> list = lhncc.LayDSNhacungcap();
            List<Nhà_cung_cấp> kq = new List<Nhà_cung_cấp>();
            //Voi gai tri ngam dinh ban dau
            if (ncc.sdt == 0 && ncc.tenncc == null && ncc.diachi == null && ncc.mancc == 0)
            {
                kq = list;
            }
            //Tim theo ten ncc
            if ( ncc.tenncc != null)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].tenncc.IndexOf(ncc.tenncc) >= 0)
                    {
                        kq.Add(new Nhà_cung_cấp(list[i]));
                    }
            }
            else if (ncc.sdt != 0 )
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].sdt == ncc.sdt)
                    {
                        kq.Add(new Nhà_cung_cấp(list[i]));
                    }
            }

            //Tim theo diachi
            else if ( ncc.diachi != null )
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].diachi == ncc.diachi)
                    {
                        kq.Add(new Nhà_cung_cấp(list[i]));
                    }
            }
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }

    }
}
