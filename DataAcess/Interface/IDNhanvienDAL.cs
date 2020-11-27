using System;
using System.Collections.Generic;
using System.Text;
//using MyStore.Untility;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    public interface IDNhanvienDAL
    {
        List<Nhan_vien> LayDSNhanvien();
        void Themnhanvien(Nhan_vien gb);
        void Update(List<Nhan_vien> list);
    }
}
