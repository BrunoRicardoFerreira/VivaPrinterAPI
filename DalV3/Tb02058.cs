using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02058
    {
        public DateTime? Tb02058Dtcad { get; set; }
        public string Tb02058Opcad { get; set; }
        public DateTime? Tb02058Dtalt { get; set; }
        public string Tb02058Opalt { get; set; }
        public string Tb02058Codigo { get; set; }
        public decimal? Tb02058Custo { get; set; }
        public decimal? Tb02058Perdesc { get; set; }
        public string Tb02058Produto { get; set; }
        public decimal? Tb02058Prunit { get; set; }
        public decimal? Tb02058Qtprod { get; set; }
        public decimal? Tb02058Qtprodb { get; set; }
        public string Tb02058Situacao { get; set; }
        public decimal? Tb02058Totvalor { get; set; }
        public decimal? Tb02058Totvalorb { get; set; }
        public decimal? Tb02058Vlrdesc { get; set; }
        public decimal? Tb02058Vlrdescb { get; set; }
        public decimal? Tb02058Icms { get; set; }
        public decimal? Tb02058Vlricms { get; set; }
        public decimal? Tb02058Vlricmsb { get; set; }
        public string Tb02058Natureza { get; set; }
        public decimal? Tb02058Percipi { get; set; }
        public decimal? Tb02058Vlripi { get; set; }
        public decimal? Tb02058Vlripib { get; set; }
        public decimal? Tb02058Percst { get; set; }
        public decimal? Tb02058Vlrst { get; set; }
        public decimal? Tb02058Vlrstb { get; set; }
        public decimal? Tb02058Basered { get; set; }
        public decimal? Tb02058Baseicms { get; set; }
        public decimal? Tb02058Baseicmsb { get; set; }
        public decimal? Tb02058Basest { get; set; }
        public decimal? Tb02058Basestb { get; set; }

        public virtual Tb02015 Tb02058CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02058ProdutoNavigation { get; set; }
    }
}