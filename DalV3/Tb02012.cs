using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02012
    {
        public DateTime? Tb02012Dtcad { get; set; }
        public string Tb02012Opcad { get; set; }
        public DateTime? Tb02012Dtalt { get; set; }
        public string Tb02012Opalt { get; set; }
        public string Tb02012Codigo { get; set; }
        public decimal? Tb02012Custo { get; set; }
        public decimal? Tb02012Perdesc { get; set; }
        public string Tb02012Produto { get; set; }
        public decimal? Tb02012Prunit { get; set; }
        public decimal? Tb02012Qtprod { get; set; }
        public decimal? Tb02012Qtprodb { get; set; }
        public string Tb02012Situacao { get; set; }
        public decimal? Tb02012Totvalor { get; set; }
        public decimal? Tb02012Totvalorb { get; set; }
        public decimal? Tb02012Vlrdesc { get; set; }
        public decimal? Tb02012Vlrdescb { get; set; }
        public decimal? Tb02012Icms { get; set; }
        public decimal? Tb02012Vlricms { get; set; }
        public decimal? Tb02012Vlricmsb { get; set; }
        public string Tb02012Natureza { get; set; }
        public decimal? Tb02012Percipi { get; set; }
        public decimal? Tb02012Vlripi { get; set; }
        public decimal? Tb02012Vlripib { get; set; }
        public decimal? Tb02012Percst { get; set; }
        public decimal? Tb02012Vlrst { get; set; }
        public decimal? Tb02012Vlrstb { get; set; }
        public decimal? Tb02012Basered { get; set; }
        public decimal? Tb02012Baseicms { get; set; }
        public decimal? Tb02012Baseicmsb { get; set; }
        public decimal? Tb02012Basest { get; set; }
        public decimal? Tb02012Basestb { get; set; }
        public decimal? Tb02012Vlrfrete { get; set; }
        public decimal? Tb02012Vlrfreteb { get; set; }
        public decimal? Tb02012Vlroutdesp { get; set; }
        public decimal? Tb02012Vlroutdespb { get; set; }

        public virtual Tb02011 Tb02012CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02012ProdutoNavigation { get; set; }
    }
}