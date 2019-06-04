using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02091
    {
        public Tb02091()
        {
            Tb02092 = new HashSet<Tb02092>();
        }

        public DateTime? Tb02091Dtcad { get; set; }
        public string Tb02091Opcad { get; set; }
        public DateTime? Tb02091Dtalt { get; set; }
        public string Tb02091Opalt { get; set; }
        public decimal? Tb02091Baseicms { get; set; }
        public decimal? Tb02091Baseicmssub { get; set; }
        public string Tb02091Codemp { get; set; }
        public string Tb02091Empdest { get; set; }
        public string Tb02091Codcli { get; set; }
        public string Tb02091Codigo { get; set; }
        public DateTime? Tb02091Data { get; set; }
        public decimal? Tb02091Despadd { get; set; }
        public string Tb02091Espercie { get; set; }
        public string Tb02091Horascom { get; set; }
        public string Tb02091Horasfim { get; set; }
        public string Tb02091Marca { get; set; }
        public string Tb02091Ntfisc { get; set; }
        public string Tb02091Numero { get; set; }
        public string Tb02091Obs { get; set; }
        public string Tb02091Obsadd { get; set; }
        public int? Tb02091Operacao { get; set; }
        public decimal? Tb02091Percdesconto { get; set; }
        public decimal? Tb02091Qtde { get; set; }
        public decimal? Tb02091Qtvolumes { get; set; }
        public string Tb02091Respent { get; set; }
        public string Tb02091Situacao { get; set; }
        public string Tb02091Tipodesc { get; set; }
        public string Tb02091Transp { get; set; }
        public decimal? Tb02091Vlrbruto { get; set; }
        public decimal? Tb02091Vlrdesconto { get; set; }
        public decimal? Tb02091Vlrfrete { get; set; }
        public decimal? Tb02091Vlricms { get; set; }
        public decimal? Tb02091Vlricmssub { get; set; }
        public decimal? Tb02091Vlripi { get; set; }
        public decimal? Tb02091Vlrnota { get; set; }
        public decimal? Tb02091Vlroutdesp { get; set; }
        public string Tb02091Natureza { get; set; }
        public string Tb02091Placa { get; set; }
        public string Tb02091Ufplaca { get; set; }
        public decimal? Tb02091Pesobruto { get; set; }
        public decimal? Tb02091Pesoliquido { get; set; }
        public DateTime? Tb02091Datanota { get; set; }
        public string Tb02091Horanota { get; set; }
        public string Tb02091Contabil { get; set; }
        public int? Tb02091Tipofrete { get; set; }
        public string Tb02091Serie { get; set; }
        public string Tb02091Subserie { get; set; }
        public string Tb02091Estoque { get; set; }
        public string Tb02091Codigo2 { get; set; }
        public string Tb02091Condpag { get; set; }
        public string Tb02091Codfor { get; set; }
        public string Tb02091Nomecfop { get; set; }
        public string Tb02091Complicms { get; set; }
        public string Tb02091Vendacons { get; set; }
        public decimal? Tb02091Vlrdescacu { get; set; }
        public decimal? Tb02091Vlrover { get; set; }
        public decimal? Tb02091Vlrimpostos { get; set; }
        public decimal? Tb02091Vlrseguro { get; set; }
        public decimal? Tb02091Vlrfrete2 { get; set; }
        public decimal? Tb02091Vlroutdesp2 { get; set; }
        public string Tb02091Ntfisc2 { get; set; }
        public string Tb02091Recibo { get; set; }
        public string Tb02091Protocolo { get; set; }
        public DateTime? Tb02091Datacanc { get; set; }
        public string Tb02091Usercanc { get; set; }
        public string Tb02091Numnfe { get; set; }
        public string Tb02091Bonif { get; set; }
        public string Tb02091Nestoque { get; set; }
        public string Tb02091Tipoestoque { get; set; }
        public string Tb02091Modelo { get; set; }
        public string Tb02091Somast { get; set; }
        public decimal? Tb02091Vlrserv { get; set; }
        public int? Tb02091Qtserv { get; set; }
        public decimal? Tb02091Vlriss { get; set; }
        public decimal? Tb02091Vlrretiss { get; set; }
        public string Tb02091Denegada { get; set; }
        public string Tb02091Devcupom { get; set; }
        public string Tb02091Tipoend { get; set; }
        public decimal? Tb02091Vlrdifaliq { get; set; }
        public decimal? Tb02091Vlricmsint { get; set; }
        public decimal? Tb02091Vlricmsext { get; set; }
        public decimal? Tb02091Vlricmsfcp { get; set; }
        public string Tb02091Numnferef { get; set; }
        public string Tb02091Locacao { get; set; }
        public string Tb02091Obsfisco { get; set; }
        public decimal? Tb02091Basefcptot { get; set; }
        public decimal? Tb02091Vlrfcptot { get; set; }
        public decimal? Tb02091Basefcptotst { get; set; }
        public decimal? Tb02091Vlrfcptotst { get; set; }
        public int? Tb02091Indpres { get; set; }
        public int? Tb02091Tipoxml { get; set; }

        public virtual Tb01008 Tb02091CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02091CodempNavigation { get; set; }
        public virtual Tb01007 Tb02091EmpdestNavigation { get; set; }
        public virtual Tb01011 Tb02091NaturezaNavigation { get; set; }
        public virtual Tb01009 Tb02091TranspNavigation { get; set; }
        public virtual ICollection<Tb02092> Tb02092 { get; set; }
    }
}