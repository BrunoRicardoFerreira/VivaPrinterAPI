using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02006
    {
        public DateTime? Tb02006Dtcad { get; set; }
        public string Tb02006Opcad { get; set; }
        public DateTime? Tb02006Dtalt { get; set; }
        public string Tb02006Opalt { get; set; }
        public string Tb02006Codigo { get; set; }
        public decimal? Tb02006Custo { get; set; }
        public decimal? Tb02006Perdesc { get; set; }
        public string Tb02006Produto { get; set; }
        public decimal? Tb02006Prunit { get; set; }
        public decimal? Tb02006Qtprod { get; set; }
        public decimal? Tb02006Qtprodb { get; set; }
        public string Tb02006Situacao { get; set; }
        public decimal? Tb02006Totvalor { get; set; }
        public decimal? Tb02006Totvalorb { get; set; }
        public decimal? Tb02006Vlrdesc { get; set; }
        public decimal? Tb02006Vlrdescb { get; set; }
        public decimal? Tb02006Icms { get; set; }
        public decimal? Tb02006Vlricms { get; set; }
        public decimal? Tb02006Vlricmsb { get; set; }
        public string Tb02006Natureza { get; set; }
        public decimal? Tb02006Percipi { get; set; }
        public decimal? Tb02006Vlripi { get; set; }
        public decimal? Tb02006Vlripib { get; set; }
        public decimal? Tb02006Percst { get; set; }
        public decimal? Tb02006Vlrst { get; set; }
        public decimal? Tb02006Vlrstb { get; set; }
        public decimal? Tb02006Basered { get; set; }
        public decimal? Tb02006Baseicms { get; set; }
        public decimal? Tb02006Baseicmsb { get; set; }
        public decimal? Tb02006Basest { get; set; }
        public decimal? Tb02006Basestb { get; set; }

        public virtual Tb02005 Tb02006CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02006ProdutoNavigation { get; set; }
    }
}