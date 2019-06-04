using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02092
    {
        public DateTime? Tb02092Dtcad { get; set; }
        public string Tb02092Opcad { get; set; }
        public DateTime? Tb02092Dtalt { get; set; }
        public string Tb02092Opalt { get; set; }
        public string Tb02092Codigo { get; set; }
        public decimal? Tb02092Custo { get; set; }
        public decimal? Tb02092Perdesc { get; set; }
        public string Tb02092Produto { get; set; }
        public decimal Tb02092Prunit { get; set; }
        public decimal? Tb02092Qtprod { get; set; }
        public decimal? Tb02092Qtprodb { get; set; }
        public string Tb02092Situacao { get; set; }
        public decimal? Tb02092Totvalor { get; set; }
        public decimal? Tb02092Totvalorb { get; set; }
        public decimal? Tb02092Vlrdesc { get; set; }
        public decimal? Tb02092Vlrdescb { get; set; }
        public decimal? Tb02092Icms { get; set; }
        public decimal? Tb02092Vlricms { get; set; }
        public decimal? Tb02092Vlricmsb { get; set; }
        public string Tb02092Natureza { get; set; }
        public decimal? Tb02092Percipi { get; set; }
        public decimal? Tb02092Vlripi { get; set; }
        public decimal? Tb02092Vlripib { get; set; }
        public decimal? Tb02092Percst { get; set; }
        public decimal? Tb02092Vlrst { get; set; }
        public decimal? Tb02092Vlrstb { get; set; }
        public string Tb02092Vendtran { get; set; }
        public decimal? Tb02092Basered { get; set; }
        public decimal? Tb02092Baseicms { get; set; }
        public decimal? Tb02092Baseicmsb { get; set; }
        public decimal? Tb02092Basest { get; set; }
        public decimal? Tb02092Basestb { get; set; }
        public string Tb02092Cst { get; set; }
        public decimal? Tb02092Icmsst { get; set; }
        public decimal? Tb02092Pis { get; set; }
        public decimal? Tb02092Cofins { get; set; }
        public string Tb02092Cstpis { get; set; }
        public string Tb02092Cstcofins { get; set; }
        public string Tb02092Cstipi { get; set; }
        public string Tb02092Ipiicms { get; set; }
        public decimal? Tb02092Vlrfrete { get; set; }
        public decimal? Tb02092Vlrfreteb { get; set; }
        public decimal? Tb02092Vlroutdesp { get; set; }
        public decimal? Tb02092Vlroutdespb { get; set; }
        public string Tb02092Ndi { get; set; }
        public DateTime? Tb02092Ddi { get; set; }
        public string Tb02092Locdesemb { get; set; }
        public string Tb02092Ufdesemb { get; set; }
        public DateTime? Tb02092Dtdesemb { get; set; }
        public string Tb02092Cexporta { get; set; }
        public string Tb02092Adicao { get; set; }
        public string Tb02092Seqadic { get; set; }
        public string Tb02092Cfabrica { get; set; }
        public decimal? Tb02092Vlrdescimp { get; set; }
        public decimal? Tb02092Vlrvbci { get; set; }
        public decimal? Tb02092Vlrdespadu { get; set; }
        public decimal? Tb02092Vlrii { get; set; }
        public decimal? Tb02092Vlriof { get; set; }
        public decimal? Tb02092Aliqimpfat { get; set; }
        public string Tb02092Tipo { get; set; }
        public decimal? Tb02092Aliqiss { get; set; }
        public string Tb02092Retiss { get; set; }
        public string Tb02092Obs { get; set; }
        public decimal? Tb02092Icmsdentro { get; set; }
        public decimal? Tb02092Vlricmsdentro { get; set; }
        public decimal? Tb02092Vlricmsdentrob { get; set; }
        public decimal? Tb02092Icmsfora { get; set; }
        public decimal? Tb02092Vlricmsfora { get; set; }
        public decimal? Tb02092Vlricmsforab { get; set; }
        public decimal? Tb02092Vlrdifaliq { get; set; }
        public decimal? Tb02092Vlrdifaliqb { get; set; }
        public decimal? Tb02092Fcp { get; set; }
        public decimal? Tb02092Vlrfcp { get; set; }
        public decimal? Tb02092Vlrfcpb { get; set; }
        public decimal? Tb02092Partilhaint { get; set; }
        public decimal? Tb02092Partilhaext { get; set; }
        public int? Tb02092Viatransp { get; set; }
        public int? Tb02092Intermedio { get; set; }
        public string Tb02092Numped { get; set; }
        public int? Tb02092Itemped { get; set; }
        public string Tb02092Servtrib { get; set; }
        public decimal? Tb02092Afrmm { get; set; }
        public decimal? Tb02092Afrmmb { get; set; }
        public decimal? Tb02092Acrescimo { get; set; }
        public decimal? Tb02092Vlrbcipi { get; set; }
        public decimal? Tb02092Vlrbcpis { get; set; }
        public decimal? Tb02092Vlrbccofins { get; set; }
        public decimal? Tb02092Basefcptot { get; set; }
        public decimal? Tb02092Basefcptotb { get; set; }
        public decimal? Tb02092Vlrfcptot { get; set; }
        public decimal? Tb02092Vlrfcptotb { get; set; }
        public decimal? Tb02092Basefcptotst { get; set; }
        public decimal? Tb02092Basefcptotstb { get; set; }
        public decimal? Tb02092Vlrfcptotst { get; set; }
        public decimal? Tb02092Vlrfcptotstb { get; set; }
        public decimal? Tb02092Fcpst { get; set; }

        public virtual Tb02091 Tb02092CodigoNavigation { get; set; }
        public virtual Tb01051 Tb02092CstNavigation { get; set; }
        public virtual Tb01053 Tb02092CstcofinsNavigation { get; set; }
        public virtual Tb01054 Tb02092CstipiNavigation { get; set; }
        public virtual Tb01052 Tb02092CstpisNavigation { get; set; }
    }
}