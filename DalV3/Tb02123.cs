using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02123
    {
        public DateTime? Tb02123Dtcad { get; set; }
        public string Tb02123Opcad { get; set; }
        public DateTime? Tb02123Dtalt { get; set; }
        public string Tb02123Opalt { get; set; }
        public string Tb02123Codigo { get; set; }
        public string Tb02123Produto { get; set; }
        public int? Tb02123Qtprod { get; set; }
        public decimal? Tb02123Custo { get; set; }

        public virtual Tb02122 Tb02123CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02123ProdutoNavigation { get; set; }
    }
}