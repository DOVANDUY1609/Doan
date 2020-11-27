using System;
using System.Collections.Generic;
using System.Text;
//using MyStore.Untility;
using MyStore.Entities;

namespace MyStore.DataAcess
{
    public interface IDLoaidoDAL
    {
        List<Loaido> LayDSLoaido();
        void Themdo(Loaido gb);
        void Update(List<Loaido> list);
    }
}
