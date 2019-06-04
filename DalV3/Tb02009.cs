using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02009
    {
        public Tb02009()
        {
            Tb02010 = new HashSet<Tb02010>();
        }

        public DateTime? Tb02009Dtcad { get; set; }
        public string Tb02009Opcad { get; set; }
        public DateTime? Tb02009Dtalt { get; set; }
        public string Tb02009Opalt { get; set; }
        public decimal? Tb02009Baseicms { get; set; }
        public decimal? Tb02009Baseicmssub { get; set; }
        public string Tb02009Codemp { get; set; }
        public string Tb02009Codfor { get; set; }
        public string Tb02009Codigo { get; set; }
        public string Tb02009Condpag { get; set; }
        public DateTime? Tb02009Data { get; set; }
        public decimal? Tb02009Despadd { get; set; }
        public string Tb02009Espercie { get; set; }
        public string Tb02009Marca { get; set; }
        public string Tb02009Nome { get; set; }
        public string Tb02009Ntfisc { get; set; }
        public string Tb02009Numero { get; set; }
        public string Tb02009Obs { get; set; }
        public string Tb02009Obsadd { get; set; }
        public decimal? Tb02009Percdesconto { get; set; }
        public decimal? Tb02009Qtde { get; set; }
        public int? Tb02009Qtvolumes { get; set; }
        public string Tb02009Situacao { get; set; }
        public string Tb02009Transp { get; set; }
        public decimal? Tb02009Vlrbruto { get; set; }
        public decimal? Tb02009Vlrdesconto { get; set; }
        public decimal? Tb02009Vlrfrete { get; set; }
        public decimal? Tb02009Vlricms { get; set; }
        public decimal? Tb02009Vlricmssub { get; set; }
        public decimal? Tb02009Vlripi { get; set; }
        public decimal? Tb02009Vlrnota { get; set; }
        public decimal? Tb02009Vlroutdesp { get; set; }
        public string Tb02009Natureza { get; set; }
        public string Tb02009Contabil { get; set; }
        public int? Tb02009Tipofrete { get; set; }
        public string Tb02009Placa { get; set; }
        public string Tb02009Ufplaca { get; set; }
        public decimal? Tb02009Pesobruto { get; set; }
        public decimal? Tb02009Pesoliquido { get; set; }
        public DateTime? Tb02009Datanota { get; set; }
        public string Tb02009Horanota { get; set; }
        public string Tb02009Plancon { get; set; }
        public string Tb02009Codcen { get; set; }
        public string Tb02009Codsub { get; set; }
        public string Tb02009Numcom { get; set; }
        public string Tb02009Rma { get; set; }
        public string Tb02009Numnfe { get; set; }
        public string Tb02009Protocolo { get; set; }
        public string Tb02009Recibo { get; set; }
        public string Tb02009Tipoestoque { get; set; }
        public string Tb02009Somast { get; set; }
        public string Tb02009Garantia { get; set; }

        public virtual Tb04004 Tb02009CodcenNavigation { get; set; }
        public virtual Tb01007 Tb02009CodempNavigation { get; set; }
        public virtual Tb01001 Tb02009CodforNavigation { get; set; }
        public virtual Tb04005 Tb02009CodsubNavigation { get; set; }
        public virtual Tb01012 Tb02009CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02009NaturezaNavigation { get; set; }
        public virtual Tb04006 Tb02009PlanconNavigation { get; set; }
        public virtual Tb01009 Tb02009TranspNavigation { get; set; }
        public virtual ICollection<Tb02010> Tb02010 { get; set; }
    }
}