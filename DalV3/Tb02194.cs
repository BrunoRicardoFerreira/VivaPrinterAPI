using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02194
    {
        public DateTime? Tb02194Dtcad { get; set; }
        public string Tb02194Opcad { get; set; }
        public DateTime? Tb02194Dtalt { get; set; }
        public string Tb02194Opalt { get; set; }
        public string Tb02194Codigo { get; set; }
        public string Tb02194Codequip { get; set; }
        public int? Tb02194Medanterior { get; set; }
        public string Tb02194Obs { get; set; }

        public virtual Tb01093 Tb02194CodequipNavigation { get; set; }
    }
}