using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb02187
    {
        public DateTime? Tb02187Dtcad { get; set; }
        public string Tb02187Opcad { get; set; }
        public DateTime? Tb02187Dtalt { get; set; }
        public string Tb02187Opalt { get; set; }
        public string Tb02187Grupo { get; set; }
        public string Tb02187Sup { get; set; }
        public decimal? Tb02187Perc { get; set; }

        public virtual Tb02185 Tb02187GrupoNavigation { get; set; }
        public virtual Tb01010 Tb02187SupNavigation { get; set; }
    }
}