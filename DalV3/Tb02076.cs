using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02076
    {
        public DateTime? Tb02076Dtcad { get; set; }
        public string Tb02076Opcad { get; set; }
        public DateTime? Tb02076Dtalt { get; set; }
        public string Tb02076Opalt { get; set; }
        public string Tb02076Codigo { get; set; }
        public decimal? Tb02076Custo { get; set; }
        public decimal? Tb02076Perdesc { get; set; }
        public string Tb02076Produto { get; set; }
        public decimal? Tb02076Prunit { get; set; }
        public decimal? Tb02076Qtprod { get; set; }
        public decimal? Tb02076Qtprodb { get; set; }
        public string Tb02076Situacao { get; set; }
        public decimal? Tb02076Totvalor { get; set; }
        public decimal? Tb02076Totvalorb { get; set; }
        public decimal? Tb02076Vlrdesc { get; set; }
        public decimal? Tb02076Vlrdescb { get; set; }
        public decimal? Tb02076Icms { get; set; }
        public decimal? Tb02076Vlricms { get; set; }
        public decimal? Tb02076Vlricmsb { get; set; }
        public string Tb02076Natureza { get; set; }
        public decimal? Tb02076Percipi { get; set; }
        public decimal? Tb02076Vlripi { get; set; }
        public decimal? Tb02076Vlripib { get; set; }
        public decimal? Tb02076Percst { get; set; }
        public decimal? Tb02076Vlrst { get; set; }
        public decimal? Tb02076Vlrstb { get; set; }
        public decimal? Tb02076Basered { get; set; }
        public decimal? Tb02076Baseicms { get; set; }
        public decimal? Tb02076Baseicmsb { get; set; }
        public decimal? Tb02076Basest { get; set; }
        public decimal? Tb02076Basestb { get; set; }

        public virtual Tb02075 Tb02076CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02076ProdutoNavigation { get; set; }
    }
}