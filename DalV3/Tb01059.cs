using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01059
    {
        public string Tb01059Status { get; set; }
        public string Tb01059User { get; set; }
        public string Tb01059Tipo { get; set; }

        public virtual Tb00035 Tb01059UserNavigation { get; set; }
    }
}