using System;
using System.Collections.Generic;
using System.Text;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface IDMathangBLL
    {
        List<Mathang> LayDSMathang();
        void ThemMathang(Mathang hh);

        void XoaMathang(Mathang xmh);
        void SuaMathang(Mathang hh);
        List<Mathang> Timmathang(Mathang hh);
        // Mathang LayMathang(int mahh);

    }
}


