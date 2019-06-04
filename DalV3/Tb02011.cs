using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02011
    {
        public Tb02011()
        {
            Tb02012 = new HashSet<Tb02012>();
        }

        public DateTime? Tb02011Dtcad { get; set; }
        public string Tb02011Opcad { get; set; }
        public DateTime? Tb02011Dtalt { get; set; }
        public string Tb02011Opalt { get; set; }
        public decimal? Tb02011Baseicms { get; set; }
        public decimal? Tb02011Baseicmssub { get; set; }
        public string Tb02011Codcli { get; set; }
        public string Tb02011Codemp { get; set; }
        public string Tb02011Codigo { get; set; }
        public string Tb02011Condpag { get; set; }
        public DateTime? Tb02011Data { get; set; }
        public decimal? Tb02011Despadd { get; set; }
        public string Tb02011Espercie { get; set; }
        public string Tb02011Marca { get; set; }
        public string Tb02011Nome { get; set; }
        public string Tb02011Ntfisc { get; set; }
        public string Tb02011Numero { get; set; }
        public string Tb02011Obs { get; set; }
        public string Tb02011Obsadd { get; set; }
        public decimal? Tb02011Percdesconto { get; set; }
        public decimal? Tb02011Qtde { get; set; }
        public int? Tb02011Qtvolumes { get; set; }
        public string Tb02011Situacao { get; set; }
        public string Tb02011Transp { get; set; }
        public decimal? Tb02011Vlrbruto { get; set; }
        public decimal? Tb02011Vlrdesconto { get; set; }
        public decimal? Tb02011Vlrfrete { get; set; }
        public decimal? Tb02011Vlricms { get; set; }
        public decimal? Tb02011Vlricmssub { get; set; }
        public decimal? Tb02011Vlripi { get; set; }
        public decimal? Tb02011Vlrnota { get; set; }
        public decimal? Tb02011Vlroutdesp { get; set; }
        public string Tb02011Natureza { get; set; }
        public string Tb02011Fecha { get; set; }
        public string Tb02011Numven { get; set; }
        public string Tb02011Contabil { get; set; }
        public int? Tb02011Tipofrete { get; set; }
        public string Tb02011Placa { get; set; }
        public string Tb02011Ufplaca { get; set; }
        public decimal? Tb02011Pesobruto { get; set; }
        public decimal? Tb02011Pesoliquido { get; set; }
        public DateTime? Tb02011Datanota { get; set; }
        public string Tb02011Horanota { get; set; }
        public string Tb02011Plancon { get; set; }
        public string Tb02011Codcen { get; set; }
        public string Tb02011Codsub { get; set; }
        public string Tb02011Statusrma { get; set; }
        public string Tb02011Rma { get; set; }
        public string Tb02011Tipodev { get; set; }
        public string Tb02011Numorc { get; set; }
        public string Tb02011Numnfe { get; set; }
        public string Tb02011Protocolo { get; set; }
        public string Tb02011Recibo { get; set; }
        public string Tb02011Tipoestoque { get; set; }
        public string Tb02011Somast { get; set; }
        public string Tb02011Locacao { get; set; }
        public string Tb02011Contrato { get; set; }

        public virtual Tb04004 Tb02011CodcenNavigation { get; set; }
        public virtual Tb01008 Tb02011CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02011CodempNavigation { get; set; }
        public virtual Tb04005 Tb02011CodsubNavigation { get; set; }
        public virtual Tb01012 Tb02011CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02011NaturezaNavigation { get; set; }
        public virtual Tb04006 Tb02011PlanconNavigation { get; set; }
        public virtual Tb01041 Tb02011StatusrmaNavigation { get; set; }
        public virtual Tb01009 Tb02011TranspNavigation { get; set; }
        public virtual ICollection<Tb02012> Tb02012 { get; set; }
    }
}