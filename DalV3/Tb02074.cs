using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02074
    {
        public DateTime? Tb02074Dtcad { get; set; }
        public string Tb02074Opcad { get; set; }
        public DateTime? Tb02074Dtalt { get; set; }
        public string Tb02074Opalt { get; set; }
        public string Tb02074Codigo { get; set; }
        public decimal? Tb02074Custo { get; set; }
        public decimal? Tb02074Perdesc { get; set; }
        public string Tb02074Produto { get; set; }
        public decimal Tb02074Prunit { get; set; }
        public decimal? Tb02074Qtprod { get; set; }
        public decimal? Tb02074Qtprodb { get; set; }
        public string Tb02074Situacao { get; set; }
        public decimal? Tb02074Totvalor { get; set; }
        public decimal? Tb02074Totvalorb { get; set; }
        public decimal? Tb02074Percipi { get; set; }
        public decimal? Tb02074Vlripi { get; set; }
        public decimal? Tb02074Vlripib { get; set; }
        public string Tb02074Codpre { get; set; }
        public decimal? Tb02074Percst { get; set; }
        public decimal? Tb02074Vlrst { get; set; }
        public decimal? Tb02074Vlrstb { get; set; }
        public int? Tb02074Registro { get; set; }
        public string Tb02074Bxped { get; set; }
        public decimal? Tb02074Vlrdesc { get; set; }
        public decimal? Tb02074Icms { get; set; }
        public decimal? Tb02074Vlricms { get; set; }
        public string Tb02074Natureza { get; set; }
        public decimal? Tb02074Vlrdescb { get; set; }
        public decimal? Tb02074Vlricmsb { get; set; }
        public decimal? Tb02074Vlrfrete { get; set; }
        public decimal? Tb02074Vlroutdesp { get; set; }
        public decimal? Tb02074Vlrfreteb { get; set; }
        public decimal? Tb02074Vlroutdespb { get; set; }
        public decimal? Tb02074Basered { get; set; }
        public decimal? Tb02074Icmsst { get; set; }
        public string Tb02074Somast { get; set; }
        public decimal? Tb02074Baseicms { get; set; }
        public decimal? Tb02074Baseicmsb { get; set; }
        public decimal? Tb02074Basest { get; set; }
        public decimal? Tb02074Basestb { get; set; }
        public string Tb02074Cst { get; set; }
        public decimal? Tb02074Pis { get; set; }
        public decimal? Tb02074Cofins { get; set; }
        public string Tb02074Cstpis { get; set; }
        public string Tb02074Cstcofins { get; set; }
        public string Tb02074Cstipi { get; set; }
        public string Tb02074Ipiicms { get; set; }
        public string Tb02074Freteipi { get; set; }
        public string Tb02074Ndi { get; set; }
        public DateTime? Tb02074Ddi { get; set; }
        public string Tb02074Locdesemb { get; set; }
        public string Tb02074Ufdesemb { get; set; }
        public DateTime? Tb02074Dtdesemb { get; set; }
        public string Tb02074Cexporta { get; set; }
        public string Tb02074Adicao { get; set; }
        public string Tb02074Seqadic { get; set; }
        public string Tb02074Cfabrica { get; set; }
        public decimal? Tb02074Vlrdescimp { get; set; }
        public decimal? Tb02074Vlrvbci { get; set; }
        public decimal? Tb02074Vlrdespadu { get; set; }
        public decimal? Tb02074Vlrii { get; set; }
        public decimal? Tb02074Vlriof { get; set; }
        public string Tb02074Despipi { get; set; }
        public string Tb02074Tipoestoque { get; set; }
        public string Tb02074Opcom { get; set; }
        public string Tb02074Unprod { get; set; }
        public decimal? Tb02074Qtprodun { get; set; }
        public decimal? Tb02074Acrescimo { get; set; }
        public decimal? Tb02074Acrescimob { get; set; }
        public decimal? Tb02074Afrmm { get; set; }
        public decimal? Tb02074Afrmmb { get; set; }
        public decimal? Tb02074Vlrbcipi { get; set; }
        public decimal? Tb02074Vlrbcpis { get; set; }
        public decimal? Tb02074Vlrbccofins { get; set; }

        public virtual Tb02073 Tb02074CodigoNavigation { get; set; }
        public virtual Tb01051 Tb02074CstNavigation { get; set; }
        public virtual Tb01053 Tb02074CstcofinsNavigation { get; set; }
        public virtual Tb01054 Tb02074CstipiNavigation { get; set; }
        public virtual Tb01052 Tb02074CstpisNavigation { get; set; }
        public virtual Tb01078 Tb02074OpcomNavigation { get; set; }
        public virtual Tb01010 Tb02074ProdutoNavigation { get; set; }
    }
}