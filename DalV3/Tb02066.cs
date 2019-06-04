using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02066
    {
        public int Tb02066Cotacao { get; set; }
        public string Tb02066Forn { get; set; }
        public string Tb02066Produto { get; set; }
        public decimal? Tb02066Qtprod { get; set; }
        public decimal? Tb02066Prunit { get; set; }
        public int? Tb02066Dias { get; set; }
        public string Tb02066Selec { get; set; }
        public int? Tb02066MediaDiasPagto { get; set; }

        public virtual Tb02063 Tb02066CotacaoNavigation { get; set; }
        public virtual Tb01001 Tb02066FornNavigation { get; set; }
        public virtual Tb01010 Tb02066ProdutoNavigation { get; set; }
    }
}