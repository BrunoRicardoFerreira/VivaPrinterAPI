using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02079
    {
        public Tb02079()
        {
            Tb02080 = new HashSet<Tb02080>();
            Tb02081 = new HashSet<Tb02081>();
            Tb02081b = new HashSet<Tb02081b>();
            Tb02082 = new HashSet<Tb02082>();
            Tb02082b = new HashSet<Tb02082b>();
        }

        public DateTime? Tb02079Dtcad { get; set; }
        public string Tb02079Opcad { get; set; }
        public DateTime? Tb02079Dtalt { get; set; }
        public string Tb02079Opalt { get; set; }
        public decimal? Tb02079Baseicms { get; set; }
        public decimal? Tb02079Baseicmssub { get; set; }
        public string Tb02079Codemp { get; set; }
        public string Tb02079Codigo { get; set; }
        public string Tb02079Condpag { get; set; }
        public DateTime? Tb02079Data { get; set; }
        public decimal? Tb02079Despadd { get; set; }
        public string Tb02079Espercie { get; set; }
        public string Tb02079Marca { get; set; }
        public string Tb02079Ntfisc { get; set; }
        public string Tb02079Nome { get; set; }
        public string Tb02079Numero { get; set; }
        public string Tb02079Obs { get; set; }
        public string Tb02079Obsadd { get; set; }
        public decimal? Tb02079Percdesconto { get; set; }
        public decimal? Tb02079Qtde { get; set; }
        public int? Tb02079Qtvolumes { get; set; }
        public string Tb02079Situacao { get; set; }
        public string Tb02079Transp { get; set; }
        public decimal? Tb02079Vlrbruto { get; set; }
        public decimal? Tb02079Vlrdesconto { get; set; }
        public decimal? Tb02079Vlrfrete { get; set; }
        public decimal? Tb02079Vlricms { get; set; }
        public decimal? Tb02079Vlricmssub { get; set; }
        public decimal? Tb02079Vlripi { get; set; }
        public decimal? Tb02079Vlrnota { get; set; }
        public decimal? Tb02079Vlroutdesp { get; set; }
        public string Tb02079Natureza { get; set; }
        public string Tb02079Contabil { get; set; }
        public int? Tb02079Tipofrete { get; set; }
        public string Tb02079Placa { get; set; }
        public string Tb02079Ufplaca { get; set; }
        public decimal? Tb02079Pesobruto { get; set; }
        public decimal? Tb02079Pesoliquido { get; set; }
        public DateTime? Tb02079Datanota { get; set; }
        public string Tb02079Horanota { get; set; }
        public DateTime? Tb02079Dtaprova { get; set; }
        public DateTime? Tb02079Dtentrega { get; set; }
        public string Tb02079Numorc { get; set; }

        public virtual Tb01007 Tb02079CodempNavigation { get; set; }
        public virtual Tb01012 Tb02079CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02079NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02079TranspNavigation { get; set; }
        public virtual ICollection<Tb02080> Tb02080 { get; set; }
        public virtual ICollection<Tb02081> Tb02081 { get; set; }
        public virtual ICollection<Tb02081b> Tb02081b { get; set; }
        public virtual ICollection<Tb02082> Tb02082 { get; set; }
        public virtual ICollection<Tb02082b> Tb02082b { get; set; }
    }
}