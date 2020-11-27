using System;
using System.Collections.Generic;
using System.Text;
//using MyStore.Untility;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    public interface IDKhachhangDAL
    {
        List<Khachhang> LayDSKhachhang();
        void Themkhachhang(Khachhang gb);
        void Update(List<Khachhang> list);
    }
}
