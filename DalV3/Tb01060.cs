using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01060
    {
        public string Tb01060Status { get; set; }
        public string Tb01060User { get; set; }
        public string Tb01060Tipo { get; set; }

        public virtual Tb00035 Tb01060UserNavigation { get; set; }
    }
}