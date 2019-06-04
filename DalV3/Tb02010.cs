using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02010
    {
        public DateTime? Tb02010Dtcad { get; set; }
        public string Tb02010Opcad { get; set; }
        public DateTime? Tb02010Dtalt { get; set; }
        public string Tb02010Opalt { get; set; }
        public string Tb02010Codigo { get; set; }
        public decimal? Tb02010Custo { get; set; }
        public decimal? Tb02010Perdesc { get; set; }
        public string Tb02010Produto { get; set; }
        public decimal? Tb02010Prunit { get; set; }
        public decimal? Tb02010Qtprod { get; set; }
        public decimal? Tb02010Qtprodb { get; set; }
        public string Tb02010Situacao { get; set; }
        public decimal? Tb02010Totvalor { get; set; }
        public decimal? Tb02010Totvalorb { get; set; }
        public decimal? Tb02010Vlrdesc { get; set; }
        public decimal? Tb02010Vlrdescb { get; set; }
        public decimal? Tb02010Icms { get; set; }
        public decimal? Tb02010Vlricms { get; set; }
        public decimal? Tb02010Vlricmsb { get; set; }
        public string Tb02010Natureza { get; set; }
        public decimal? Tb02010Percipi { get; set; }
        public decimal? Tb02010Vlripi { get; set; }
        public decimal? Tb02010Vlripib { get; set; }
        public decimal? Tb02010Percst { get; set; }
        public decimal? Tb02010Vlrst { get; set; }
        public decimal? Tb02010Vlrstb { get; set; }
        public decimal? Tb02010Basered { get; set; }
        public decimal? Tb02010Baseicms { get; set; }
        public decimal? Tb02010Baseicmsb { get; set; }
        public decimal? Tb02010Basest { get; set; }
        public decimal? Tb02010Basestb { get; set; }

        public virtual Tb02009 Tb02010CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02010ProdutoNavigation { get; set; }
    }
}