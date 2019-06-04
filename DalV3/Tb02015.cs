using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02015
    {
        public Tb02015()
        {
            Tb02016 = new HashSet<Tb02016>();
            Tb02017 = new HashSet<Tb02017>();
            Tb02058 = new HashSet<Tb02058>();
        }

        public DateTime? Tb02015Dtcad { get; set; }
        public string Tb02015Opcad { get; set; }
        public DateTime? Tb02015Dtalt { get; set; }
        public string Tb02015Opalt { get; set; }
        public decimal? Tb02015Baseicms { get; set; }
        public decimal? Tb02015Baseicmssub { get; set; }
        public string Tb02015Codemp { get; set; }
        public string Tb02015Codfor { get; set; }
        public string Tb02015Codigo { get; set; }
        public string Tb02015Condpag { get; set; }
        public DateTime? Tb02015Data { get; set; }
        public DateTime? Tb02015Data2 { get; set; }
        public decimal? Tb02015Despadd { get; set; }
        public string Tb02015Espercie { get; set; }
        public string Tb02015Marca { get; set; }
        public string Tb02015Nome { get; set; }
        public string Tb02015Ntfisc { get; set; }
        public string Tb02015Numero { get; set; }
        public string Tb02015Obs { get; set; }
        public string Tb02015Obsadd { get; set; }
        public decimal? Tb02015Percdesconto { get; set; }
        public decimal? Tb02015Qtde { get; set; }
        public decimal? Tb02015Qtde2 { get; set; }
        public int? Tb02015Qtvolumes { get; set; }
        public string Tb02015Situacao { get; set; }
        public string Tb02015Transp { get; set; }
        public decimal? Tb02015Vlrbruto { get; set; }
        public decimal? Tb02015Vlrdesconto { get; set; }
        public decimal? Tb02015Vlrfrete { get; set; }
        public decimal? Tb02015Vlricms { get; set; }
        public decimal? Tb02015Vlricmssub { get; set; }
        public decimal? Tb02015Vlripi { get; set; }
        public decimal? Tb02015Vlrnota { get; set; }
        public decimal? Tb02015Vlrnota2 { get; set; }
        public decimal? Tb02015Vlroutdesp { get; set; }
        public string Tb02015Natureza { get; set; }
        public string Tb02015Contabil { get; set; }
        public int? Tb02015Tipofrete { get; set; }
        public string Tb02015Placa { get; set; }
        public string Tb02015Ufplaca { get; set; }
        public decimal? Tb02015Pesobruto { get; set; }
        public decimal? Tb02015Pesoliquido { get; set; }
        public DateTime? Tb02015Datanota { get; set; }
        public string Tb02015Horanota { get; set; }
        public string Tb02015Statusrma { get; set; }
        public string Tb02015Tipo { get; set; }
        public string Tb02015Numdev { get; set; }

        public virtual Tb01007 Tb02015CodempNavigation { get; set; }
        public virtual Tb01001 Tb02015CodforNavigation { get; set; }
        public virtual Tb01012 Tb02015CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02015NaturezaNavigation { get; set; }
        public virtual Tb01041 Tb02015StatusrmaNavigation { get; set; }
        public virtual Tb01009 Tb02015TranspNavigation { get; set; }
        public virtual ICollection<Tb02016> Tb02016 { get; set; }
        public virtual ICollection<Tb02017> Tb02017 { get; set; }
        public virtual ICollection<Tb02058> Tb02058 { get; set; }
    }
}