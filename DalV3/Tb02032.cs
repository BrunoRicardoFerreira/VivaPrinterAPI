using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02032
    {
        public DateTime? Tb02032Dtcad { get; set; }
        public string Tb02032Opcad { get; set; }
        public DateTime? Tb02032Dtalt { get; set; }
        public string Tb02032Opalt { get; set; }
        public string Tb02032Codigo { get; set; }
        public string Tb02032Produto { get; set; }
        public decimal? Tb02032Qtprod { get; set; }
        public decimal? Tb02032Totvalor { get; set; }
        public decimal Tb02032Prunit { get; set; }
        public string Tb02032Unprod { get; set; }

        public virtual Tb02030 Tb02032CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02032ProdutoNavigation { get; set; }
    }
}