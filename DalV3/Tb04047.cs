using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04047
    {
        public int Tb04047Id { get; set; }
        public string Tb04047Codemp { get; set; }
        public int? Tb04047Ano { get; set; }
        public string Tb04047Codcen { get; set; }
        public string Tb04047Codsub { get; set; }
        public string Tb04047Plancon { get; set; }
        public string Tb04047Tipo { get; set; }
        public decimal? Tb04047Valor01 { get; set; }
        public decimal? Tb04047Valor02 { get; set; }
        public decimal? Tb04047Valor03 { get; set; }
        public decimal? Tb04047Valor04 { get; set; }
        public decimal? Tb04047Valor05 { get; set; }
        public decimal? Tb04047Valor06 { get; set; }
        public decimal? Tb04047Valor07 { get; set; }
        public decimal? Tb04047Valor08 { get; set; }
        public decimal? Tb04047Valor09 { get; set; }
        public decimal? Tb04047Valor10 { get; set; }
        public decimal? Tb04047Valor11 { get; set; }
        public decimal? Tb04047Valor12 { get; set; }

        public virtual Tb04004 Tb04047CodcenNavigation { get; set; }
        public virtual Tb04005 Tb04047CodsubNavigation { get; set; }
        public virtual Tb04006 Tb04047PlanconNavigation { get; set; }
    }
}