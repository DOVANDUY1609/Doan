using System;
using System.Collections.Generic;
using System.Text;
//using MyStore.Untility;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    public interface IDHoadonnhapDAL
    {
        List<Hoadonnhap> LayDSHoadonnhap();
        void Themhoadonnhap(Hoadonnhap gb);
        void Update(List<Hoadonnhap> list);
    }
}
