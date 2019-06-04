using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01061
    {
        public string Tb01061Status { get; set; }
        public string Tb01061Novostatus { get; set; }

        public virtual Tb01044 Tb01061NovostatusNavigation { get; set; }
        public virtual Tb01044 Tb01061StatusNavigation { get; set; }
    }
}