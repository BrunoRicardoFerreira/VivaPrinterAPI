using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01062
    {
        public string Tb01062Status { get; set; }
        public string Tb01062User { get; set; }

        public virtual Tb01044 Tb01062StatusNavigation { get; set; }
        public virtual Tb00035 Tb01062UserNavigation { get; set; }
    }
}