using System;
using System.Collections.Generic;
using System.Text;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface IDGiabanBLL
    {
        List<Gia_ban> LayDSGiaban();

        void Xoagiaban(Gia_ban xgb);
        void Suagiaban(Gia_ban gb);
        void  Timkiem(Gia_ban gb);
        void Themgiaban(Gia_ban gb);
        void Hientimkiem(Gia_ban gb);
    }
}