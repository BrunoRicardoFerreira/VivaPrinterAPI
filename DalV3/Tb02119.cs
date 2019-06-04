using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02119
    {
        public DateTime? Tb02119Dtcad { get; set; }
        public string Tb02119Opcad { get; set; }
        public DateTime? Tb02119Dtalt { get; set; }
        public string Tb02119Opalt { get; set; }
        public string Tb02119Codigo { get; set; }
        public decimal? Tb02119Custo { get; set; }
        public decimal? Tb02119Perdesc { get; set; }
        public string Tb02119Produto { get; set; }
        public decimal? Tb02119Prunit { get; set; }
        public decimal? Tb02119Qtprod { get; set; }
        public decimal? Tb02119Qtprodb { get; set; }
        public string Tb02119Situacao { get; set; }
        public decimal? Tb02119Totvalor { get; set; }
        public decimal? Tb02119Totvalorb { get; set; }
        public decimal? Tb02119Vlrdesc { get; set; }
        public decimal? Tb02119Vlrdescb { get; set; }
        public decimal? Tb02119Icms { get; set; }
        public decimal? Tb02119Vlricms { get; set; }
        public decimal? Tb02119Vlricmsb { get; set; }
        public string Tb02119Natureza { get; set; }
        public decimal? Tb02119Percipi { get; set; }
        public decimal? Tb02119Vlripi { get; set; }
        public decimal? Tb02119Vlripib { get; set; }
        public decimal? Tb02119Percst { get; set; }
        public decimal? Tb02119Vlrst { get; set; }
        public decimal? Tb02119Vlrstb { get; set; }
        public decimal? Tb02119Basered { get; set; }
        public decimal? Tb02119Baseicms { get; set; }
        public decimal? Tb02119Baseicmsb { get; set; }
        public decimal? Tb02119Basest { get; set; }
        public decimal? Tb02119Basestb { get; set; }
        public string Tb02119Obs { get; set; }

        public virtual Tb01010 Tb02119ProdutoNavigation { get; set; }
    }
}