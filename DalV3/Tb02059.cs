using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02059
    {
        public Tb02059()
        {
            Tb02060 = new HashSet<Tb02060>();
        }

        public DateTime? Tb02059Dtcad { get; set; }
        public string Tb02059Opcad { get; set; }
        public DateTime? Tb02059Dtalt { get; set; }
        public string Tb02059Opalt { get; set; }
        public decimal? Tb02059Baseicms { get; set; }
        public decimal? Tb02059Baseicmssub { get; set; }
        public string Tb02059Codemp { get; set; }
        public string Tb02059Codfor { get; set; }
        public string Tb02059Codigo { get; set; }
        public string Tb02059Condpag { get; set; }
        public DateTime? Tb02059Data { get; set; }
        public decimal? Tb02059Despadd { get; set; }
        public string Tb02059Espercie { get; set; }
        public string Tb02059Marca { get; set; }
        public string Tb02059Ntfisc { get; set; }
        public string Tb02059Numero { get; set; }
        public string Tb02059Obs { get; set; }
        public string Tb02059Obsadd { get; set; }
        public decimal? Tb02059Percdesconto { get; set; }
        public decimal? Tb02059Qtde { get; set; }
        public int? Tb02059Qtvolumes { get; set; }
        public string Tb02059Situacao { get; set; }
        public int? Tb02059Tipo { get; set; }
        public string Tb02059Transp { get; set; }
        public decimal? Tb02059Vlrbruto { get; set; }
        public decimal? Tb02059Vlrdesconto { get; set; }
        public decimal? Tb02059Vlrfrete { get; set; }
        public decimal? Tb02059Vlricms { get; set; }
        public decimal? Tb02059Vlricmssub { get; set; }
        public decimal? Tb02059Vlripi { get; set; }
        public decimal? Tb02059Vlrnota { get; set; }
        public decimal? Tb02059Vlroutdesp { get; set; }
        public DateTime? Tb02059Dtctrc { get; set; }
        public string Tb02059Numctrc { get; set; }
        public DateTime? Tb02059Dtpag { get; set; }
        public string Tb02059Codpre { get; set; }
        public string Tb02059Natureza { get; set; }
        public string Tb02059Tipototal { get; set; }
        public decimal? Tb02059Vlricmssub2 { get; set; }
        public decimal? Tb02059Vlrbruto2 { get; set; }
        public decimal? Tb02059Vlrdesconto2 { get; set; }
        public decimal? Tb02059Vlrfrete2 { get; set; }
        public decimal? Tb02059Vlrfrete3 { get; set; }
        public decimal? Tb02059Vlripi2 { get; set; }
        public decimal? Tb02059Vlrnota2 { get; set; }
        public string Tb02059Somasub { get; set; }
        public string Tb02059Codcen { get; set; }
        public string Tb02059Codsub { get; set; }
        public string Tb02059Plancon { get; set; }
        public DateTime? Tb02059Dtentrada { get; set; }
        public string Tb02059Contabil { get; set; }
        public int? Tb02059Tipofrete { get; set; }
        public string Tb02059Placa { get; set; }
        public string Tb02059Ufplaca { get; set; }
        public decimal? Tb02059Pesobruto { get; set; }
        public decimal? Tb02059Pesoliquido { get; set; }
        public DateTime? Tb02059Datanota { get; set; }
        public string Tb02059Horanota { get; set; }
        public decimal? Tb02059Baseicms2 { get; set; }
        public decimal? Tb02059Vlricms2 { get; set; }
        public decimal? Tb02059Vlroutdesp2 { get; set; }
        public string Tb02059Serie { get; set; }
        public string Tb02059Subserie { get; set; }
        public string Tb02059Somafrete { get; set; }

        public virtual Tb04004 Tb02059CodcenNavigation { get; set; }
        public virtual Tb01007 Tb02059CodempNavigation { get; set; }
        public virtual Tb01001 Tb02059CodforNavigation { get; set; }
        public virtual Tb04005 Tb02059CodsubNavigation { get; set; }
        public virtual Tb01012 Tb02059CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02059NaturezaNavigation { get; set; }
        public virtual Tb04006 Tb02059PlanconNavigation { get; set; }
        public virtual Tb01009 Tb02059TranspNavigation { get; set; }
        public virtual ICollection<Tb02060> Tb02060 { get; set; }
    }
}