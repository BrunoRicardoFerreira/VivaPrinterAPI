using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01047
    {
        public Tb01047()
        {
            Tb01010 = new HashSet<Tb01010>();
            Tb01058 = new HashSet<Tb01058>();
        }

        public DateTime? Tb01047Dtcad { get; set; }
        public string Tb01047Opcad { get; set; }
        public DateTime? Tb01047Dtalt { get; set; }
        public string Tb01047Opalt { get; set; }
        public string Tb01047Codigo { get; set; }
        public string Tb01047Nome { get; set; }
        public string Tb01047Situacao { get; set; }

        public virtual ICollection<Tb01010> Tb01010 { get; set; }
        public virtual ICollection<Tb01058> Tb01058 { get; set; }
    }
}