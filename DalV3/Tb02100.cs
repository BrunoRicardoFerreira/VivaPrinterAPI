using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02100
    {
        public DateTime? Tb02100Dtcad { get; set; }
        public string Tb02100Opcad { get; set; }
        public DateTime? Tb02100Dtalt { get; set; }
        public string Tb02100Opalt { get; set; }
        public decimal? Tb02100Baseicms { get; set; }
        public decimal? Tb02100Baseicmssub { get; set; }
        public string Tb02100Codemp { get; set; }
        public string Tb02100Codfor { get; set; }
        public string Tb02100Codigo { get; set; }
        public string Tb02100Condpag { get; set; }
        public DateTime? Tb02100Data { get; set; }
        public decimal? Tb02100Despadd { get; set; }
        public string Tb02100Espercie { get; set; }
        public string Tb02100Marca { get; set; }
        public string Tb02100Ntfisc { get; set; }
        public string Tb02100Numero { get; set; }
        public string Tb02100Obs { get; set; }
        public string Tb02100Obsadd { get; set; }
        public decimal? Tb02100Percdesconto { get; set; }
        public decimal? Tb02100Qtde { get; set; }
        public int? Tb02100Qtvolumes { get; set; }
        public string Tb02100Situacao { get; set; }
        public int? Tb02100Tipo { get; set; }
        public string Tb02100Transp { get; set; }
        public decimal? Tb02100Vlrbruto { get; set; }
        public decimal? Tb02100Vlrdesconto { get; set; }
        public decimal? Tb02100Vlrfrete { get; set; }
        public decimal? Tb02100Vlricms { get; set; }
        public decimal? Tb02100Vlricmssub { get; set; }
        public decimal? Tb02100Vlripi { get; set; }
        public decimal? Tb02100Vlrnota { get; set; }
        public decimal? Tb02100Vlroutdesp { get; set; }
        public DateTime? Tb02100Dtctrc { get; set; }
        public string Tb02100Numctrc { get; set; }
        public DateTime? Tb02100Dtpag { get; set; }
        public string Tb02100Codpre { get; set; }
        public string Tb02100Natureza { get; set; }
        public string Tb02100Tipototal { get; set; }
        public decimal? Tb02100Vlricmssub2 { get; set; }
        public decimal? Tb02100Vlrbruto2 { get; set; }
        public decimal? Tb02100Vlrdesconto2 { get; set; }
        public decimal? Tb02100Vlrfrete2 { get; set; }
        public decimal? Tb02100Vlrfrete3 { get; set; }
        public decimal? Tb02100Vlripi2 { get; set; }
        public decimal? Tb02100Vlrnota2 { get; set; }
        public string Tb02100Somasub { get; set; }
        public string Tb02100Codcen { get; set; }
        public string Tb02100Codsub { get; set; }
        public string Tb02100Plancon { get; set; }
        public DateTime? Tb02100Dtentrada { get; set; }
        public string Tb02100Contabil { get; set; }
        public int? Tb02100Tipofrete { get; set; }
        public string Tb02100Placa { get; set; }
        public string Tb02100Ufplaca { get; set; }
        public decimal? Tb02100Pesobruto { get; set; }
        public decimal? Tb02100Pesoliquido { get; set; }
        public DateTime? Tb02100Datanota { get; set; }
        public string Tb02100Horanota { get; set; }
        public decimal? Tb02100Baseicms2 { get; set; }
        public decimal? Tb02100Vlricms2 { get; set; }
        public decimal? Tb02100Vlroutdesp2 { get; set; }
        public string Tb02100Serie { get; set; }
        public string Tb02100Subserie { get; set; }
        public string Tb02100Ntconf { get; set; }
        public decimal? Tb02100Qtdisp { get; set; }
        public string Tb02100Somafrete { get; set; }

        public virtual Tb04004 Tb02100CodcenNavigation { get; set; }
        public virtual Tb01007 Tb02100CodempNavigation { get; set; }
        public virtual Tb01001 Tb02100CodforNavigation { get; set; }
        public virtual Tb04005 Tb02100CodsubNavigation { get; set; }
        public virtual Tb01012 Tb02100CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02100NaturezaNavigation { get; set; }
        public virtual Tb04006 Tb02100PlanconNavigation { get; set; }
        public virtual Tb01009 Tb02100TranspNavigation { get; set; }
    }
}