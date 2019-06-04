using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01093
    {
        public Tb01093()
        {
            Tb02194 = new HashSet<Tb02194>();
            Tb02195 = new HashSet<Tb02195>();
            Tb02196 = new HashSet<Tb02196>();
        }

        public DateTime? Tb01093Dtcad { get; set; }
        public string Tb01093Opcad { get; set; }
        public DateTime? Tb01093Dtalt { get; set; }
        public string Tb01093Opalt { get; set; }
        public string Tb01093Codigo { get; set; }
        public string Tb01093Nome { get; set; }
        public string Tb01093Numserie { get; set; }
        public string Tb01093Pat { get; set; }
        public string Tb01093Situacao { get; set; }

        public virtual ICollection<Tb02194> Tb02194 { get; set; }
        public virtual ICollection<Tb02195> Tb02195 { get; set; }
        public virtual ICollection<Tb02196> Tb02196 { get; set; }
    }
}