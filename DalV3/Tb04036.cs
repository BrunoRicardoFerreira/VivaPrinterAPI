using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04036
    {
        public DateTime? Tb04036Dtcad { get; set; }
        public string Tb04036Opcad { get; set; }
        public DateTime? Tb04036Dtalt { get; set; }
        public string Tb04036Opalt { get; set; }
        public string Tb04036Codcen { get; set; }
        public string Tb04036Codemp { get; set; }
        public string Tb04036Codfor { get; set; }
        public string Tb04036Codigo { get; set; }
        public string Tb04036Codigo2 { get; set; }
        public string Tb04036Codsub { get; set; }
        public DateTime? Tb04036Data { get; set; }
        public DateTime? Tb04036Dtvenc { get; set; }
        public string Tb04036Nome { get; set; }
        public string Tb04036Obs { get; set; }
        public int? Tb04036Operacao { get; set; }
        public string Tb04036Prest { get; set; }
        public string Tb04036Situacao { get; set; }
        public string Tb04036Tipdoc { get; set; }
        public decimal? Tb04036Vlracres { get; set; }
        public decimal? Tb04036Vlrbruto { get; set; }
        public decimal? Tb04036Vlrdesconto { get; set; }
        public decimal? Tb04036Vlrtitulo { get; set; }
        public decimal? Tb04036Vlrpago { get; set; }
        public string Tb04036Transp { get; set; }
        public int? Tb04036Contpag { get; set; }
        public string Tb04036Provisao { get; set; }
        public string Tb04036Plancon { get; set; }
        public string Tb04036Parcial { get; set; }
        public int? Tb04036Tipotitulo { get; set; }
        public DateTime Tb04036Dtcanc { get; set; }
        public string Tb04036Opcanc { get; set; }

        public virtual Tb04004 Tb04036CodcenNavigation { get; set; }
        public virtual Tb01007 Tb04036CodempNavigation { get; set; }
        public virtual Tb01001 Tb04036CodforNavigation { get; set; }
        public virtual Tb04005 Tb04036CodsubNavigation { get; set; }
        public virtual Tb04006 Tb04036PlanconNavigation { get; set; }
        public virtual Tb01017 Tb04036PrestNavigation { get; set; }
        public virtual Tb04001 Tb04036TipdocNavigation { get; set; }
        public virtual Tb01009 Tb04036TranspNavigation { get; set; }
    }
}