using System;
using System.Collections.Generic;
using System.Text;
//using MyStore.Untility;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    public interface IDHoadonbanDAL
    {
        List<Hoadonban> LayDSHoadonban();
        void Themhoadonban(Hoadonban gb);
        void Update(List<Hoadonban> list);
    }
}
