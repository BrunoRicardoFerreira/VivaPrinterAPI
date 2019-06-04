using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01056
    {
        public Tb01056()
        {
            Tb02122 = new HashSet<Tb02122>();
        }

        public DateTime? Tb01056Dtcad { get; set; }
        public string Tb01056Opcad { get; set; }
        public DateTime? Tb01056Dtalt { get; set; }
        public DateTime? Tb01056Opalt { get; set; }
        public string Tb01056Codigo { get; set; }
        public string Tb01056Nome { get; set; }
        public string Tb01056Situacao { get; set; }

        public virtual ICollection<Tb02122> Tb02122 { get; set; }
    }
}