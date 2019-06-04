using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01052
    {
        public Tb01052()
        {
            Tb01010 = new HashSet<Tb01010>();
            Tb02003 = new HashSet<Tb02003>();
            Tb02074 = new HashSet<Tb02074>();
            Tb02087 = new HashSet<Tb02087>();
            Tb02092 = new HashSet<Tb02092>();
        }

        public DateTime? Tb01052Dtcad { get; set; }
        public string Tb01052Opcad { get; set; }
        public DateTime? Tb01052Dtalt { get; set; }
        public DateTime? Tb01052Opalt { get; set; }
        public string Tb01052Codigo { get; set; }
        public string Tb01052Nome { get; set; }
        public string Tb01052Situacao { get; set; }

        public virtual ICollection<Tb01010> Tb01010 { get; set; }
        public virtual ICollection<Tb02003> Tb02003 { get; set; }
        public virtual ICollection<Tb02074> Tb02074 { get; set; }
        public virtual ICollection<Tb02087> Tb02087 { get; set; }
        public virtual ICollection<Tb02092> Tb02092 { get; set; }
    }
}