using System;
using System.Collections.Generic;
using System.Text;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface IDKhachhangBLL
    {
        List<Khachhang> LayDSKhachhang();
        void XoaKhachhang(Khachhang xkh);
        List<Khachhang> Timkhachhang(Khachhang kh);
        void SuaKhachhang(Khachhang kh);
        //  Khachhang LayKhachhang(int makh);
        void ThemKhachHang(Khachhang kh);
    }
}


