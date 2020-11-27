using System;
using System.Collections.Generic;
using System.Text;
using MyStore.DataAcess;
using MyStore.Entities;

namespace MyStore.Business
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface IDNhanvienBLL
    {
        List<Nhan_vien> LayDSnhanvien();
        void Xoanhanvien(Nhan_vien xnv);
        List<Nhan_vien> Timnhanvien(Nhan_vien nv);
        void Suanhanvien(Nhan_vien nv);
        void Themnhanvien(Nhan_vien nv);
    }
}


