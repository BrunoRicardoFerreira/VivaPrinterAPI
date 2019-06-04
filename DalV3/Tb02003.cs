using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02003
    {
        public DateTime? Tb02003Dtcad { get; set; }
        public string Tb02003Opcad { get; set; }
        public DateTime? Tb02003Dtalt { get; set; }
        public string Tb02003Opalt { get; set; }
        public string Tb02003Codigo { get; set; }
        public decimal? Tb02003Custo { get; set; }
        public decimal? Tb02003Perdesc { get; set; }
        public string Tb02003Produto { get; set; }
        public decimal Tb02003Prunit { get; set; }
        public decimal? Tb02003Qtprod { get; set; }
        public decimal? Tb02003Qtprodb { get; set; }
        public string Tb02003Situacao { get; set; }
        public decimal? Tb02003Totvalor { get; set; }
        public decimal? Tb02003Totvalorb { get; set; }
        public decimal? Tb02003Percipi { get; set; }
        public decimal? Tb02003Vlripi { get; set; }
        public decimal? Tb02003Vlripib { get; set; }
        public string Tb02003Codpre { get; set; }
        public decimal? Tb02003Percst { get; set; }
        public decimal? Tb02003Vlrst { get; set; }
        public decimal? Tb02003Vlrstb { get; set; }
        public int? Tb02003Registro { get; set; }
        public string Tb02003Bxped { get; set; }
        public decimal? Tb02003Vlrdesc { get; set; }
        public decimal? Tb02003Vlrdescb { get; set; }
        public decimal? Tb02003Icms { get; set; }
        public decimal? Tb02003Vlricms { get; set; }
        public decimal? Tb02003Vlricmsb { get; set; }
        public string Tb02003Natureza { get; set; }
        public decimal? Tb02003Vlrfrete { get; set; }
        public decimal? Tb02003Vlroutdesp { get; set; }
        public decimal? Tb02003Vlrfreteb { get; set; }
        public decimal? Tb02003Vlroutdespb { get; set; }
        public decimal? Tb02003Basered { get; set; }
        public decimal? Tb02003Qtdisp { get; set; }
        public decimal? Tb02003Qtdispb { get; set; }
        public decimal? Tb02003Icmsst { get; set; }
        public string Tb02003Somast { get; set; }
        public decimal? Tb02003Baseicms { get; set; }
        public decimal? Tb02003Baseicmsb { get; set; }
        public decimal? Tb02003Basest { get; set; }
        public decimal? Tb02003Basestb { get; set; }
        public string Tb02003Cst { get; set; }
        public decimal? Tb02003Pis { get; set; }
        public decimal? Tb02003Cofins { get; set; }
        public string Tb02003Cstpis { get; set; }
        public string Tb02003Cstcofins { get; set; }
        public string Tb02003Cstipi { get; set; }
        public string Tb02003Ipiicms { get; set; }
        public string Tb02003Freteipi { get; set; }
        public string Tb02003Ndi { get; set; }
        public DateTime? Tb02003Ddi { get; set; }
        public string Tb02003Locdesemb { get; set; }
        public string Tb02003Ufdesemb { get; set; }
        public DateTime? Tb02003Dtdesemb { get; set; }
        public string Tb02003Cexporta { get; set; }
        public string Tb02003Adicao { get; set; }
        public string Tb02003Seqadic { get; set; }
        public string Tb02003Cfabrica { get; set; }
        public decimal? Tb02003Vlrdescimp { get; set; }
        public decimal? Tb02003Vlrvbci { get; set; }
        public decimal? Tb02003Vlrdespadu { get; set; }
        public decimal? Tb02003Vlrii { get; set; }
        public decimal? Tb02003Vlriof { get; set; }
        public string Tb02003Despipi { get; set; }
        public string Tb02003Tipoestoque { get; set; }
        public string Tb02003Opcom { get; set; }
        public string Tb02003Unprod { get; set; }
        public decimal? Tb02003Qtprodun { get; set; }
        public decimal? Tb02003Acrescimo { get; set; }
        public decimal? Tb02003Acrescimob { get; set; }
        public decimal? Tb02003Afrmm { get; set; }
        public decimal? Tb02003Afrmmb { get; set; }
        public decimal? Tb02003Vlrbcipi { get; set; }
        public decimal? Tb02003Vlrbcpis { get; set; }
        public decimal? Tb02003Vlrbccofins { get; set; }

        public virtual Tb01051 Tb02003CstNavigation { get; set; }
        public virtual Tb01053 Tb02003CstcofinsNavigation { get; set; }
        public virtual Tb01054 Tb02003CstipiNavigation { get; set; }
        public virtual Tb01052 Tb02003CstpisNavigation { get; set; }
        public virtual Tb01078 Tb02003OpcomNavigation { get; set; }
    }
}