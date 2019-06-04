using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02007
    {
        public Tb02007()
        {
            Tb02008 = new HashSet<Tb02008>();
        }

        public DateTime? Tb02007Dtcad { get; set; }
        public string Tb02007Opcad { get; set; }
        public DateTime? Tb02007Dtalt { get; set; }
        public string Tb02007Opalt { get; set; }
        public decimal? Tb02007Baseicms { get; set; }
        public decimal? Tb02007Baseicmssub { get; set; }
        public string Tb02007Codemp { get; set; }
        public string Tb02007Codigo { get; set; }
        public string Tb02007Condpag { get; set; }
        public DateTime? Tb02007Data { get; set; }
        public decimal? Tb02007Despadd { get; set; }
        public string Tb02007Espercie { get; set; }
        public string Tb02007Marca { get; set; }
        public string Tb02007Ntfisc { get; set; }
        public string Tb02007Nome { get; set; }
        public string Tb02007Numero { get; set; }
        public string Tb02007Obs { get; set; }
        public string Tb02007Obsadd { get; set; }
        public decimal? Tb02007Percdesconto { get; set; }
        public decimal? Tb02007Qtde { get; set; }
        public int? Tb02007Qtvolumes { get; set; }
        public string Tb02007Situacao { get; set; }
        public string Tb02007Transp { get; set; }
        public decimal? Tb02007Vlrbruto { get; set; }
        public decimal? Tb02007Vlrdesconto { get; set; }
        public decimal? Tb02007Vlrfrete { get; set; }
        public decimal? Tb02007Vlricms { get; set; }
        public decimal? Tb02007Vlricmssub { get; set; }
        public decimal? Tb02007Vlripi { get; set; }
        public decimal? Tb02007Vlrnota { get; set; }
        public decimal? Tb02007Vlroutdesp { get; set; }
        public string Tb02007Natureza { get; set; }
        public string Tb02007Contabil { get; set; }
        public int? Tb02007Tipofrete { get; set; }
        public string Tb02007Placa { get; set; }
        public string Tb02007Ufplaca { get; set; }
        public decimal? Tb02007Pesobruto { get; set; }
        public decimal? Tb02007Pesoliquido { get; set; }
        public DateTime? Tb02007Datanota { get; set; }
        public string Tb02007Horanota { get; set; }
        public string Tb02007Rma { get; set; }
        public string Tb02007Upd { get; set; }
        public string Tb02007K280 { get; set; }
        public string Tb02007Mesk280 { get; set; }
        public DateTime? Tb02007Datak280 { get; set; }

        public virtual Tb01007 Tb02007CodempNavigation { get; set; }
        public virtual Tb01012 Tb02007CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02007NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02007TranspNavigation { get; set; }
        public virtual ICollection<Tb02008> Tb02008 { get; set; }
    }
}