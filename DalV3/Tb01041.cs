using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01041
    {
        public Tb01041()
        {
            Tb02011 = new HashSet<Tb02011>();
            Tb02015 = new HashSet<Tb02015>();
        }

        public DateTime? Tb01041Dtcad { get; set; }
        public string Tb01041Opcad { get; set; }
        public DateTime? Tb01041Dtalt { get; set; }
        public string Tb01041Opalt { get; set; }
        public string Tb01041Codigo { get; set; }
        public string Tb01041Nome { get; set; }
        public string Tb01041Situacao { get; set; }

        public virtual ICollection<Tb02011> Tb02011 { get; set; }
        public virtual ICollection<Tb02015> Tb02015 { get; set; }
    }
}