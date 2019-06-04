using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01096
    {
        public Tb01096()
        {
            Tb02054 = new HashSet<Tb02054>();
        }

        public DateTime? Tb01096Dtcad { get; set; }
        public string Tb01096Opcad { get; set; }
        public DateTime? Tb01096Dtalt { get; set; }
        public string Tb01096Opalt { get; set; }
        public string Tb01096Codigo { get; set; }
        public string Tb01096Nome { get; set; }
        public string Tb01096Situacao { get; set; }

        public virtual ICollection<Tb02054> Tb02054 { get; set; }
    }
}