using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02118
    {
        public DateTime? Tb02118Dtcad { get; set; }
        public string Tb02118Opcad { get; set; }
        public DateTime? Tb02118Dtalt { get; set; }
        public string Tb02118Opalt { get; set; }
        public decimal? Tb02118Baseicms { get; set; }
        public decimal? Tb02118Baseicmssub { get; set; }
        public string Tb02118Codcli { get; set; }
        public string Tb02118Codemp { get; set; }
        public string Tb02118Codigo { get; set; }
        public string Tb02118Condpag { get; set; }
        public DateTime? Tb02118Data { get; set; }
        public decimal? Tb02118Despadd { get; set; }
        public string Tb02118Espercie { get; set; }
        public string Tb02118Marca { get; set; }
        public string Tb02118Ntfisc { get; set; }
        public string Tb02118Nome { get; set; }
        public string Tb02118Numero { get; set; }
        public string Tb02118Obs { get; set; }
        public string Tb02118Obsadd { get; set; }
        public decimal? Tb02118Percdesconto { get; set; }
        public decimal? Tb02118Qtde { get; set; }
        public int? Tb02118Qtvolumes { get; set; }
        public string Tb02118Situacao { get; set; }
        public string Tb02118Transp { get; set; }
        public decimal? Tb02118Vlrbruto { get; set; }
        public decimal? Tb02118Vlrdesconto { get; set; }
        public decimal? Tb02118Vlrfrete { get; set; }
        public decimal? Tb02118Vlricms { get; set; }
        public decimal? Tb02118Vlricmssub { get; set; }
        public decimal? Tb02118Vlripi { get; set; }
        public decimal? Tb02118Vlrnota { get; set; }
        public decimal? Tb02118Vlroutdesp { get; set; }
        public string Tb02118Natureza { get; set; }
        public string Tb02118Contabil { get; set; }
        public int? Tb02118Tipofrete { get; set; }
        public string Tb02118Placa { get; set; }
        public string Tb02118Ufplaca { get; set; }
        public decimal? Tb02118Pesobruto { get; set; }
        public decimal? Tb02118Pesoliquido { get; set; }
        public DateTime? Tb02118Datanota { get; set; }
        public string Tb02118Horanota { get; set; }
        public string Tb02118Vend { get; set; }
        public string Tb02118Retpis { get; set; }
        public string Tb02118Retcofins { get; set; }
        public string Tb02118Retcsll { get; set; }
        public string Tb02118Retir { get; set; }
        public decimal? Tb02118Vlrretpis { get; set; }
        public decimal? Tb02118Vlrretcofins { get; set; }
        public decimal? Tb02118Vlrretcsll { get; set; }
        public decimal? Tb02118Vlrretir { get; set; }
        public string Tb02118Contrato { get; set; }
        public decimal? Tb02118Caucao { get; set; }
        public decimal? Tb02118Vlrcaucao { get; set; }
        public int? Tb02118Lote { get; set; }
        public DateTime? Tb02118Dtent { get; set; }
        public string Tb02118Respent { get; set; }
        public string Tb02118Mes { get; set; }

        public virtual Tb01008 Tb02118CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02118CodempNavigation { get; set; }
        public virtual Tb01014 Tb02118CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02118NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02118TranspNavigation { get; set; }
        public virtual Tb01006 Tb02118VendNavigation { get; set; }
    }
}