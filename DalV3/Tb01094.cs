using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01094
    {
        public Tb01094()
        {
            Tb02192 = new HashSet<Tb02192>();
            Tb02196 = new HashSet<Tb02196>();
        }

        public DateTime? Tb01094Dtcad { get; set; }
        public string Tb01094Opcad { get; set; }
        public DateTime? Tb01094Dtalt { get; set; }
        public string Tb01094Opalt { get; set; }
        public string Tb01094Codigo { get; set; }
        public string Tb01094Nome { get; set; }
        public string Tb01094Situacao { get; set; }

        public virtual ICollection<Tb02192> Tb02192 { get; set; }
        public virtual ICollection<Tb02196> Tb02196 { get; set; }
    }
}