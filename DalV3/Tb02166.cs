using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02166
    {
        public Tb02166()
        {
            Tb02167 = new HashSet<Tb02167>();
            Tb02168 = new HashSet<Tb02168>();
        }

        public DateTime? Tb02166Dtcad { get; set; }
        public string Tb02166Opcad { get; set; }
        public DateTime? Tb02166Dtalt { get; set; }
        public string Tb02166Opalt { get; set; }
        public decimal? Tb02166Baseicms { get; set; }
        public decimal? Tb02166Baseicmssub { get; set; }
        public string Tb02166Codemp { get; set; }
        public string Tb02166Codigo { get; set; }
        public string Tb02166Codcli { get; set; }
        public string Tb02166Codmoto { get; set; }
        public string Tb02166Vend { get; set; }
        public string Tb02166Condpag { get; set; }
        public string Tb02166Status { get; set; }
        public int? Tb02166Operacao { get; set; }
        public DateTime? Tb02166Data { get; set; }
        public DateTime? Tb02166Dtent { get; set; }
        public decimal? Tb02166Despadd { get; set; }
        public string Tb02166Espercie { get; set; }
        public string Tb02166Marca { get; set; }
        public string Tb02166Ntfisc { get; set; }
        public string Tb02166Nome { get; set; }
        public string Tb02166Numero { get; set; }
        public string Tb02166Obs { get; set; }
        public string Tb02166Obsadd { get; set; }
        public decimal? Tb02166Percdesconto { get; set; }
        public decimal? Tb02166Qtde { get; set; }
        public int? Tb02166Qtvolumes { get; set; }
        public string Tb02166Situacao { get; set; }
        public string Tb02166Transp { get; set; }
        public decimal? Tb02166Vlrbruto { get; set; }
        public decimal? Tb02166Vlrdesconto { get; set; }
        public decimal? Tb02166Vlrfrete { get; set; }
        public decimal? Tb02166Vlricms { get; set; }
        public decimal? Tb02166Vlricmssub { get; set; }
        public decimal? Tb02166Vlripi { get; set; }
        public decimal? Tb02166Vlrnota { get; set; }
        public decimal? Tb02166Vlroutdesp { get; set; }
        public string Tb02166Natureza { get; set; }
        public string Tb02166Contabil { get; set; }
        public int? Tb02166Tipofrete { get; set; }
        public string Tb02166Placa { get; set; }
        public string Tb02166Ufplaca { get; set; }
        public decimal? Tb02166Pesobruto { get; set; }
        public decimal? Tb02166Pesoliquido { get; set; }
        public DateTime? Tb02166Datanota { get; set; }
        public string Tb02166Horanota { get; set; }
        public DateTime? Tb02166Dtproducao { get; set; }
        public DateTime? Tb02166Dtfaturamento { get; set; }
        public string Tb02166Ajmaterial { get; set; }
        public string Tb02166Ajproduto { get; set; }
        public string Tb02166Pedproduto { get; set; }
        public string Tb02166Pedservico { get; set; }

        public virtual Tb01008 Tb02166CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02166CodempNavigation { get; set; }
        public virtual Tb01014 Tb02166CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02166NaturezaNavigation { get; set; }
        public virtual Tb01085 Tb02166StatusNavigation { get; set; }
        public virtual Tb01009 Tb02166TranspNavigation { get; set; }
        public virtual Tb01006 Tb02166VendNavigation { get; set; }
        public virtual ICollection<Tb02167> Tb02167 { get; set; }
        public virtual ICollection<Tb02168> Tb02168 { get; set; }
    }
}