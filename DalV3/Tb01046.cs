using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01046
    {
        public string Tb01046Codemp { get; set; }
        public string Tb01046Tipodesc { get; set; }

        public virtual Tb01007 Tb01046CodempNavigation { get; set; }
        public virtual Tb01022 Tb01046TipodescNavigation { get; set; }
    }
}