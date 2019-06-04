using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01051
    {
        public Tb01051()
        {
            Tb01010 = new HashSet<Tb01010>();
            Tb02003 = new HashSet<Tb02003>();
            Tb02074 = new HashSet<Tb02074>();
            Tb02087 = new HashSet<Tb02087>();
            Tb02092 = new HashSet<Tb02092>();
        }

        public DateTime? Tb01051Dtcad { get; set; }
        public string Tb01051Opcad { get; set; }
        public DateTime? Tb01051Dtalt { get; set; }
        public DateTime? Tb01051Opalt { get; set; }
        public string Tb01051Codigo { get; set; }
        public string Tb01051Nome { get; set; }
        public string Tb01051Situacao { get; set; }

        public virtual ICollection<Tb01010> Tb01010 { get; set; }
        public virtual ICollection<Tb02003> Tb02003 { get; set; }
        public virtual ICollection<Tb02074> Tb02074 { get; set; }
        public virtual ICollection<Tb02087> Tb02087 { get; set; }
        public virtual ICollection<Tb02092> Tb02092 { get; set; }
    }
}