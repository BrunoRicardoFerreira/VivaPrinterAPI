using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01098
    {
        public string Tb01098Estado { get; set; }
        public string Tb01098Cidade { get; set; }
        public string Tb01098Area { get; set; }

        public virtual Tb01097 Tb01098AreaNavigation { get; set; }
    }
}