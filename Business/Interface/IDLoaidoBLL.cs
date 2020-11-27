using System;
using System.Collections.Generic;
using System.Text;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface IDLoaidoBLL
    {
        List<Loaido> LayDSLoaido();
        void ThemLoaido(Loaido lh);

        void XoaLoaido(Loaido malh);
        void SuaLoaido(Loaido lh);
        List<Loaido> Timloaido(Loaido lh);
        // Loaido LayLoaido(int malh);
    }
}


