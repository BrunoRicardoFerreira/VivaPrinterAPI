using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02128
    {
        public DateTime? Tb02128Dtcad { get; set; }
        public string Tb02128Opcad { get; set; }
        public DateTime? Tb02128Dtalt { get; set; }
        public string Tb02128Opalt { get; set; }
        public string Tb02128Mes { get; set; }
        public string Tb02128Contrato { get; set; }
        public string Tb02128Produto { get; set; }
        public string Tb02128Numserie { get; set; }
        public string Tb02128Cobertura { get; set; }
        public decimal? Tb02128Vlrtotal { get; set; }

        public virtual Tb01049 Tb02128CoberturaNavigation { get; set; }
        public virtual Tb02111 Tb02128ContratoNavigation { get; set; }
        public virtual Tb02112 Tb02128Navigation { get; set; }
    }
}