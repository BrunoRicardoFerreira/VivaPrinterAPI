using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02144
    {
        public Tb02144()
        {
            Tb02145 = new HashSet<Tb02145>();
        }

        public DateTime? Tb02144Dtcad { get; set; }
        public string Tb02144Opcad { get; set; }
        public DateTime? Tb02144Dtalt { get; set; }
        public string Tb02144Opalt { get; set; }
        public decimal? Tb02144Baseicms { get; set; }
        public decimal? Tb02144Baseicmssub { get; set; }
        public string Tb02144Codcli { get; set; }
        public string Tb02144Codemp { get; set; }
        public string Tb02144Codigo { get; set; }
        public string Tb02144Condpag { get; set; }
        public DateTime? Tb02144Data { get; set; }
        public decimal? Tb02144Despadd { get; set; }
        public string Tb02144Espercie { get; set; }
        public string Tb02144Marca { get; set; }
        public string Tb02144Nome { get; set; }
        public string Tb02144Ntfisc { get; set; }
        public string Tb02144Numero { get; set; }
        public string Tb02144Obs { get; set; }
        public string Tb02144Obsadd { get; set; }
        public decimal? Tb02144Percdesconto { get; set; }
        public decimal? Tb02144Qtde { get; set; }
        public int? Tb02144Qtvolumes { get; set; }
        public string Tb02144Situacao { get; set; }
        public string Tb02144Transp { get; set; }
        public decimal? Tb02144Vlrbruto { get; set; }
        public decimal? Tb02144Vlrdesconto { get; set; }
        public decimal? Tb02144Vlrfrete { get; set; }
        public decimal? Tb02144Vlricms { get; set; }
        public decimal? Tb02144Vlricmssub { get; set; }
        public decimal? Tb02144Vlripi { get; set; }
        public decimal? Tb02144Vlrnota { get; set; }
        public decimal? Tb02144Vlroutdesp { get; set; }
        public string Tb02144Natureza { get; set; }
        public string Tb02144Contabil { get; set; }
        public int? Tb02144Tipofrete { get; set; }
        public string Tb02144Placa { get; set; }
        public string Tb02144Ufplaca { get; set; }
        public decimal? Tb02144Pesobruto { get; set; }
        public decimal? Tb02144Pesoliquido { get; set; }
        public DateTime? Tb02144Datanota { get; set; }
        public string Tb02144Horanota { get; set; }

        public virtual Tb01008 Tb02144CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02144CodempNavigation { get; set; }
        public virtual Tb01012 Tb02144CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02144NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02144TranspNavigation { get; set; }
        public virtual ICollection<Tb02145> Tb02145 { get; set; }
    }
}