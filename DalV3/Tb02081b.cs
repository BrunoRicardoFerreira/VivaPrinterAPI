using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02081b
    {
        public DateTime? Tb02081Dtcad { get; set; }
        public string Tb02081Opcad { get; set; }
        public DateTime? Tb02081Dtalt { get; set; }
        public string Tb02081Opalt { get; set; }
        public string Tb02081Codigo { get; set; }
        public string Tb02081Produto { get; set; }
        public string Tb02081Status { get; set; }
        public decimal? Tb02081Qtprod { get; set; }
        public decimal? Tb02081Prunit { get; set; }
        public decimal? Tb02081Totvalor { get; set; }

        public virtual Tb02079 Tb02081CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02081ProdutoNavigation { get; set; }
        public virtual Tb01043 Tb02081StatusNavigation { get; set; }
    }
}