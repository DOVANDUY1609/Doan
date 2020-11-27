using System;
using System.Collections.Generic;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IDLoaihangBLL
    public class HoadonnhapBLL : IDHoadonnhapBLL
    {
        private IDHoadonnhapDAL lhdn = new HoadonnhapDAL();
        //Thực thi các yêu cầu
        public List<Hoadonnhap> LayDSHoadonnhap()
        {
            return lhdn.LayDSHoadonnhap();
        }
        public void Themhoadonnhap(Hoadonnhap hdn)
        {
            if (hdn.mann!="" )
            {
                lhdn.Themhoadonnhap(hdn);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void Xoahoadonnhap(Hoadonnhap xhdn)
        {
            int i;
            List<Hoadonnhap> list = lhdn.LayDSHoadonnhap();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahdn == xhdn.mahdn) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhdn.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void Suahoadonnhap(Hoadonnhap hdn)
        {
            int i;
            List<Hoadonnhap> list = lhdn.LayDSHoadonnhap();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahdn == hdn.mahdn) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hdn);
                lhdn.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<Hoadonnhap> Timhoadonnhap(Hoadonnhap hdn)
        {
            List<Hoadonnhap> list = lhdn.LayDSHoadonnhap();
            List<Hoadonnhap> kq = new List<Hoadonnhap>();
            //Voi gai tri ngam dinh ban dau
            if (hdn.mancc == 0 && hdn.mann == null && hdn.ngaynhan == null && hdn.ghichu == null)
            {
                kq = list;
            }
            //Tim theo mancc
            if (hdn.mancc > 0 )
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].mancc>= 0)
                    {
                        kq.Add(new Hoadonnhap(list[i]));
                    }
            }
            // Tim theo tong tien
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
    }
}
