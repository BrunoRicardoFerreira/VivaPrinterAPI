using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02077
    {
        public Tb02077()
        {
            Tb02078 = new HashSet<Tb02078>();
        }

        public DateTime? Tb02077Dtcad { get; set; }
        public string Tb02077Opcad { get; set; }
        public DateTime? Tb02077Dtalt { get; set; }
        public string Tb02077Opalt { get; set; }
        public decimal? Tb02077Baseicms { get; set; }
        public decimal? Tb02077Baseicmssub { get; set; }
        public string Tb02077Codemp { get; set; }
        public string Tb02077Codigo { get; set; }
        public string Tb02077Condpag { get; set; }
        public DateTime? Tb02077Data { get; set; }
        public decimal? Tb02077Despadd { get; set; }
        public string Tb02077Empdest { get; set; }
        public string Tb02077Espercie { get; set; }
        public string Tb02077Marca { get; set; }
        public string Tb02077Nome { get; set; }
        public string Tb02077Ntfisc { get; set; }
        public string Tb02077Numero { get; set; }
        public string Tb02077Obs { get; set; }
        public string Tb02077Obsadd { get; set; }
        public decimal? Tb02077Percdesconto { get; set; }
        public decimal? Tb02077Qtde { get; set; }
        public int? Tb02077Qtvolumes { get; set; }
        public string Tb02077Situacao { get; set; }
        public string Tb02077Transp { get; set; }
        public decimal? Tb02077Vlrbruto { get; set; }
        public decimal? Tb02077Vlrdesconto { get; set; }
        public decimal? Tb02077Vlrfrete { get; set; }
        public decimal? Tb02077Vlricms { get; set; }
        public decimal? Tb02077Vlricmssub { get; set; }
        public decimal? Tb02077Vlripi { get; set; }
        public decimal? Tb02077Vlrnota { get; set; }
        public decimal? Tb02077Vlroutdesp { get; set; }
        public string Tb02077Natureza { get; set; }
        public string Tb02077Contabil { get; set; }
        public int? Tb02077Tipofrete { get; set; }
        public string Tb02077Placa { get; set; }
        public string Tb02077Ufplaca { get; set; }
        public decimal? Tb02077Pesobruto { get; set; }
        public decimal? Tb02077Pesoliquido { get; set; }
        public DateTime? Tb02077Datanota { get; set; }
        public string Tb02077Horanota { get; set; }
        public string Tb02077Numtrans { get; set; }

        public virtual Tb01007 Tb02077CodempNavigation { get; set; }
        public virtual Tb01012 Tb02077CondpagNavigation { get; set; }
        public virtual Tb01007 Tb02077EmpdestNavigation { get; set; }
        public virtual Tb01011 Tb02077NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02077TranspNavigation { get; set; }
        public virtual ICollection<Tb02078> Tb02078 { get; set; }
    }
}