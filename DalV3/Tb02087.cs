using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02087
    {
        public DateTime? Tb02087Dtcad { get; set; }
        public string Tb02087Opcad { get; set; }
        public DateTime? Tb02087Dtalt { get; set; }
        public string Tb02087Opalt { get; set; }
        public string Tb02087Codigo { get; set; }
        public DateTime? Tb02087Data { get; set; }
        public int? Tb02087Pgto { get; set; }
        public decimal? Tb02087Peso { get; set; }
        public decimal? Tb02087Pesoliquido { get; set; }
        public decimal? Tb02087Cubagem { get; set; }
        public string Tb02087Ntfisc { get; set; }
        public decimal? Tb02087Vlrnota { get; set; }
        public int? Tb02087Qtvolume { get; set; }
        public string Tb02087Especie { get; set; }
        public string Tb02087Etiqueta { get; set; }
        public string Tb02087Previagem { get; set; }
        public DateTime? Tb02087Dtagenda { get; set; }
        public string Tb02087Usuario { get; set; }
        public int? Tb02087Frota { get; set; }
        public int? Tb02087Rota { get; set; }
        public string Tb02087Codfor { get; set; }
        public string Tb02087Codemp { get; set; }
        public string Tb02087Obs { get; set; }
        public decimal? Tb02087Vlrpeso { get; set; }
        public decimal? Tb02087Sefaz { get; set; }
        public decimal? Tb02087Nord { get; set; }
        public decimal? Tb02087Fvalor { get; set; }
        public decimal? Tb02087Cat { get; set; }
        public decimal? Tb02087Desp { get; set; }
        public decimal? Tb02087Itr { get; set; }
        public decimal? Tb02087Gris { get; set; }
        public decimal? Tb02087Pedagio { get; set; }
        public decimal? Tb02087Suframa { get; set; }
        public decimal? Tb02087Icms { get; set; }
        public decimal? Tb02087Vlricms { get; set; }
        public decimal? Tb02087Vlrserv { get; set; }
        public string Tb02087Transp { get; set; }
        public string Tb02087Natureza { get; set; }
        public string Tb02087Codcli { get; set; }
        public string Tb02087Operacao { get; set; }
        public string Tb02087Financeiro { get; set; }
        public string Tb02087Codcen { get; set; }
        public string Tb02087Codsub { get; set; }
        public string Tb02087Plancon { get; set; }
        public string Tb02087Cst { get; set; }
        public decimal? Tb02087Pis { get; set; }
        public string Tb02087Cstpis { get; set; }
        public decimal? Tb02087Cofins { get; set; }
        public string Tb02087Cstcofins { get; set; }
        public int? Tb02087Tipocon { get; set; }
        public string Tb02087Placa { get; set; }
        public string Tb02087Ufplaca { get; set; }
        public DateTime Tb02087Dtentsai { get; set; }
        public decimal? Tb02087Base { get; set; }
        public string Tb02087Tipotrans { get; set; }
        public string Tb02087Numcte { get; set; }
        public decimal? Tb02087Vlrpis { get; set; }
        public decimal? Tb02087Vlrcofins { get; set; }
        public string Tb02087TipoDocumento { get; set; }
        public decimal? Tb02087Csll { get; set; }
        public decimal? Tb02087Vlrcsll { get; set; }
        public string Tb02087Retpis { get; set; }
        public string Tb02087Retcofins { get; set; }
        public string Tb02087Retcsll { get; set; }
        public decimal? Tb02087Munorigem { get; set; }
        public decimal? Tb02087Mundestino { get; set; }
        public string Tb02087Nfreferencia { get; set; }
        public DateTime? Tb02087Dtreferencia { get; set; }
        public decimal? Tb02087Vlrfretereferencia { get; set; }
        public decimal? Tb02087Outros { get; set; }
        public decimal? Tb02087Pesocubado { get; set; }
        public string Tb02087Veiculo { get; set; }
        public decimal? Tb02087Despacho { get; set; }
        public string Tb02087Serie { get; set; }

        public virtual Tb04004 Tb02087CodcenNavigation { get; set; }
        public virtual Tb01008 Tb02087CodcliNavigation { get; set; }
        public virtual Tb01007 Tb02087CodempNavigation { get; set; }
        public virtual Tb01001 Tb02087CodforNavigation { get; set; }
        public virtual Tb04005 Tb02087CodsubNavigation { get; set; }
        public virtual Tb01051 Tb02087CstNavigation { get; set; }
        public virtual Tb01053 Tb02087CstcofinsNavigation { get; set; }
        public virtual Tb01052 Tb02087CstpisNavigation { get; set; }
        public virtual Tb01011 Tb02087NaturezaNavigation { get; set; }
        public virtual Tb04006 Tb02087PlanconNavigation { get; set; }
        public virtual Tb04001 Tb02087TipoDocumentoNavigation { get; set; }
        public virtual Tb01009 Tb02087TranspNavigation { get; set; }
    }
}