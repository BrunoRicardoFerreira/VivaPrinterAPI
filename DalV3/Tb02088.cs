using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02088
    {
        public DateTime? Tb02088Dtcad { get; set; }
        public string Tb02088Opcad { get; set; }
        public DateTime? Tb02088Dtalt { get; set; }
        public string Tb02088Opalt { get; set; }
        public decimal? Tb02088Baseicms { get; set; }
        public decimal? Tb02088Baseicmssub { get; set; }
        public string Tb02088Codemp { get; set; }
        public string Tb02088Prest { get; set; }
        public string Tb02088Codigo { get; set; }
        public string Tb02088Condpag { get; set; }
        public DateTime? Tb02088Data { get; set; }
        public decimal? Tb02088Despadd { get; set; }
        public string Tb02088Espercie { get; set; }
        public string Tb02088Marca { get; set; }
        public string Tb02088Nome { get; set; }
        public string Tb02088Ntfisc { get; set; }
        public string Tb02088Numero { get; set; }
        public string Tb02088Obs { get; set; }
        public string Tb02088Obsadd { get; set; }
        public decimal? Tb02088Percdesconto { get; set; }
        public decimal? Tb02088Qtde { get; set; }
        public int? Tb02088Qtvolumes { get; set; }
        public string Tb02088Situacao { get; set; }
        public string Tb02088Transp { get; set; }
        public decimal? Tb02088Vlrbruto { get; set; }
        public decimal? Tb02088Vlrdesconto { get; set; }
        public decimal? Tb02088Vlrfrete { get; set; }
        public decimal? Tb02088Vlricms { get; set; }
        public decimal? Tb02088Vlricmssub { get; set; }
        public decimal? Tb02088Vlripi { get; set; }
        public decimal? Tb02088Vlrnota { get; set; }
        public decimal? Tb02088Vlrimpostos { get; set; }
        public decimal? Tb02088Vlroutdesp { get; set; }
        public string Tb02088Natureza { get; set; }
        public string Tb02088Contabil { get; set; }
        public int? Tb02088Tipofrete { get; set; }
        public string Tb02088Placa { get; set; }
        public string Tb02088Ufplaca { get; set; }
        public decimal? Tb02088Pesobruto { get; set; }
        public decimal? Tb02088Pesoliquido { get; set; }
        public DateTime? Tb02088Datanota { get; set; }
        public string Tb02088Horanota { get; set; }
        public string Tb02088Sped { get; set; }
        public decimal? Tb02088Basepis { get; set; }
        public decimal? Tb02088Basecofins { get; set; }
        public decimal? Tb02088Vlrpis { get; set; }
        public decimal? Tb02088Vlrcofins { get; set; }
        public decimal? Tb02088Vlriss { get; set; }
        public string Tb02088Nfse { get; set; }
        public string Tb02088Retpis { get; set; }
        public string Tb02088Retcofins { get; set; }
        public string Tb02088Retcsll { get; set; }
        public string Tb02088Retir { get; set; }
        public string Tb02088Retiss { get; set; }
        public decimal? Tb02088Vlrcsll { get; set; }
        public decimal? Tb02088Vlrir { get; set; }
        public decimal? Tb02088Vlrretpis { get; set; }
        public decimal? Tb02088Vlrretcofins { get; set; }
        public decimal? Tb02088Vlrretcsll { get; set; }
        public decimal? Tb02088Vlrretir { get; set; }
        public decimal? Tb02088Vlrretiss { get; set; }
        public string Tb02088Codcen { get; set; }
        public string Tb02088Codsub { get; set; }
        public string Tb02088Plancon { get; set; }
        public string Tb02088Retinss { get; set; }
        public decimal? Tb02088Vlrretinss { get; set; }
        public decimal? Tb02088Vlrinss { get; set; }

        public virtual Tb04004 Tb02088CodcenNavigation { get; set; }
        public virtual Tb01007 Tb02088CodempNavigation { get; set; }
        public virtual Tb04005 Tb02088CodsubNavigation { get; set; }
        public virtual Tb01012 Tb02088CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02088NaturezaNavigation { get; set; }
        public virtual Tb04006 Tb02088PlanconNavigation { get; set; }
        public virtual Tb01017 Tb02088PrestNavigation { get; set; }
        public virtual Tb01009 Tb02088TranspNavigation { get; set; }
    }
}