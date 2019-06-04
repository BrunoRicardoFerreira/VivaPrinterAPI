using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02125
    {
        public DateTime? Tb02125Dtcad { get; set; }
        public string Tb02125Opcad { get; set; }
        public DateTime? Tb02125Dtalt { get; set; }
        public string Tb02125Opalt { get; set; }
        public string Tb02125Codigo { get; set; }
        public string Tb02125Codserv { get; set; }
        public decimal? Tb02125Qtprod { get; set; }
        public decimal? Tb02125Prunit { get; set; }
        public decimal? Tb02125Totvalor { get; set; }

        public virtual Tb02122 Tb02125CodigoNavigation { get; set; }
        public virtual Tb01005 Tb02125CodservNavigation { get; set; }
    }
}