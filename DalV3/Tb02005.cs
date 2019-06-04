using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02005
    {
        public Tb02005()
        {
            Tb02006 = new HashSet<Tb02006>();
        }

        public DateTime? Tb02005Dtcad { get; set; }
        public string Tb02005Opcad { get; set; }
        public DateTime? Tb02005Dtalt { get; set; }
        public string Tb02005Opalt { get; set; }
        public decimal? Tb02005Baseicms { get; set; }
        public decimal? Tb02005Baseicmssub { get; set; }
        public string Tb02005Codemp { get; set; }
        public string Tb02005Codigo { get; set; }
        public string Tb02005Condpag { get; set; }
        public DateTime? Tb02005Data { get; set; }
        public decimal? Tb02005Despadd { get; set; }
        public string Tb02005Espercie { get; set; }
        public string Tb02005Marca { get; set; }
        public string Tb02005Ntfisc { get; set; }
        public string Tb02005Nome { get; set; }
        public string Tb02005Numero { get; set; }
        public string Tb02005Obs { get; set; }
        public string Tb02005Obsadd { get; set; }
        public decimal? Tb02005Percdesconto { get; set; }
        public decimal? Tb02005Qtde { get; set; }
        public int? Tb02005Qtvolumes { get; set; }
        public string Tb02005Situacao { get; set; }
        public string Tb02005Transp { get; set; }
        public decimal? Tb02005Vlrbruto { get; set; }
        public decimal? Tb02005Vlrdesconto { get; set; }
        public decimal? Tb02005Vlrfrete { get; set; }
        public decimal? Tb02005Vlricms { get; set; }
        public decimal? Tb02005Vlricmssub { get; set; }
        public decimal? Tb02005Vlripi { get; set; }
        public decimal? Tb02005Vlrnota { get; set; }
        public decimal? Tb02005Vlroutdesp { get; set; }
        public string Tb02005Natureza { get; set; }
        public string Tb02005Contabil { get; set; }
        public int? Tb02005Tipofrete { get; set; }
        public string Tb02005Placa { get; set; }
        public string Tb02005Ufplaca { get; set; }
        public decimal? Tb02005Pesobruto { get; set; }
        public decimal? Tb02005Pesoliquido { get; set; }
        public DateTime? Tb02005Datanota { get; set; }
        public string Tb02005Horanota { get; set; }
        public string Tb02005Rma { get; set; }
        public string Tb02005K280 { get; set; }
        public string Tb02005Mesk280 { get; set; }
        public DateTime? Tb02005Datak280 { get; set; }

        public virtual Tb01007 Tb02005CodempNavigation { get; set; }
        public virtual Tb01012 Tb02005CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02005NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02005TranspNavigation { get; set; }
        public virtual ICollection<Tb02006> Tb02006 { get; set; }
    }
}