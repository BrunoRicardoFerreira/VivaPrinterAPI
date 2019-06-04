using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02050
    {
        public Tb02050()
        {
            Tb02051 = new HashSet<Tb02051>();
            Tb02052 = new HashSet<Tb02052>();
        }

        public DateTime? Tb02050Dtcad { get; set; }
        public string Tb02050Opcad { get; set; }
        public DateTime? Tb02050Dtalt { get; set; }
        public string Tb02050Opalt { get; set; }
        public decimal? Tb02050Baseicms { get; set; }
        public decimal? Tb02050Baseicmssub { get; set; }
        public string Tb02050Codcli { get; set; }
        public string Tb02050Codemp { get; set; }
        public string Tb02050Codigo { get; set; }
        public string Tb02050Codtec { get; set; }
        public string Tb02050Condpag { get; set; }
        public DateTime? Tb02050Data { get; set; }
        public DateTime? Tb02050Data2 { get; set; }
        public decimal? Tb02050Despadd { get; set; }
        public string Tb02050Espercie { get; set; }
        public string Tb02050Marca { get; set; }
        public string Tb02050Nome { get; set; }
        public string Tb02050Ntfisc { get; set; }
        public string Tb02050Numero { get; set; }
        public string Tb02050Obs { get; set; }
        public string Tb02050Obsadd { get; set; }
        public decimal? Tb02050Percdesconto { get; set; }
        public decimal? Tb02050Qtde { get; set; }
        public decimal? Tb02050Qtde2 { get; set; }
        public int? Tb02050Qtvolumes { get; set; }
        public string Tb02050Situacao { get; set; }
        public string Tb02050Transp { get; set; }
        public decimal? Tb02050Vlrbruto { get; set; }
        public decimal? Tb02050Vlrdesconto { get; set; }
        public decimal? Tb02050Vlrfrete { get; set; }
        public decimal? Tb02050Vlricms { get; set; }
        public decimal? Tb02050Vlricmssub { get; set; }
        public decimal? Tb02050Vlripi { get; set; }
        public decimal? Tb02050Vlrnota { get; set; }
        public decimal? Tb02050Vlrnota2 { get; set; }
        public decimal? Tb02050Vlroutdesp { get; set; }
        public string Tb02050Natureza { get; set; }
        public string Tb02050Contabil { get; set; }
        public int? Tb02050Tipofrete { get; set; }
        public string Tb02050Placa { get; set; }
        public string Tb02050Ufplaca { get; set; }
        public decimal? Tb02050Pesobruto { get; set; }
        public decimal? Tb02050Pesoliquido { get; set; }
        public DateTime? Tb02050Datanota { get; set; }
        public string Tb02050Horanota { get; set; }
        public string Tb02050Tipoestoque { get; set; }

        public virtual Tb01008 Tb02050CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02050CodempNavigation { get; set; }
        public virtual Tb01024 Tb02050CodtecNavigation { get; set; }
        public virtual Tb01012 Tb02050CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02050NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02050TranspNavigation { get; set; }
        public virtual ICollection<Tb02051> Tb02051 { get; set; }
        public virtual ICollection<Tb02052> Tb02052 { get; set; }
    }
}