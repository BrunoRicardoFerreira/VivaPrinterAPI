using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02068
    {
        public int Tb02068Cotacao { get; set; }
        public string Tb02068Forn { get; set; }
        public string Tb02068Produto { get; set; }
        public decimal? Tb02068Quant { get; set; }
        public decimal? Tb02068Prunit { get; set; }
        public DateTime? Tb02068Dtprev { get; set; }
        public string Tb02068Opcom { get; set; }

        public virtual Tb02063 Tb02068CotacaoNavigation { get; set; }
        public virtual Tb01001 Tb02068FornNavigation { get; set; }
        public virtual Tb01010 Tb02068ProdutoNavigation { get; set; }
    }
}