using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04014
    {
        public DateTime? Tb04014Dtcad { get; set; }
        public string Tb04014Opcad { get; set; }
        public DateTime? Tb04014Dtalt { get; set; }
        public string Tb04014Opalt { get; set; }
        public string Tb04014Codcen { get; set; }
        public string Tb04014Codemp { get; set; }
        public string Tb04014Codfor { get; set; }
        public string Tb04014Codigo { get; set; }
        public string Tb04014Codigo2 { get; set; }
        public string Tb04014Codsub { get; set; }
        public DateTime? Tb04014Data { get; set; }
        public DateTime? Tb04014Dtvenc { get; set; }
        public string Tb04014Nome { get; set; }
        public string Tb04014Obs { get; set; }
        public int? Tb04014Operacao { get; set; }
        public string Tb04014Prest { get; set; }
        public string Tb04014Situacao { get; set; }
        public string Tb04014Tipdoc { get; set; }
        public decimal? Tb04014Vlracres { get; set; }
        public decimal? Tb04014Vlrbruto { get; set; }
        public decimal? Tb04014Vlrdesconto { get; set; }
        public decimal? Tb04014Vlrtitulo { get; set; }
        public decimal? Tb04014Vlrpago { get; set; }
        public string Tb04014Transp { get; set; }
        public int? Tb04014Contpag { get; set; }
        public string Tb04014Provisao { get; set; }
        public string Tb04014Plancon { get; set; }
        public string Tb04014Parcial { get; set; }
        public int? Tb04014Tipotitulo { get; set; }
        public string Tb04014Ntfisc { get; set; }
        public string Tb04014Mes { get; set; }
        public int? Tb04014Diasatraso { get; set; }
        public DateTime? Tb04014Dtentrada { get; set; }
        public decimal? Tb04014Vlrmov { get; set; }
        public string Tb04014Status { get; set; }

        public virtual Tb04004 Tb04014CodcenNavigation { get; set; }
        public virtual Tb01007 Tb04014CodempNavigation { get; set; }
        public virtual Tb01001 Tb04014CodforNavigation { get; set; }
        public virtual Tb04005 Tb04014CodsubNavigation { get; set; }
        public virtual Tb04006 Tb04014PlanconNavigation { get; set; }
        public virtual Tb01017 Tb04014PrestNavigation { get; set; }
        public virtual Tb01102 Tb04014StatusNavigation { get; set; }
        public virtual Tb04001 Tb04014TipdocNavigation { get; set; }
        public virtual Tb01009 Tb04014TranspNavigation { get; set; }
    }
}