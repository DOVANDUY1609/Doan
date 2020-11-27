using System;
using System.Collections.Generic;
using System.Text;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface IDHoadonnhapBLL
    {
        List<Hoadonnhap> LayDSHoadonnhap();

        void Xoahoadonnhap(Hoadonnhap xhdn);
        List<Hoadonnhap> Timhoadonnhap(Hoadonnhap hdn);

        void Suahoadonnhap(Hoadonnhap hdn);
        //   Hoadonnhap Layhoadonnhap(int xhdn);
        void Themhoadonnhap(Hoadonnhap hdn);
    }
}

