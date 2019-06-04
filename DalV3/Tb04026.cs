using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb04026
    {
        public DateTime? Tb04026Dtcad { get; set; }
        public string Tb04026Opcad { get; set; }
        public DateTime? Tb04026Dtalt { get; set; }
        public string Tb04026Opalt { get; set; }
        public string Tb04026Codigo { get; set; }
        public string Tb04026Nome { get; set; }
        public int? Tb04026Diagera { get; set; }
        public int? Tb04026Diavenc { get; set; }
        public string Tb04026Forn { get; set; }
        public string Tb04026Codcen { get; set; }
        public string Tb04026Codsub { get; set; }
        public string Tb04026Tipdoc { get; set; }
        public decimal? Tb04026Vlrdoc { get; set; }
        public string Tb04026Situacao { get; set; }
        public int? Tb04026Ultmes { get; set; }
        public int? Tb04026Numpar { get; set; }

        public virtual Tb04004 Tb04026CodcenNavigation { get; set; }
        public virtual Tb04005 Tb04026CodsubNavigation { get; set; }
        public virtual Tb01001 Tb04026FornNavigation { get; set; }
        public virtual Tb04001 Tb04026TipdocNavigation { get; set; }
    }
}