using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02073
    {
        public Tb02073()
        {
            Tb02074 = new HashSet<Tb02074>();
            Tb02202 = new HashSet<Tb02202>();
            Tb02203 = new HashSet<Tb02203>();
        }

        public DateTime? Tb02073Dtcad { get; set; }
        public string Tb02073Opcad { get; set; }
        public DateTime? Tb02073Dtalt { get; set; }
        public string Tb02073Opalt { get; set; }
        public decimal? Tb02073Baseicms { get; set; }
        public decimal? Tb02073Baseicmssub { get; set; }
        public string Tb02073Codemp { get; set; }
        public string Tb02073Codfor { get; set; }
        public string Tb02073Codigo { get; set; }
        public string Tb02073Condpag { get; set; }
        public DateTime? Tb02073Data { get; set; }
        public decimal? Tb02073Despadd { get; set; }
        public string Tb02073Espercie { get; set; }
        public string Tb02073Marca { get; set; }
        public string Tb02073Ntfisc { get; set; }
        public string Tb02073Numero { get; set; }
        public string Tb02073Obs { get; set; }
        public string Tb02073Obsadd { get; set; }
        public decimal? Tb02073Percdesconto { get; set; }
        public decimal? Tb02073Qtde { get; set; }
        public int? Tb02073Qtvolumes { get; set; }
        public string Tb02073Situacao { get; set; }
        public int? Tb02073Tipo { get; set; }
        public string Tb02073Transp { get; set; }
        public decimal? Tb02073Vlrbruto { get; set; }
        public decimal? Tb02073Vlrdesconto { get; set; }
        public decimal? Tb02073Vlrfrete { get; set; }
        public decimal? Tb02073Vlricms { get; set; }
        public decimal? Tb02073Vlricmssub { get; set; }
        public decimal? Tb02073Vlripi { get; set; }
        public decimal? Tb02073Vlrnota { get; set; }
        public decimal? Tb02073Vlroutdesp { get; set; }
        public DateTime? Tb02073Dtctrc { get; set; }
        public string Tb02073Numctrc { get; set; }
        public DateTime? Tb02073Dtpag { get; set; }
        public string Tb02073Codpre { get; set; }
        public string Tb02073Natureza { get; set; }
        public string Tb02073Tipototal { get; set; }
        public decimal? Tb02073Vlricmssub2 { get; set; }
        public decimal? Tb02073Vlrbruto2 { get; set; }
        public decimal? Tb02073Vlrdesconto2 { get; set; }
        public decimal? Tb02073Vlrfrete2 { get; set; }
        public decimal? Tb02073Vlrfrete3 { get; set; }
        public decimal? Tb02073Vlripi2 { get; set; }
        public decimal? Tb02073Vlrnota2 { get; set; }
        public string Tb02073Somasub { get; set; }
        public string Tb02073Codcen { get; set; }
        public string Tb02073Codsub { get; set; }
        public string Tb02073Plancon { get; set; }
        public DateTime? Tb02073Dtentrada { get; set; }
        public string Tb02073Contabil { get; set; }
        public int? Tb02073Tipofrete { get; set; }
        public string Tb02073Placa { get; set; }
        public string Tb02073Ufplaca { get; set; }
        public decimal? Tb02073Pesobruto { get; set; }
        public decimal? Tb02073Pesoliquido { get; set; }
        public DateTime? Tb02073Datanota { get; set; }
        public string Tb02073Horanota { get; set; }
        public decimal? Tb02073Baseicms2 { get; set; }
        public decimal? Tb02073Vlricms2 { get; set; }
        public decimal? Tb02073Vlroutdesp2 { get; set; }
        public string Tb02073Serie { get; set; }
        public string Tb02073Subserie { get; set; }
        public DateTime? Tb02073Dtconf { get; set; }
        public string Tb02073Somafrete { get; set; }
        public string Tb02073Numnfe { get; set; }
        public string Tb02073Numdi { get; set; }
        public DateTime? Tb02073Datadespacho { get; set; }
        public string Tb02073Enddespacho { get; set; }
        public string Tb02073Somadesp { get; set; }
        public string Tb02073Somast { get; set; }
        public string Tb02073Opcom { get; set; }
        public decimal? Tb02073Qtdevol { get; set; }
        public string Tb02073Devlocacao { get; set; }
        public string Tb02073Contrato { get; set; }

        public virtual Tb04004 Tb02073CodcenNavigation { get; set; }
        public virtual Tb01007 Tb02073CodempNavigation { get; set; }
        public virtual Tb01001 Tb02073CodforNavigation { get; set; }
        public virtual Tb04005 Tb02073CodsubNavigation { get; set; }
        public virtual Tb01012 Tb02073CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02073NaturezaNavigation { get; set; }
        public virtual Tb01078 Tb02073OpcomNavigation { get; set; }
        public virtual Tb04006 Tb02073PlanconNavigation { get; set; }
        public virtual Tb01009 Tb02073TranspNavigation { get; set; }
        public virtual ICollection<Tb02074> Tb02074 { get; set; }
        public virtual ICollection<Tb02202> Tb02202 { get; set; }
        public virtual ICollection<Tb02203> Tb02203 { get; set; }
    }
}