using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01087
    {
        public Tb01087()
        {
            Tb02102 = new HashSet<Tb02102>();
        }

        public DateTime? Tb01087Dtcad { get; set; }
        public string Tb01087Opcad { get; set; }
        public DateTime? Tb01087Dtalt { get; set; }
        public string Tb01087Opalt { get; set; }
        public string Tb01087Codigo { get; set; }
        public string Tb01087Nome { get; set; }
        public string Tb01087Situacao { get; set; }
        public string Tb01087Obs { get; set; }

        public virtual ICollection<Tb02102> Tb02102 { get; set; }
    }
}