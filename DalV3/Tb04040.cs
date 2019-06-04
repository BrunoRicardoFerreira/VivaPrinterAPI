using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04040
    {
        public int Tb04040Lote { get; set; }
        public string Tb04040Codemp { get; set; }
        public string Tb04040Codfor { get; set; }
        public string Tb04040Codigo { get; set; }
        public string Tb04040Tipdoc { get; set; }
        public string Tb04040Codcen { get; set; }
        public string Tb04040Codsub { get; set; }
        public string Tb04040Plancon { get; set; }
        public decimal? Tb04040Vlrtitulo { get; set; }
        public string Tb04040Obs { get; set; }
        public int? Tb04040Tipo { get; set; }
        public DateTime? Tb04040Dtvenc { get; set; }

        public virtual Tb04004 Tb04040CodcenNavigation { get; set; }
        public virtual Tb01007 Tb04040CodempNavigation { get; set; }
        public virtual Tb01001 Tb04040CodforNavigation { get; set; }
        public virtual Tb04005 Tb04040CodsubNavigation { get; set; }
        public virtual Tb04038 Tb04040LoteNavigation { get; set; }
        public virtual Tb04006 Tb04040PlanconNavigation { get; set; }
        public virtual Tb04001 Tb04040TipdocNavigation { get; set; }
    }
}