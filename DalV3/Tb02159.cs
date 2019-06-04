using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02159
    {
        public Tb02159()
        {
            Tb02160 = new HashSet<Tb02160>();
        }

        public DateTime? Tb02159Dtcad { get; set; }
        public string Tb02159Opcad { get; set; }
        public DateTime? Tb02159Dtalt { get; set; }
        public string Tb02159Opalt { get; set; }
        public string Tb02159Mes { get; set; }
        public string Tb02159Codcli { get; set; }
        public int Tb02159Dia { get; set; }
        public decimal? Tb02159Vlrbruto { get; set; }
        public decimal? Tb02159Vlrretencoes { get; set; }
        public decimal? Tb02159Vlrtotal { get; set; }
        public int? Tb02159Status { get; set; }
        public string Tb02159Log { get; set; }
        public decimal? Tb02159Vlrhoras { get; set; }
        public string Tb02159Horatrab { get; set; }
        public string Tb02159Fechado { get; set; }
        public string Tb02159Erro { get; set; }
        public string Tb02159Obs { get; set; }
        public decimal? Tb02159Perdesc { get; set; }
        public decimal? Tb02159Vlrdesc { get; set; }

        public virtual Tb01008 Tb02159CodcliNavigation { get; set; }
        public virtual ICollection<Tb02160> Tb02160 { get; set; }
    }
}