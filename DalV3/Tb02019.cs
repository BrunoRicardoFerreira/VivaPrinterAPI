using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02019
    {
        public DateTime? Tb02019Dtcad { get; set; }
        public string Tb02019Opcad { get; set; }
        public DateTime? Tb02019Dtalt { get; set; }
        public string Tb02019Opalt { get; set; }
        public string Tb02019Codigo { get; set; }
        public decimal? Tb02019Custo { get; set; }
        public decimal? Tb02019Perdesc { get; set; }
        public string Tb02019Produto { get; set; }
        public decimal? Tb02019Prunit { get; set; }
        public decimal? Tb02019Qtprod { get; set; }
        public decimal? Tb02019Qtprodb { get; set; }
        public string Tb02019Situacao { get; set; }
        public decimal? Tb02019Totvalor { get; set; }
        public decimal? Tb02019Totvalorb { get; set; }
        public string Tb02019Numserie { get; set; }
        public string Tb02019Codemp { get; set; }
        public decimal? Tb02019Vlrdesc { get; set; }
        public decimal? Tb02019Vlrdescb { get; set; }
        public decimal? Tb02019Icms { get; set; }
        public decimal? Tb02019Vlricms { get; set; }
        public decimal? Tb02019Vlricmsb { get; set; }
        public string Tb02019Natureza { get; set; }
        public decimal? Tb02019Percipi { get; set; }
        public decimal? Tb02019Vlripi { get; set; }
        public decimal? Tb02019Vlripib { get; set; }
        public decimal? Tb02019Percst { get; set; }
        public decimal? Tb02019Vlrst { get; set; }
        public decimal? Tb02019Vlrstb { get; set; }
        public decimal? Tb02019Prbackup { get; set; }
        public string Tb02019Tipodesc { get; set; }
        public decimal? Tb02019Basered { get; set; }
        public decimal? Tb02019Baseicms { get; set; }
        public decimal? Tb02019Baseicmsb { get; set; }
        public decimal? Tb02019Basest { get; set; }
        public decimal? Tb02019Basestb { get; set; }
        public decimal? Tb02019Comissao { get; set; }
        public string Tb02019Tabela { get; set; }
        public decimal? Tb02019Custocompra { get; set; }
        public DateTime? Tb02019Dtent { get; set; }
        public decimal? Tb02019Vlrdescacu { get; set; }
        public string Tb02019Ipiicms { get; set; }
        public decimal? Tb02019Vlrfrete { get; set; }
        public decimal? Tb02019Vlrfreteb { get; set; }
        public decimal? Tb02019Vlroutdesp { get; set; }
        public decimal? Tb02019Vlroutdespb { get; set; }
        public string Tb02019Equip { get; set; }
        public int? Tb02019Item { get; set; }
        public string Tb02019Descprod { get; set; }
        public string Tb02019Unprod { get; set; }
        public decimal? Tb02019Acrescimo { get; set; }
        public string Tb02019Codaliqecf { get; set; }
        public string Tb02019Ativo { get; set; }
        public decimal? Tb02019Icmsdentro { get; set; }
        public decimal? Tb02019Vlricmsdentro { get; set; }
        public decimal? Tb02019Vlricmsdentrob { get; set; }
        public decimal? Tb02019Icmsfora { get; set; }
        public decimal? Tb02019Vlricmsfora { get; set; }
        public decimal? Tb02019Vlricmsforab { get; set; }
        public decimal? Tb02019Vlrdifaliq { get; set; }
        public decimal? Tb02019Vlrdifaliqb { get; set; }
        public decimal? Tb02019Fcp { get; set; }
        public decimal? Tb02019Vlrfcp { get; set; }
        public decimal? Tb02019Vlrfcpb { get; set; }
        public decimal? Tb02019Partilhaint { get; set; }
        public decimal? Tb02019Partilhaext { get; set; }
        public decimal? Tb02019Basefcptot { get; set; }
        public decimal? Tb02019Basefcptotb { get; set; }
        public decimal? Tb02019Vlrfcptot { get; set; }
        public decimal? Tb02019Vlrfcptotb { get; set; }
        public decimal? Tb02019Basefcptotst { get; set; }
        public decimal? Tb02019Basefcptotstb { get; set; }
        public decimal? Tb02019Vlrfcptotst { get; set; }
        public decimal? Tb02019Vlrfcptotstb { get; set; }
        public decimal? Tb02019Fcpst { get; set; }

        public virtual Tb01007 Tb02019CodempNavigation { get; set; }
        public virtual Tb01010 Tb02019ProdutoNavigation { get; set; }
    }
}