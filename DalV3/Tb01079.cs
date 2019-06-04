using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01079
    {
        public Tb01079()
        {
            Tb01080 = new HashSet<Tb01080>();
        }

        public DateTime? Tb01079Dtcad { get; set; }
        public string Tb01079Opcad { get; set; }
        public DateTime? Tb01079Dtalt { get; set; }
        public string Tb01079Opalt { get; set; }
        public string Tb01079Codigo { get; set; }
        public string Tb01079Nome { get; set; }
        public string Tb01079Situacao { get; set; }

        public virtual ICollection<Tb01080> Tb01080 { get; set; }
    }
}