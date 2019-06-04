using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02022
    {
        public DateTime? Tb02022Dtcad { get; set; }
        public string Tb02022Opcad { get; set; }
        public DateTime? Tb02022Dtalt { get; set; }
        public string Tb02022Opalt { get; set; }
        public string Tb02022Codigo { get; set; }
        public decimal? Tb02022Custo { get; set; }
        public decimal? Tb02022Perdesc { get; set; }
        public string Tb02022Produto { get; set; }
        public decimal? Tb02022Prunit { get; set; }
        public decimal? Tb02022Qtprod { get; set; }
        public decimal? Tb02022Qtprodb { get; set; }
        public string Tb02022Situacao { get; set; }
        public decimal? Tb02022Totvalor { get; set; }
        public decimal? Tb02022Totvalorb { get; set; }
        public string Tb02022Numserie { get; set; }
        public string Tb02022Codemp { get; set; }
        public decimal? Tb02022Vlrdesc { get; set; }
        public decimal? Tb02022Vlrdescb { get; set; }
        public decimal? Tb02022Icms { get; set; }
        public decimal? Tb02022Vlricms { get; set; }
        public decimal? Tb02022Vlricmsb { get; set; }
        public string Tb02022Natureza { get; set; }
        public decimal? Tb02022Percipi { get; set; }
        public decimal? Tb02022Vlripi { get; set; }
        public decimal? Tb02022Vlripib { get; set; }
        public decimal? Tb02022Percst { get; set; }
        public decimal? Tb02022Vlrst { get; set; }
        public decimal? Tb02022Vlrstb { get; set; }
        public string Tb02022Codcai { get; set; }
        public decimal? Tb02022Prbackup { get; set; }
        public string Tb02022Tipodesc { get; set; }
        public decimal? Tb02022Basered { get; set; }
        public decimal? Tb02022Baseicms { get; set; }
        public decimal? Tb02022Baseicmsb { get; set; }
        public decimal? Tb02022Basest { get; set; }
        public decimal? Tb02022Basestb { get; set; }
        public decimal? Tb02022Comissao { get; set; }
        public string Tb02022Tabela { get; set; }
        public decimal? Tb02022Custocompra { get; set; }
        public decimal? Tb02022Vlrdescacu { get; set; }
        public string Tb02022Ipiicms { get; set; }
        public decimal? Tb02022Vlrfrete { get; set; }
        public decimal? Tb02022Vlrfreteb { get; set; }
        public decimal? Tb02022Vlroutdesp { get; set; }
        public decimal? Tb02022Vlroutdespb { get; set; }
        public string Tb02022Codaliqecf { get; set; }
        public string Tb02022Cst { get; set; }
        public string Tb02022Cstpis { get; set; }
        public string Tb02022Cstcofins { get; set; }
        public decimal? Tb02022Pis { get; set; }
        public decimal? Tb02022Cofins { get; set; }
        public decimal? Tb02022Vlricmscu { get; set; }
        public decimal? Tb02022Icmsdentro { get; set; }
        public decimal? Tb02022Vlricmsdentro { get; set; }
        public decimal? Tb02022Vlricmsdentrob { get; set; }
        public decimal? Tb02022Icmsfora { get; set; }
        public decimal? Tb02022Vlricmsfora { get; set; }
        public decimal? Tb02022Vlricmsforab { get; set; }
        public decimal? Tb02022Vlrdifaliq { get; set; }
        public decimal? Tb02022Vlrdifaliqb { get; set; }
        public decimal? Tb02022Fcp { get; set; }
        public decimal? Tb02022Vlrfcp { get; set; }
        public decimal? Tb02022Vlrfcpb { get; set; }
        public decimal? Tb02022Partilhaint { get; set; }
        public decimal? Tb02022Partilhaext { get; set; }
        public decimal? Tb02022Basefcptot { get; set; }
        public decimal? Tb02022Basefcptotb { get; set; }
        public decimal? Tb02022Vlrfcptot { get; set; }
        public decimal? Tb02022Vlrfcptotb { get; set; }
        public decimal? Tb02022Basefcptotst { get; set; }
        public decimal? Tb02022Basefcptotstb { get; set; }
        public decimal? Tb02022Vlrfcptotst { get; set; }
        public decimal? Tb02022Vlrfcptotstb { get; set; }
        public decimal? Tb02022Fcpst { get; set; }

        public virtual Tb01007 Tb02022CodempNavigation { get; set; }
        public virtual Tb01010 Tb02022ProdutoNavigation { get; set; }
    }
}