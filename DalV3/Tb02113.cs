using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02113
    {
        public DateTime? Tb02113Dtcad { get; set; }
        public string Tb02113Opcad { get; set; }
        public DateTime? Tb02113Dtalt { get; set; }
        public string Tb02113Opalt { get; set; }
        public string Tb02113Codigo { get; set; }
        public string Tb02113Produto { get; set; }
        public string Tb02113Numserie { get; set; }
        public string Tb02113Cobertura { get; set; }
        public DateTime? Tb02113Validade { get; set; }
        public decimal? Tb02113Valor { get; set; }
        public decimal? Tb02113Valorb { get; set; }
        public decimal? Tb02113Comissao { get; set; }

        public virtual Tb01049 Tb02113CoberturaNavigation { get; set; }
        public virtual Tb02111 Tb02113CodigoNavigation { get; set; }
        public virtual Tb02112 Tb02113Navigation { get; set; }
        public virtual Tb01010 Tb02113ProdutoNavigation { get; set; }
    }
}