using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01090
    {
        public Tb01090()
        {
            Tb02184 = new HashSet<Tb02184>();
        }

        public DateTime? Tb01090Dtcad { get; set; }
        public string Tb01090Opcad { get; set; }
        public DateTime? Tb01090Dtalt { get; set; }
        public string Tb01090Opalt { get; set; }
        public string Tb01090Codigo { get; set; }
        public string Tb01090Nome { get; set; }
        public string Tb01090Situacao { get; set; }

        public virtual ICollection<Tb02184> Tb02184 { get; set; }
    }
}