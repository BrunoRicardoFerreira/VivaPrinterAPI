using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02101
    {
        public DateTime? Tb02101Dtcad { get; set; }
        public string Tb02101Opcad { get; set; }
        public DateTime? Tb02101Dtalt { get; set; }
        public string Tb02101Opalt { get; set; }
        public string Tb02101Codigo { get; set; }
        public decimal? Tb02101Custo { get; set; }
        public decimal? Tb02101Perdesc { get; set; }
        public string Tb02101Produto { get; set; }
        public decimal? Tb02101Prunit { get; set; }
        public decimal? Tb02101Qtprod { get; set; }
        public decimal? Tb02101Qtprodb { get; set; }
        public string Tb02101Situacao { get; set; }
        public decimal? Tb02101Totvalor { get; set; }
        public decimal? Tb02101Totvalorb { get; set; }
        public decimal? Tb02101Percipi { get; set; }
        public decimal? Tb02101Vlripi { get; set; }
        public decimal? Tb02101Vlripib { get; set; }
        public string Tb02101Codpre { get; set; }
        public decimal? Tb02101Percst { get; set; }
        public decimal? Tb02101Vlrst { get; set; }
        public decimal? Tb02101Vlrstb { get; set; }
        public int? Tb02101Registro { get; set; }
        public string Tb02101Bxped { get; set; }
        public decimal? Tb02101Vlrdesc { get; set; }
        public decimal? Tb02101Icms { get; set; }
        public decimal? Tb02101Vlricms { get; set; }
        public string Tb02101Natureza { get; set; }
        public decimal? Tb02101Vlrdescb { get; set; }
        public decimal? Tb02101Vlricmsb { get; set; }
        public decimal? Tb02101Vlrfrete { get; set; }
        public decimal? Tb02101Vlroutdesp { get; set; }
        public decimal? Tb02101Vlrfreteb { get; set; }
        public decimal? Tb02101Vlroutdespb { get; set; }
        public decimal? Tb02101Basered { get; set; }
        public decimal? Tb02101Qtdisp { get; set; }
        public decimal? Tb02101Qtdispb { get; set; }
        public decimal? Tb02101Icmsst { get; set; }
        public string Tb02101Somast { get; set; }
        public string Tb02101Cst { get; set; }
        public decimal? Tb02101Baseicms { get; set; }
        public decimal? Tb02101Baseicmsb { get; set; }
        public decimal? Tb02101Basest { get; set; }
        public decimal? Tb02101Basestb { get; set; }

        public virtual Tb02002 Tb02101CodigoNavigation { get; set; }
        public virtual Tb01010 Tb02101ProdutoNavigation { get; set; }
    }
}