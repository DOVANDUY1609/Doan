using System;
using System.Collections.Generic;
using System.Text;
//using MyStore.Untility;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    public interface IDMathangDAL
    {
        List<Mathang> LayDSMathang();
        void Themmathang(Mathang mh);
        void Update(List<Mathang> list);
    }
}
