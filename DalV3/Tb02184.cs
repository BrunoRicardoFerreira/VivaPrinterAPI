using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02184
    {
        public DateTime? Tb02184Dtcad { get; set; }
        public string Tb02184Opcad { get; set; }
        public DateTime? Tb02184Dtalt { get; set; }
        public string Tb02184Opalt { get; set; }
        public string Tb02184Codigo { get; set; }
        public string Tb02184Contrato { get; set; }
        public string Tb02184Codcusto { get; set; }
        public decimal? Tb02184Qtde { get; set; }
        public decimal? Tb02184Prunit { get; set; }
        public decimal? Tb02184Totvalor { get; set; }
        public string Tb02184Obs { get; set; }

        public virtual Tb01090 Tb02184CodcustoNavigation { get; set; }
        public virtual Tb02111 Tb02184ContratoNavigation { get; set; }
    }
}