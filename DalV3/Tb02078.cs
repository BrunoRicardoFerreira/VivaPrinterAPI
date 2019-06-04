using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02078
    {
        public DateTime? Tb02078Dtcad { get; set; }
        public string Tb02078Opcad { get; set; }
        public DateTime? Tb02078Dtalt { get; set; }
        public string Tb02078Opalt { get; set; }
        public string Tb02078Codigo { get; set; }
        public decimal? Tb02078Custo { get; set; }
        public decimal? Tb02078Perdesc { get; set; }
        public string Tb02078Produto { get; set; }
        public decimal? Tb02078Prunit { get; set; }
        public decimal? Tb02078Qtprod { get; set; }
        public decimal? Tb02078Qtprodb { get; set; }
        public string Tb02078Situacao { get; set; }
        public decimal? Tb02078Totvalor { get; set; }
        public decimal? Tb02078Totvalorb { get; set; }
        public decimal? Tb02078Vlrdesc { get; set; }
        public decimal? Tb02078Vlrdescb { get; set; }
        public decimal? Tb02078Icms { get; set; }
        public decimal? Tb02078Vlricms { get; set; }
        public decimal? Tb02078Vlricmsb { get; set; }
        public string Tb02078Natureza { get; set; }
        public decimal? Tb02078Percipi { get; set; }
        public decimal? Tb02078Vlripi { get; set; }
        public decimal? Tb02078Vlripib { get; set; }
        public decimal? Tb02078Percst { get; set; }
        public decimal? Tb02078Vlrst { get; set; }
        public decimal? Tb02078Vlrstb { get; set; }
        public decimal? Tb02078Basered { get; set; }
        public decimal? Tb02078Baseicms { get; set; }
        public decimal? Tb02078Baseicmsb { get; set; }
        public decimal? Tb02078Basest { get; set; }
        public decimal? Tb02078Basestb { get; set; }

        public virtual Tb02077 Tb02078CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02078ProdutoNavigation { get; set; }
    }
}