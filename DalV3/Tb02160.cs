using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02160
    {
        public DateTime? Tb02160Dtcad { get; set; }
        public string Tb02160Opcad { get; set; }
        public DateTime? Tb02160Dtalt { get; set; }
        public string Tb02160Opalt { get; set; }
        public string Tb02160Mes { get; set; }
        public string Tb02160Codcli { get; set; }
        public int Tb02160Dia { get; set; }
        public string Tb02160Tipo { get; set; }
        public decimal? Tb02160Qtde { get; set; }
        public decimal? Tb02160Prunit { get; set; }
        public decimal? Tb02160Totvalor { get; set; }
        public DateTime? Tb02160Dtvenc { get; set; }
        public string Tb02160Pedido { get; set; }
        public string Tb02160Nfse { get; set; }

        public virtual Tb02159 Tb02160Navigation { get; set; }
        public virtual Tb01080 Tb02160TipoNavigation { get; set; }
    }
}