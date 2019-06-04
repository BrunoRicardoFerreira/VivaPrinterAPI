using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02014
    {
        public DateTime? Tb02014Dtcad { get; set; }
        public string Tb02014Opcad { get; set; }
        public DateTime? Tb02014Dtalt { get; set; }
        public string Tb02014Opalt { get; set; }
        public string Tb02014Codigo { get; set; }
        public decimal? Tb02014Custo { get; set; }
        public decimal? Tb02014Perdesc { get; set; }
        public string Tb02014Produto { get; set; }
        public decimal? Tb02014Prunit { get; set; }
        public decimal? Tb02014Qtprod { get; set; }
        public decimal? Tb02014Qtprodb { get; set; }
        public string Tb02014Situacao { get; set; }
        public decimal? Tb02014Totvalor { get; set; }
        public decimal? Tb02014Totvalorb { get; set; }
        public decimal? Tb02014Vlrdesc { get; set; }
        public decimal? Tb02014Vlrdescb { get; set; }
        public decimal? Tb02014Icms { get; set; }
        public decimal? Tb02014Vlricms { get; set; }
        public decimal? Tb02014Vlricmsb { get; set; }
        public string Tb02014Natureza { get; set; }
        public decimal? Tb02014Percipi { get; set; }
        public decimal? Tb02014Vlripi { get; set; }
        public decimal? Tb02014Vlripib { get; set; }
        public decimal? Tb02014Percst { get; set; }
        public decimal? Tb02014Vlrst { get; set; }
        public decimal? Tb02014Vlrstb { get; set; }
        public decimal? Tb02014Basered { get; set; }
        public decimal? Tb02014Baseicms { get; set; }
        public decimal? Tb02014Baseicmsb { get; set; }
        public decimal? Tb02014Basest { get; set; }
        public decimal? Tb02014Basestb { get; set; }

        public virtual Tb02013 Tb02014CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02014ProdutoNavigation { get; set; }
    }
}