using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02051
    {
        public DateTime? Tb02051Dtcad { get; set; }
        public string Tb02051Opcad { get; set; }
        public DateTime? Tb02051Dtalt { get; set; }
        public string Tb02051Opalt { get; set; }
        public string Tb02051Codigo { get; set; }
        public decimal? Tb02051Custo { get; set; }
        public decimal? Tb02051Perdesc { get; set; }
        public string Tb02051Produto { get; set; }
        public decimal? Tb02051Prunit { get; set; }
        public decimal? Tb02051Qtprod { get; set; }
        public decimal? Tb02051Qtprodb { get; set; }
        public string Tb02051Situacao { get; set; }
        public decimal? Tb02051Totvalor { get; set; }
        public decimal? Tb02051Totvalorb { get; set; }
        public decimal? Tb02051Vlrdesc { get; set; }
        public decimal? Tb02051Vlrdescb { get; set; }
        public decimal? Tb02051Icms { get; set; }
        public decimal? Tb02051Vlricms { get; set; }
        public decimal? Tb02051Vlricmsb { get; set; }
        public string Tb02051Natureza { get; set; }
        public decimal? Tb02051Percipi { get; set; }
        public decimal? Tb02051Vlripi { get; set; }
        public decimal? Tb02051Vlripib { get; set; }
        public decimal? Tb02051Percst { get; set; }
        public decimal? Tb02051Vlrst { get; set; }
        public decimal? Tb02051Vlrstb { get; set; }
        public decimal? Tb02051Basered { get; set; }
        public decimal? Tb02051Baseicms { get; set; }
        public decimal? Tb02051Baseicmsb { get; set; }
        public decimal? Tb02051Basest { get; set; }
        public decimal? Tb02051Basestb { get; set; }

        public virtual Tb02050 Tb02051CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02051ProdutoNavigation { get; set; }
    }
}