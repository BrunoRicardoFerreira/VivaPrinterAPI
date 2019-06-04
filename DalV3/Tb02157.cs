using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02157
    {
        public DateTime? Tb02157Dtcad { get; set; }
        public string Tb02157Opcad { get; set; }
        public DateTime? Tb02157Dtalt { get; set; }
        public string Tb02157Opalt { get; set; }
        public decimal? Tb02157Baseicms { get; set; }
        public decimal? Tb02157Baseicmssub { get; set; }
        public string Tb02157Codemp { get; set; }
        public string Tb02157Empdest { get; set; }
        public string Tb02157Codcli { get; set; }
        public string Tb02157Codigo { get; set; }
        public DateTime? Tb02157Data { get; set; }
        public decimal? Tb02157Despadd { get; set; }
        public string Tb02157Espercie { get; set; }
        public string Tb02157Horascom { get; set; }
        public string Tb02157Horasfim { get; set; }
        public string Tb02157Marca { get; set; }
        public string Tb02157Ntfisc { get; set; }
        public string Tb02157Numero { get; set; }
        public string Tb02157Obs { get; set; }
        public string Tb02157Obsadd { get; set; }
        public int? Tb02157Operacao { get; set; }
        public decimal? Tb02157Percdesconto { get; set; }
        public decimal? Tb02157Qtde { get; set; }
        public decimal? Tb02157Qtvolumes { get; set; }
        public string Tb02157Respent { get; set; }
        public string Tb02157Situacao { get; set; }
        public string Tb02157Tipodesc { get; set; }
        public string Tb02157Transp { get; set; }
        public decimal? Tb02157Vlrbruto { get; set; }
        public decimal? Tb02157Vlrdesconto { get; set; }
        public decimal? Tb02157Vlrfrete { get; set; }
        public decimal? Tb02157Vlricms { get; set; }
        public decimal? Tb02157Vlricmssub { get; set; }
        public decimal? Tb02157Vlripi { get; set; }
        public decimal? Tb02157Vlrnota { get; set; }
        public decimal? Tb02157Vlroutdesp { get; set; }
        public string Tb02157Natureza { get; set; }
        public string Tb02157Placa { get; set; }
        public string Tb02157Ufplaca { get; set; }
        public decimal? Tb02157Pesobruto { get; set; }
        public decimal? Tb02157Pesoliquido { get; set; }
        public DateTime? Tb02157Datanota { get; set; }
        public string Tb02157Horanota { get; set; }
        public string Tb02157Contabil { get; set; }
        public int? Tb02157Tipofrete { get; set; }
        public string Tb02157Serie { get; set; }
        public string Tb02157Subserie { get; set; }
        public string Tb02157Estoque { get; set; }
        public string Tb02157Codigo2 { get; set; }
        public string Tb02157Condpag { get; set; }
        public string Tb02157Codfor { get; set; }
        public string Tb02157Nomecfop { get; set; }
        public string Tb02157Complicms { get; set; }
        public string Tb02157Vendacons { get; set; }
        public decimal? Tb02157Vlrdescacu { get; set; }
        public decimal? Tb02157Vlrover { get; set; }
        public decimal? Tb02157Vlrimpostos { get; set; }
        public decimal? Tb02157Vlrseguro { get; set; }
        public decimal? Tb02157Vlrfrete2 { get; set; }
        public decimal? Tb02157Vlroutdesp2 { get; set; }
        public string Tb02157Ntfisc2 { get; set; }
        public string Tb02157Recibo { get; set; }
        public string Tb02157Protocolo { get; set; }
        public DateTime? Tb02157Datacanc { get; set; }
        public string Tb02157Usercanc { get; set; }
        public string Tb02157Numnfe { get; set; }
        public string Tb02157Bonif { get; set; }
        public string Tb02157Nestoque { get; set; }
        public string Tb02157Tipoestoque { get; set; }
        public string Tb02157Modelo { get; set; }
        public string Tb02157Somast { get; set; }
        public decimal? Tb02157Vlrserv { get; set; }
        public int? Tb02157Qtserv { get; set; }
        public decimal? Tb02157Vlriss { get; set; }
        public decimal? Tb02157Vlrretiss { get; set; }
        public string Tb02157Denegada { get; set; }

        public virtual Tb01008 Tb02157CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02157CodempNavigation { get; set; }
        public virtual Tb01007 Tb02157EmpdestNavigation { get; set; }
        public virtual Tb01011 Tb02157NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02157TranspNavigation { get; set; }
    }
}