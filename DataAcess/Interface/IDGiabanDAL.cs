using System;
using System.Collections.Generic;
using System.Text;
//using MyStore.Untility;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    public interface IDGiabanDAL
    {
        List<Gia_ban> LayDSGiaban();
        void ThemGiaban(Gia_ban gb);
        void Update(List<Gia_ban> list);
    }
}
