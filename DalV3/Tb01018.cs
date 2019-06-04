using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01018
    {
        public Tb01018()
        {
            Tb01010 = new HashSet<Tb01010>();
            Tb01058 = new HashSet<Tb01058>();
        }

        public DateTime? Tb01018Dtcad { get; set; }
        public string Tb01018Opcad { get; set; }
        public DateTime? Tb01018Dtalt { get; set; }
        public string Tb01018Opalt { get; set; }
        public string Tb01018Codigo { get; set; }
        public string Tb01018Grupo { get; set; }
        public string Tb01018Nome { get; set; }
        public string Tb01018Situacao { get; set; }

        public virtual ICollection<Tb01010> Tb01010 { get; set; }
        public virtual ICollection<Tb01058> Tb01058 { get; set; }
    }
}