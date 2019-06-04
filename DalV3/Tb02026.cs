using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02026
    {
        public DateTime? Tb02026Dtcad { get; set; }
        public string Tb02026Opcad { get; set; }
        public DateTime? Tb02026Dtalt { get; set; }
        public string Tb02026Opalt { get; set; }
        public decimal? Tb02026Baseicms { get; set; }
        public decimal? Tb02026Baseicmssub { get; set; }
        public string Tb02026Codcli { get; set; }
        public string Tb02026Codemp { get; set; }
        public string Tb02026Codigo { get; set; }
        public string Tb02026Condpag { get; set; }
        public DateTime? Tb02026Data { get; set; }
        public int? Tb02026Diafatura { get; set; }
        public int? Tb02026Diavenc { get; set; }
        public decimal? Tb02026Despadd { get; set; }
        public string Tb02026Espercie { get; set; }
        public string Tb02026Marca { get; set; }
        public string Tb02026Nome { get; set; }
        public string Tb02026Ntfisc { get; set; }
        public string Tb02026Numero { get; set; }
        public string Tb02026Obs { get; set; }
        public string Tb02026Obsadd { get; set; }
        public decimal? Tb02026Percdesconto { get; set; }
        public decimal? Tb02026Qtde { get; set; }
        public decimal? Tb02026Qtded { get; set; }
        public int? Tb02026Qtdee { get; set; }
        public int? Tb02026Qtdeed { get; set; }
        public decimal? Tb02026Qtdep { get; set; }
        public decimal? Tb02026Qtdepd { get; set; }
        public int? Tb02026Qtvolumes { get; set; }
        public string Tb02026Situacao { get; set; }
        public string Tb02026Transp { get; set; }
        public decimal? Tb02026Vlrbruto { get; set; }
        public decimal? Tb02026Vlrdesconto { get; set; }
        public decimal? Tb02026Vlrfrete { get; set; }
        public decimal? Tb02026Vlricms { get; set; }
        public decimal? Tb02026Vlricmssub { get; set; }
        public decimal? Tb02026Vlripi { get; set; }
        public decimal? Tb02026Vlrnota { get; set; }
        public decimal? Tb02026Vlrnotac { get; set; }
        public decimal? Tb02026Vlrnotad { get; set; }
        public decimal? Tb02026Vlroutdesp { get; set; }
        public string Tb02026Natureza { get; set; }

        public virtual Tb01008 Tb02026CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02026CodempNavigation { get; set; }
        public virtual Tb01014 Tb02026CondpagNavigation { get; set; }
        public virtual Tb01011 Tb02026NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02026TranspNavigation { get; set; }
    }
}