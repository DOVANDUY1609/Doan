using System;
using System.Collections.Generic;
using MyStore.DataAcess;
using MyStore.Entities;
//using System.Security.RightsManagement;

namespace MyStore.Business
{
    //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IDLoaihangBLL
    public class NhanvienBLL : IDNhanvienBLL
    {
        private IDNhanvienDAL lhnv = new NhanvienDAL();
        //Thực thi các yêu cầu
        public List<Nhan_vien> LayDSnhanvien()
        {
            return lhnv.LayDSNhanvien();
        }
        public void Themnhanvien(Nhan_vien nv)
        {
            if (nv.tennv != "" && nv.gioitinh != "")
            {
                lhnv.Themnhanvien(nv);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void Xoanhanvien(Nhan_vien xnv)
        {
            int i;
            List<Nhan_vien> list = lhnv.LayDSNhanvien();
            for (i = 0; i < list.Count; ++i)
                if (list[i].manv == xnv.manv) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhnv.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void Suanhanvien(Nhan_vien nv)
        {
            int i;
            List<Nhan_vien> list = lhnv.LayDSNhanvien();
            for (i = 0; i < list.Count; ++i)
                if (list[i].manv == nv.manv) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(nv);
                lhnv.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<Nhan_vien> Timnhanvien(Nhan_vien nv)
        {
            List<Nhan_vien> list = lhnv.LayDSNhanvien();
            List<Nhan_vien> kq = new List<Nhan_vien>();
            //Voi gai tri ngam dinh ban dau
            if (nv.tennv == null && nv.ngaysinh == null && nv.gioitinh == null && nv.manv == null)
            {
                kq = list;
            }
            //Tim theo ho ten
            if (nv.manv != null)
            {

                for (int i = 0; i < list.Count; ++i)
                    if (list[i].manv.IndexOf(nv.manv) >= 0)
                    {
                        kq.Add(new Nhan_vien(list[i]));
                    }
            }

            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
    }
}
