using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02057
    {
        public DateTime? Tb02057Dtcad { get; set; }
        public string Tb02057Opcad { get; set; }
        public DateTime? Tb02057Dtalt { get; set; }
        public string Tb02057Opalt { get; set; }
        public decimal? Tb02057Baseicms { get; set; }
        public decimal? Tb02057Baseicmssub { get; set; }
        public string Tb02057Codcli { get; set; }
        public string Tb02057Codemp { get; set; }
        public string Tb02057Codigo { get; set; }
        public string Tb02057Condpag { get; set; }
        public DateTime? Tb02057Data { get; set; }
        public decimal? Tb02057Despadd { get; set; }
        public string Tb02057Espercie { get; set; }
        public string Tb02057Marca { get; set; }
        public string Tb02057Nome { get; set; }
        public string Tb02057Ntfisc { get; set; }
        public string Tb02057Numero { get; set; }
        public string Tb02057Obs { get; set; }
        public string Tb02057Obsadd { get; set; }
        public decimal? Tb02057Percdesconto { get; set; }
        public decimal? Tb02057Qtde { get; set; }
        public int? Tb02057Qtvolumes { get; set; }
        public string Tb02057Situacao { get; set; }
        public string Tb02057Transp { get; set; }
        public decimal? Tb02057Vlrbruto { get; set; }
        public decimal? Tb02057Vlrdesconto { get; set; }
        public decimal? Tb02057Vlrfrete { get; set; }
        public decimal? Tb02057Vlricms { get; set; }
        public decimal? Tb02057Vlricmssub { get; set; }
        public decimal? Tb02057Vlripi { get; set; }
        public decimal? Tb02057Vlrnota { get; set; }
        public decimal? Tb02057Vlroutdesp { get; set; }
        public string Tb02057Natureza { get; set; }
        public string Tb02057Contabil { get; set; }
        public int? Tb02057Tipofrete { get; set; }
        public string Tb02057Placa { get; set; }
        public string Tb02057Ufplaca { get; set; }
        public decimal? Tb02057Pesobruto { get; set; }
        public decimal? Tb02057Pesoliquido { get; set; }
        public DateTime? Tb02057Datanota { get; set; }
        public string Tb02057Horanota { get; set; }

        public virtual Tb01008 Tb02057CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02057CodempNavigation { get; set; }
        public virtual Tb01012 Tb02057CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02057NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02057TranspNavigation { get; set; }
    }
}