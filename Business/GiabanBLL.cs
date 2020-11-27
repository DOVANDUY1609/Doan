using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IDLoaihangBLL
    public class GiabanBLL : IDGiabanBLL
    {

        private IDGiabanDAL lhgb = new GiabanDAL();
        //Thực thi các yêu cầu
        public List<Gia_ban> LayDSGiaban()
        {
            return lhgb.LayDSGiaban();
        }
        public void Themgiaban(Gia_ban tgb)
        {
            if (tgb.tenhang != "")
            {
                lhgb.ThemGiaban(tgb);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void Xoagiaban(Gia_ban xgb)
        {
            int i;
            List<Gia_ban> list = lhgb.LayDSGiaban();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang == xgb.mahang) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhgb.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void Suagiaban(Gia_ban gb)
        {
            int i;
            List<Gia_ban> list = lhgb.LayDSGiaban();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang == gb.mahang) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(gb);
                lhgb.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void Timkiem(Gia_ban gb)
        {
            int i;
            List<Gia_ban> list = lhgb.LayDSGiaban();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang == gb.mahang ) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(gb);
                lhgb.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void Hientimkiem(Gia_ban gb)
        {
            int i;
            List<Gia_ban> list = lhgb.LayDSGiaban();
            Console.WriteLine("mahang" + "\t" + "tenhang" + "\t" + "Giaban");
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahang == gb.mahang)
            Console.WriteLine(gb.mahang + "\t" + gb.tenhang + "\t\t" + gb.Giaban);

                else
                    throw new Exception("Khong ton tai hs nay");
        }
    }
}
