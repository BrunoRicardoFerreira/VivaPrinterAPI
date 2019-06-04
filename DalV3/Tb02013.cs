using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02013
    {
        public Tb02013()
        {
            Tb02014 = new HashSet<Tb02014>();
        }

        public DateTime? Tb02013Dtcad { get; set; }
        public string Tb02013Opcad { get; set; }
        public DateTime? Tb02013Dtalt { get; set; }
        public string Tb02013Opalt { get; set; }
        public decimal? Tb02013Baseicms { get; set; }
        public decimal? Tb02013Baseicmssub { get; set; }
        public string Tb02013Codemp { get; set; }
        public string Tb02013Codigo { get; set; }
        public string Tb02013Condpag { get; set; }
        public DateTime? Tb02013Data { get; set; }
        public decimal? Tb02013Despadd { get; set; }
        public string Tb02013Empdest { get; set; }
        public string Tb02013Espercie { get; set; }
        public string Tb02013Marca { get; set; }
        public string Tb02013Nome { get; set; }
        public string Tb02013Ntfisc { get; set; }
        public string Tb02013Numero { get; set; }
        public string Tb02013Obs { get; set; }
        public string Tb02013Obsadd { get; set; }
        public decimal? Tb02013Percdesconto { get; set; }
        public decimal? Tb02013Qtde { get; set; }
        public int? Tb02013Qtvolumes { get; set; }
        public string Tb02013Situacao { get; set; }
        public string Tb02013Transp { get; set; }
        public decimal? Tb02013Vlrbruto { get; set; }
        public decimal? Tb02013Vlrdesconto { get; set; }
        public decimal? Tb02013Vlrfrete { get; set; }
        public decimal? Tb02013Vlricms { get; set; }
        public decimal? Tb02013Vlricmssub { get; set; }
        public decimal? Tb02013Vlripi { get; set; }
        public decimal? Tb02013Vlrnota { get; set; }
        public decimal? Tb02013Vlroutdesp { get; set; }
        public string Tb02013Natureza { get; set; }
        public string Tb02013Contabil { get; set; }
        public int? Tb02013Tipofrete { get; set; }
        public string Tb02013Placa { get; set; }
        public string Tb02013Ufplaca { get; set; }
        public decimal? Tb02013Pesobruto { get; set; }
        public decimal? Tb02013Pesoliquido { get; set; }
        public DateTime? Tb02013Datanota { get; set; }
        public string Tb02013Horanota { get; set; }
        public string Tb02013Tipoestoque { get; set; }

        public virtual Tb01007 Tb02013CodempNavigation { get; set; }
        public virtual Tb01012 Tb02013CondpagNavigation { get; set; }
        public virtual Tb01007 Tb02013EmpdestNavigation { get; set; }
        public virtual Tb01011 Tb02013NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02013TranspNavigation { get; set; }
        public virtual ICollection<Tb02014> Tb02014 { get; set; }
    }
}