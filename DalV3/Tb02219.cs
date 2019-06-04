using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02219
    {
        public DateTime? Tb02219Dtcad { get; set; }
        public string Tb02219Opcad { get; set; }
        public DateTime? Tb02219Dtalt { get; set; }
        public string Tb02219Opalt { get; set; }
        public string Tb02219Codigo { get; set; }
        public string Tb02219Produto { get; set; }
        public int? Tb02219Qtprod { get; set; }
        public decimal? Tb02219Custo { get; set; }

        public virtual Tb02122 Tb02219CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02219ProdutoNavigation { get; set; }
    }
}