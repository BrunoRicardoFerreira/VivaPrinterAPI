using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02049
    {
        public DateTime? Tb02049Dtcad { get; set; }
        public string Tb02049Opcad { get; set; }
        public DateTime? Tb02049Dtalt { get; set; }
        public string Tb02049Opalt { get; set; }
        public string Tb02049Codigo { get; set; }
        public decimal? Tb02049Custo { get; set; }
        public decimal? Tb02049Perdesc { get; set; }
        public string Tb02049Produto { get; set; }
        public decimal? Tb02049Prunit { get; set; }
        public decimal? Tb02049Qtprod { get; set; }
        public decimal? Tb02049Qtprodb { get; set; }
        public string Tb02049Situacao { get; set; }
        public decimal? Tb02049Totvalor { get; set; }
        public decimal? Tb02049Totvalorb { get; set; }
        public decimal? Tb02049Vlrdesc { get; set; }
        public decimal? Tb02049Vlrdescb { get; set; }
        public decimal? Tb02049Icms { get; set; }
        public decimal? Tb02049Vlricms { get; set; }
        public decimal? Tb02049Vlricmsb { get; set; }
        public string Tb02049Natureza { get; set; }
        public decimal? Tb02049Percipi { get; set; }
        public decimal? Tb02049Vlripi { get; set; }
        public decimal? Tb02049Vlripib { get; set; }
        public decimal? Tb02049Percst { get; set; }
        public decimal? Tb02049Vlrst { get; set; }
        public decimal? Tb02049Vlrstb { get; set; }
        public decimal? Tb02049Basered { get; set; }
        public decimal? Tb02049Baseicms { get; set; }
        public decimal? Tb02049Baseicmsb { get; set; }
        public decimal? Tb02049Basest { get; set; }
        public decimal? Tb02049Basestb { get; set; }

        public virtual Tb02048 Tb02049CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02049ProdutoNavigation { get; set; }
    }
}