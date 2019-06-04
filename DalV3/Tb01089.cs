using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01089
    {
        public Tb01089()
        {
            Tb02183 = new HashSet<Tb02183>();
        }

        public DateTime? Tb01089Dtcad { get; set; }
        public string Tb01089Opcad { get; set; }
        public DateTime? Tb01089Dtalt { get; set; }
        public string Tb01089Opalt { get; set; }
        public string Tb01089Codigo { get; set; }
        public string Tb01089Nome { get; set; }
        public string Tb01089Situacao { get; set; }

        public virtual ICollection<Tb02183> Tb02183 { get; set; }
    }
}