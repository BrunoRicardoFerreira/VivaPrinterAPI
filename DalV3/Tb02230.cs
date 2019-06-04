using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02230
    {
        public string Tb02230Codigo { get; set; }
        public string Tb02230Codemp { get; set; }
        public decimal? Tb02230Vlrfrete { get; set; }
        public decimal? Tb02230Vlroutdesp { get; set; }
        public int? Tb02230Tipofrete { get; set; }
        public string Tb02230Transp { get; set; }
        public string Tb02230Clatende { get; set; }
        public string Tb02230Obs { get; set; }
        public string Tb02230Obsadd { get; set; }

        public virtual Tb01068 Tb02230ClatendeNavigation { get; set; }
        public virtual Tb01009 Tb02230TranspNavigation { get; set; }
    }
}