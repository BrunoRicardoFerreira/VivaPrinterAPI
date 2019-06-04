using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02060
    {
        public DateTime? Tb02060Dtcad { get; set; }
        public string Tb02060Opcad { get; set; }
        public DateTime? Tb02060Dtalt { get; set; }
        public string Tb02060Opalt { get; set; }
        public string Tb02060Codigo { get; set; }
        public decimal? Tb02060Custo { get; set; }
        public decimal? Tb02060Perdesc { get; set; }
        public string Tb02060Produto { get; set; }
        public decimal? Tb02060Prunit { get; set; }
        public decimal? Tb02060Qtprod { get; set; }
        public decimal? Tb02060Qtprodb { get; set; }
        public string Tb02060Situacao { get; set; }
        public decimal? Tb02060Totvalor { get; set; }
        public decimal? Tb02060Totvalorb { get; set; }
        public decimal? Tb02060Percipi { get; set; }
        public decimal? Tb02060Vlripi { get; set; }
        public decimal? Tb02060Vlripib { get; set; }
        public string Tb02060Codpre { get; set; }
        public decimal? Tb02060Percst { get; set; }
        public decimal? Tb02060Vlrst { get; set; }
        public decimal? Tb02060Vlrstb { get; set; }
        public int? Tb02060Registro { get; set; }
        public string Tb02060Bxped { get; set; }
        public decimal? Tb02060Vlrdesc { get; set; }
        public decimal? Tb02060Icms { get; set; }
        public decimal? Tb02060Vlricms { get; set; }
        public string Tb02060Natureza { get; set; }
        public decimal? Tb02060Vlrdescb { get; set; }
        public decimal? Tb02060Vlricmsb { get; set; }
        public decimal? Tb02060Vlrfrete { get; set; }
        public decimal? Tb02060Vlrfreteb { get; set; }
        public decimal? Tb02060Vlroutdesp { get; set; }
        public decimal? Tb02060Vlroutdespb { get; set; }
        public decimal? Tb02060Basered { get; set; }
        public decimal? Tb02060Icmsst { get; set; }
        public string Tb02060Somast { get; set; }
        public decimal? Tb02060Baseicms { get; set; }
        public decimal? Tb02060Baseicmsb { get; set; }
        public decimal? Tb02060Basest { get; set; }
        public decimal? Tb02060Basestb { get; set; }
        public string Tb02060Cst { get; set; }

        public virtual Tb02059 Tb02060CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02060ProdutoNavigation { get; set; }
    }
}