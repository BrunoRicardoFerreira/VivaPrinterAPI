using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02002
    {
        public Tb02002()
        {
            Tb02101 = new HashSet<Tb02101>();
            Tb02200 = new HashSet<Tb02200>();
            Tb02201 = new HashSet<Tb02201>();
        }

        public DateTime? Tb02002Dtcad { get; set; }
        public string Tb02002Opcad { get; set; }
        public DateTime? Tb02002Dtalt { get; set; }
        public string Tb02002Opalt { get; set; }
        public decimal? Tb02002Baseicms { get; set; }
        public decimal? Tb02002Baseicmssub { get; set; }
        public string Tb02002Codemp { get; set; }
        public string Tb02002Codfor { get; set; }
        public string Tb02002Codigo { get; set; }
        public string Tb02002Condpag { get; set; }
        public DateTime? Tb02002Data { get; set; }
        public decimal? Tb02002Despadd { get; set; }
        public string Tb02002Espercie { get; set; }
        public string Tb02002Marca { get; set; }
        public string Tb02002Ntfisc { get; set; }
        public string Tb02002Numero { get; set; }
        public string Tb02002Obs { get; set; }
        public string Tb02002Obsadd { get; set; }
        public decimal? Tb02002Percdesconto { get; set; }
        public decimal? Tb02002Qtde { get; set; }
        public int? Tb02002Qtvolumes { get; set; }
        public string Tb02002Situacao { get; set; }
        public int? Tb02002Tipo { get; set; }
        public string Tb02002Transp { get; set; }
        public decimal? Tb02002Vlrbruto { get; set; }
        public decimal? Tb02002Vlrdesconto { get; set; }
        public decimal? Tb02002Vlrfrete { get; set; }
        public decimal? Tb02002Vlricms { get; set; }
        public decimal? Tb02002Vlricmssub { get; set; }
        public decimal? Tb02002Vlripi { get; set; }
        public decimal? Tb02002Vlrnota { get; set; }
        public decimal? Tb02002Vlroutdesp { get; set; }
        public DateTime? Tb02002Dtctrc { get; set; }
        public string Tb02002Numctrc { get; set; }
        public DateTime? Tb02002Dtpag { get; set; }
        public string Tb02002Codpre { get; set; }
        public string Tb02002Natureza { get; set; }
        public string Tb02002Tipototal { get; set; }
        public decimal? Tb02002Vlricmssub2 { get; set; }
        public decimal? Tb02002Vlrbruto2 { get; set; }
        public decimal? Tb02002Vlrdesconto2 { get; set; }
        public decimal? Tb02002Vlrfrete2 { get; set; }
        public decimal? Tb02002Vlrfrete3 { get; set; }
        public decimal? Tb02002Vlripi2 { get; set; }
        public decimal? Tb02002Vlrnota2 { get; set; }
        public string Tb02002Somasub { get; set; }
        public string Tb02002Codcen { get; set; }
        public string Tb02002Codsub { get; set; }
        public string Tb02002Plancon { get; set; }
        public DateTime? Tb02002Dtentrada { get; set; }
        public string Tb02002Contabil { get; set; }
        public int? Tb02002Tipofrete { get; set; }
        public string Tb02002Placa { get; set; }
        public string Tb02002Ufplaca { get; set; }
        public decimal? Tb02002Pesobruto { get; set; }
        public decimal? Tb02002Pesoliquido { get; set; }
        public DateTime? Tb02002Datanota { get; set; }
        public string Tb02002Horanota { get; set; }
        public decimal? Tb02002Baseicms2 { get; set; }
        public decimal? Tb02002Vlricms2 { get; set; }
        public decimal? Tb02002Vlroutdesp2 { get; set; }
        public string Tb02002Serie { get; set; }
        public string Tb02002Subserie { get; set; }
        public string Tb02002Ntconf { get; set; }
        public decimal? Tb02002Qtdisp { get; set; }
        public string Tb02002Somafrete { get; set; }
        public string Tb02002Invent { get; set; }
        public string Tb02002Numnfe { get; set; }
        public string Tb02002Numdi { get; set; }
        public DateTime? Tb02002Datadespacho { get; set; }
        public string Tb02002Enddespacho { get; set; }
        public string Tb02002Somadesp { get; set; }
        public string Tb02002Bonif { get; set; }
        public string Tb02002Npreco { get; set; }
        public string Tb02002Nestoque { get; set; }
        public string Tb02002Tipoestoque { get; set; }
        public string Tb02002Somast { get; set; }
        public string Tb02002Opcom { get; set; }
        public decimal? Tb02002Qtdevol { get; set; }
        public string Tb02002Devlocacao { get; set; }
        public string Tb02002Contrato { get; set; }

        public virtual Tb04004 Tb02002CodcenNavigation { get; set; }
        public virtual Tb01007 Tb02002CodempNavigation { get; set; }
        public virtual Tb01001 Tb02002CodforNavigation { get; set; }
        public virtual Tb04005 Tb02002CodsubNavigation { get; set; }
        public virtual Tb01012 Tb02002CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02002NaturezaNavigation { get; set; }
        public virtual Tb01078 Tb02002OpcomNavigation { get; set; }
        public virtual Tb04006 Tb02002PlanconNavigation { get; set; }
        public virtual Tb01009 Tb02002TranspNavigation { get; set; }
        public virtual ICollection<Tb02101> Tb02101 { get; set; }
        public virtual ICollection<Tb02200> Tb02200 { get; set; }
        public virtual ICollection<Tb02201> Tb02201 { get; set; }
    }
}