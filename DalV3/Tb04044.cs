using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04044
    {
        public int Tb04044Ret { get; set; }
        public string Tb04044Codigo { get; set; }
        public DateTime? Tb04044Dtvenc { get; set; }
        public DateTime? Tb04044Data { get; set; }
        public string Tb04044Nome { get; set; }
        public decimal? Tb04044Vlrtitulo { get; set; }
        public decimal? Tb04044Vlrjuros { get; set; }
        public decimal? Tb04044Vlrpago { get; set; }
        public int? Tb04044Lote { get; set; }
        public string Tb04044Status { get; set; }
        public DateTime? Tb04044Dtbaixa { get; set; }

        public virtual Tb04043 Tb04044RetNavigation { get; set; }
    }
}