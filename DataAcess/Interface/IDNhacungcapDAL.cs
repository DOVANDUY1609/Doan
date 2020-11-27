using System;
using System.Collections.Generic;
using System.Text;
//using MyStore.Untility;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    public interface IDNhacungcapDAL
    {
        List<Nhà_cung_cấp> LayDSNhacungcap();
        void Them_nha_cung_cap(Nhà_cung_cấp gb);
        void Update(List<Nhà_cung_cấp> list);
    }
}
