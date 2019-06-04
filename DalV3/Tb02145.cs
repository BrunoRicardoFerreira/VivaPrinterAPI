using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02145
    {
        public DateTime? Tb02145Dtcad { get; set; }
        public string Tb02145Opcad { get; set; }
        public DateTime? Tb02145Dtalt { get; set; }
        public string Tb02145Opalt { get; set; }
        public string Tb02145Codigo { get; set; }
        public decimal? Tb02145Custo { get; set; }
        public decimal? Tb02145Perdesc { get; set; }
        public string Tb02145Produto { get; set; }
        public decimal? Tb02145Prunit { get; set; }
        public decimal? Tb02145Qtprod { get; set; }
        public decimal? Tb02145Qtprodb { get; set; }
        public string Tb02145Situacao { get; set; }
        public decimal? Tb02145Totvalor { get; set; }
        public decimal? Tb02145Totvalorb { get; set; }
        public decimal? Tb02145Vlrdesc { get; set; }
        public decimal? Tb02145Vlrdescb { get; set; }
        public decimal? Tb02145Icms { get; set; }
        public decimal? Tb02145Vlricms { get; set; }
        public decimal? Tb02145Vlricmsb { get; set; }
        public string Tb02145Natureza { get; set; }
        public decimal? Tb02145Percipi { get; set; }
        public decimal? Tb02145Vlripi { get; set; }
        public decimal? Tb02145Vlripib { get; set; }
        public decimal? Tb02145Percst { get; set; }
        public decimal? Tb02145Vlrst { get; set; }
        public decimal? Tb02145Vlrstb { get; set; }
        public decimal? Tb02145Basered { get; set; }
        public decimal? Tb02145Baseicms { get; set; }
        public decimal? Tb02145Baseicmsb { get; set; }
        public decimal? Tb02145Basest { get; set; }
        public decimal? Tb02145Basestb { get; set; }

        public virtual Tb02144 Tb02145CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02145ProdutoNavigation { get; set; }
    }
}