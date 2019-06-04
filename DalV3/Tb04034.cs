using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04034
    {
        public DateTime? Tb04034Dtcad { get; set; }
        public string Tb04034Opcad { get; set; }
        public DateTime? Tb04034Dtalt { get; set; }
        public string Tb04034Opalt { get; set; }
        public string Tb04034Codcen { get; set; }
        public string Tb04034Codcli { get; set; }
        public string Tb04034Codemp { get; set; }
        public string Tb04034Codigo { get; set; }
        public string Tb04034Codigo2 { get; set; }
        public string Tb04034Codsub { get; set; }
        public DateTime? Tb04034Data { get; set; }
        public DateTime? Tb04034Dtvenc { get; set; }
        public string Tb04034Nome { get; set; }
        public string Tb04034Obs { get; set; }
        public string Tb04034Situacao { get; set; }
        public string Tb04034Tipdoc { get; set; }
        public decimal? Tb04034Vlracres { get; set; }
        public decimal? Tb04034Vlrbruto { get; set; }
        public decimal? Tb04034Vlrdesconto { get; set; }
        public decimal? Tb04034Vlrtitulo { get; set; }
        public decimal? Tb04034Vlrpago { get; set; }
        public string Tb04034Parcial { get; set; }
        public string Tb04034Plancon { get; set; }
        public int? Tb04034Tipotitulo { get; set; }
        public DateTime Tb04034Dtcanc { get; set; }
        public string Tb04034Opcanc { get; set; }

        public virtual Tb04004 Tb04034CodcenNavigation { get; set; }
        public virtual Tb01008 Tb04034CodcliNavigation { get; set; }
        public virtual Tb01007 Tb04034CodempNavigation { get; set; }
        public virtual Tb04005 Tb04034CodsubNavigation { get; set; }
        public virtual Tb04006 Tb04034PlanconNavigation { get; set; }
        public virtual Tb04003 Tb04034TipdocNavigation { get; set; }
    }
}