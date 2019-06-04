using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02048
    {
        public Tb02048()
        {
            Tb02049 = new HashSet<Tb02049>();
        }

        public DateTime? Tb02048Dtcad { get; set; }
        public string Tb02048Opcad { get; set; }
        public DateTime? Tb02048Dtalt { get; set; }
        public string Tb02048Opalt { get; set; }
        public decimal? Tb02048Baseicms { get; set; }
        public decimal? Tb02048Baseicmssub { get; set; }
        public string Tb02048Codemp { get; set; }
        public string Tb02048Codigo { get; set; }
        public string Tb02048Condpag { get; set; }
        public DateTime? Tb02048Data { get; set; }
        public decimal? Tb02048Despadd { get; set; }
        public string Tb02048Espercie { get; set; }
        public string Tb02048Forncodigo { get; set; }
        public string Tb02048Fornnome { get; set; }
        public string Tb02048Grupocodigo { get; set; }
        public string Tb02048Gruponome { get; set; }
        public string Tb02048Localcodigo { get; set; }
        public string Tb02048Localnome { get; set; }
        public string Tb02048Marca { get; set; }
        public string Tb02048Ntfisc { get; set; }
        public string Tb02048Nome { get; set; }
        public string Tb02048Numero { get; set; }
        public string Tb02048Obs { get; set; }
        public string Tb02048Obsadd { get; set; }
        public decimal? Tb02048Percdesconto { get; set; }
        public decimal? Tb02048Qtde { get; set; }
        public int? Tb02048Qtvolumes { get; set; }
        public string Tb02048Situacao { get; set; }
        public string Tb02048Subgrupocodigo { get; set; }
        public string Tb02048Subgruponome { get; set; }
        public string Tb02048Transp { get; set; }
        public decimal? Tb02048Vlrbruto { get; set; }
        public decimal? Tb02048Vlrdesconto { get; set; }
        public decimal? Tb02048Vlrfrete { get; set; }
        public decimal? Tb02048Vlricms { get; set; }
        public decimal? Tb02048Vlricmssub { get; set; }
        public decimal? Tb02048Vlripi { get; set; }
        public decimal? Tb02048Vlrnota { get; set; }
        public decimal? Tb02048Vlroutdesp { get; set; }
        public string Tb02048Natureza { get; set; }
        public DateTime? Tb02048Dtbalanco { get; set; }
        public string Tb02048Contabil { get; set; }
        public int? Tb02048Tipofrete { get; set; }
        public string Tb02048Placa { get; set; }
        public string Tb02048Ufplaca { get; set; }
        public decimal? Tb02048Pesobruto { get; set; }
        public decimal? Tb02048Pesoliquido { get; set; }
        public DateTime? Tb02048Datanota { get; set; }
        public string Tb02048Horanota { get; set; }
        public int? Tb02048Tipoestoque { get; set; }

        public virtual Tb01007 Tb02048CodempNavigation { get; set; }
        public virtual Tb01012 Tb02048CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02048NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02048TranspNavigation { get; set; }
        public virtual ICollection<Tb02049> Tb02049 { get; set; }
    }
}