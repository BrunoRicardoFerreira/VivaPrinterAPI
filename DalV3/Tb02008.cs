using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02008
    {
        public DateTime? Tb02008Dtcad { get; set; }
        public string Tb02008Opcad { get; set; }
        public DateTime? Tb02008Dtalt { get; set; }
        public string Tb02008Opalt { get; set; }
        public string Tb02008Codigo { get; set; }
        public decimal? Tb02008Custo { get; set; }
        public decimal? Tb02008Perdesc { get; set; }
        public string Tb02008Produto { get; set; }
        public decimal? Tb02008Prunit { get; set; }
        public decimal? Tb02008Qtprod { get; set; }
        public decimal? Tb02008Qtprodb { get; set; }
        public string Tb02008Situacao { get; set; }
        public decimal? Tb02008Totvalor { get; set; }
        public decimal? Tb02008Totvalorb { get; set; }
        public decimal? Tb02008Vlrdesc { get; set; }
        public decimal? Tb02008Vlrdescb { get; set; }
        public decimal? Tb02008Icms { get; set; }
        public decimal? Tb02008Vlricms { get; set; }
        public decimal? Tb02008Vlricmsb { get; set; }
        public string Tb02008Natureza { get; set; }
        public decimal? Tb02008Percipi { get; set; }
        public decimal? Tb02008Vlripi { get; set; }
        public decimal? Tb02008Vlripib { get; set; }
        public decimal? Tb02008Percst { get; set; }
        public decimal? Tb02008Vlrst { get; set; }
        public decimal? Tb02008Vlrstb { get; set; }
        public decimal? Tb02008Basered { get; set; }
        public decimal? Tb02008Baseicms { get; set; }
        public decimal? Tb02008Baseicmsb { get; set; }
        public decimal? Tb02008Basest { get; set; }
        public decimal? Tb02008Basestb { get; set; }

        public virtual Tb02007 Tb02008CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02008ProdutoNavigation { get; set; }
    }
}