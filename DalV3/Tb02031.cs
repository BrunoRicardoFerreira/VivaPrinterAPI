using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02031
    {
        public DateTime? Tb02031Dtcad { get; set; }
        public string Tb02031Opcad { get; set; }
        public DateTime? Tb02031Dtalt { get; set; }
        public string Tb02031Opalt { get; set; }
        public string Tb02031Codigo { get; set; }
        public decimal? Tb02031Custo { get; set; }
        public decimal? Tb02031Perdesc { get; set; }
        public string Tb02031Produto { get; set; }
        public decimal Tb02031Prunit { get; set; }
        public decimal? Tb02031Qtprod { get; set; }
        public decimal? Tb02031Qtprodb { get; set; }
        public string Tb02031Situacao { get; set; }
        public decimal? Tb02031Totvalor { get; set; }
        public decimal? Tb02031Totvalorb { get; set; }
        public decimal? Tb02031Percipi { get; set; }
        public decimal? Tb02031Vlripi { get; set; }
        public decimal? Tb02031Vlripib { get; set; }
        public decimal? Tb02031Percst { get; set; }
        public decimal? Tb02031Vlrst { get; set; }
        public decimal? Tb02031Vlrstb { get; set; }
        public int? Tb02031Registro { get; set; }
        public decimal? Tb02031Vlrdesc { get; set; }
        public decimal? Tb02031Vlrdescb { get; set; }
        public decimal? Tb02031Icms { get; set; }
        public decimal? Tb02031Vlricms { get; set; }
        public decimal? Tb02031Vlricmsb { get; set; }
        public string Tb02031Natureza { get; set; }
        public decimal? Tb02031Vlrfrete { get; set; }
        public decimal? Tb02031Vlroutdesp { get; set; }
        public decimal? Tb02031Vlrfreteb { get; set; }
        public decimal? Tb02031Vlroutdespb { get; set; }
        public decimal? Tb02031Basered { get; set; }
        public decimal? Tb02031Icmsst { get; set; }
        public string Tb02031Somast { get; set; }
        public DateTime? Tb02031Dtent { get; set; }
        public decimal? Tb02031Baseicms { get; set; }
        public decimal? Tb02031Baseicmsb { get; set; }
        public decimal? Tb02031Basest { get; set; }
        public decimal? Tb02031Basestb { get; set; }
        public string Tb02031Cst { get; set; }
        public decimal? Tb02031Cofins { get; set; }
        public string Tb02031Cstcofins { get; set; }
        public string Tb02031Cstipi { get; set; }
        public string Tb02031Cstpis { get; set; }
        public decimal? Tb02031Pis { get; set; }
        public string Tb02031Opcom { get; set; }
        public string Tb02031Unprod { get; set; }
        public decimal? Tb02031Qtprodun { get; set; }

        public virtual Tb02030 Tb02031CodigoNavigation { get; set; }
        public virtual Tb01078 Tb02031OpcomNavigation { get; set; }
        public virtual Tb01010 Tb02031ProdutoNavigation { get; set; }
    }
}