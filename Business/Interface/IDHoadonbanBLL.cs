using System;
using System.Collections.Generic;
using System.Text;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface IDHoadonbanBLL
    {
        List<Hoadonban> LayDSHoadonban();

        void Xoahoadonban(Hoadonban xhdb);
        List<Hoadonban> Timhoadonban(Hoadonban hdb);
        void Suahoadonban(Hoadonban hdb);
        // Hoadonban Layhoadonban(int xhdb);
        void Themhoadonban(Hoadonban hdb);
    }
}


