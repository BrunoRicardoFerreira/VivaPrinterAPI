using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02075
    {
        public Tb02075()
        {
            Tb02076 = new HashSet<Tb02076>();
        }

        public DateTime? Tb02075Dtcad { get; set; }
        public string Tb02075Opcad { get; set; }
        public DateTime? Tb02075Dtalt { get; set; }
        public string Tb02075Opalt { get; set; }
        public decimal? Tb02075Baseicms { get; set; }
        public decimal? Tb02075Baseicmssub { get; set; }
        public string Tb02075Codemp { get; set; }
        public string Tb02075Codigo { get; set; }
        public string Tb02075Condpag { get; set; }
        public DateTime? Tb02075Data { get; set; }
        public decimal? Tb02075Despadd { get; set; }
        public string Tb02075Empdest { get; set; }
        public string Tb02075Espercie { get; set; }
        public string Tb02075Marca { get; set; }
        public string Tb02075Nome { get; set; }
        public string Tb02075Ntfisc { get; set; }
        public string Tb02075Numero { get; set; }
        public string Tb02075Obs { get; set; }
        public string Tb02075Obsadd { get; set; }
        public decimal? Tb02075Percdesconto { get; set; }
        public decimal? Tb02075Qtde { get; set; }
        public int? Tb02075Qtvolumes { get; set; }
        public string Tb02075Situacao { get; set; }
        public string Tb02075Transp { get; set; }
        public decimal? Tb02075Vlrbruto { get; set; }
        public decimal? Tb02075Vlrdesconto { get; set; }
        public decimal? Tb02075Vlrfrete { get; set; }
        public decimal? Tb02075Vlricms { get; set; }
        public decimal? Tb02075Vlricmssub { get; set; }
        public decimal? Tb02075Vlripi { get; set; }
        public decimal? Tb02075Vlrnota { get; set; }
        public decimal? Tb02075Vlroutdesp { get; set; }
        public string Tb02075Natureza { get; set; }
        public string Tb02075Contabil { get; set; }
        public int? Tb02075Tipofrete { get; set; }
        public string Tb02075Placa { get; set; }
        public string Tb02075Ufplaca { get; set; }
        public decimal? Tb02075Pesobruto { get; set; }
        public decimal? Tb02075Pesoliquido { get; set; }
        public DateTime? Tb02075Datanota { get; set; }
        public string Tb02075Horanota { get; set; }
        public string Tb02075Numtrans { get; set; }

        public virtual Tb01007 Tb02075CodempNavigation { get; set; }
        public virtual Tb01012 Tb02075CondpagNavigation { get; set; }
        public virtual Tb01007 Tb02075EmpdestNavigation { get; set; }
        public virtual Tb01011 Tb02075NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02075TranspNavigation { get; set; }
        public virtual ICollection<Tb02076> Tb02076 { get; set; }
    }
}