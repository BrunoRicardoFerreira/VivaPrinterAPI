using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02016
    {
        public DateTime? Tb02016Dtcad { get; set; }
        public string Tb02016Opcad { get; set; }
        public DateTime? Tb02016Dtalt { get; set; }
        public string Tb02016Opalt { get; set; }
        public string Tb02016Codigo { get; set; }
        public decimal? Tb02016Custo { get; set; }
        public decimal? Tb02016Perdesc { get; set; }
        public string Tb02016Produto { get; set; }
        public decimal? Tb02016Prunit { get; set; }
        public decimal? Tb02016Qtprod { get; set; }
        public decimal? Tb02016Qtprodb { get; set; }
        public string Tb02016Situacao { get; set; }
        public decimal? Tb02016Totvalor { get; set; }
        public decimal? Tb02016Totvalorb { get; set; }
        public decimal? Tb02016Vlrdesc { get; set; }
        public decimal? Tb02016Vlrdescb { get; set; }
        public decimal? Tb02016Icms { get; set; }
        public decimal? Tb02016Vlricms { get; set; }
        public decimal? Tb02016Vlricmsb { get; set; }
        public string Tb02016Natureza { get; set; }
        public decimal? Tb02016Percipi { get; set; }
        public decimal? Tb02016Vlripi { get; set; }
        public decimal? Tb02016Vlripib { get; set; }
        public decimal? Tb02016Percst { get; set; }
        public decimal? Tb02016Vlrst { get; set; }
        public decimal? Tb02016Vlrstb { get; set; }
        public decimal? Tb02016Basered { get; set; }
        public decimal? Tb02016Baseicms { get; set; }
        public decimal? Tb02016Baseicmsb { get; set; }
        public decimal? Tb02016Basest { get; set; }
        public decimal? Tb02016Basestb { get; set; }

        public virtual Tb02015 Tb02016CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02016ProdutoNavigation { get; set; }
    }
}