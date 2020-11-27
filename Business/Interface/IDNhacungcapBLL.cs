using System;
using System.Collections.Generic;
using System.Text;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface IDNhacungcapBLL
    {
        List<Nhà_cung_cấp> LayDSNhacungcap();

        void XoaNhacungcap(Nhà_cung_cấp xncc);
        List<Nhà_cung_cấp> Timnhacungcap(Nhà_cung_cấp ncc);
        // List<Hoadonnhap> Layhoadonnhap(Hoadonnhap hdn);
        void Suanhacungcap(Nhà_cung_cấp ncc);
        //  Nhà_cung_cấp Laynhacungcap(int xncc);
        void Themnhacungcap(Nhà_cung_cấp ncc);
    }
}
