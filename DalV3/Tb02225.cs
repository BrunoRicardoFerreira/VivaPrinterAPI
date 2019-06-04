using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02225
    {
        public DateTime? Tb02225Dtcad { get; set; }
        public string Tb02225Opcad { get; set; }
        public string Tb02225Os { get; set; }
        public string Tb02225Codserv { get; set; }

        public virtual Tb02192 Tb02225CodservNavigation { get; set; }
        public virtual Tb02193 Tb02225OsNavigation { get; set; }
    }
}