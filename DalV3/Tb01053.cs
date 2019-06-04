using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01053
    {
        public Tb01053()
        {
            Tb01010 = new HashSet<Tb01010>();
            Tb02003 = new HashSet<Tb02003>();
            Tb02074 = new HashSet<Tb02074>();
            Tb02087 = new HashSet<Tb02087>();
            Tb02092 = new HashSet<Tb02092>();
        }

        public DateTime? Tb01053Dtcad { get; set; }
        public string Tb01053Opcad { get; set; }
        public DateTime? Tb01053Dtalt { get; set; }
        public DateTime? Tb01053Opalt { get; set; }
        public string Tb01053Codigo { get; set; }
        public string Tb01053Nome { get; set; }
        public string Tb01053Situacao { get; set; }

        public virtual ICollection<Tb01010> Tb01010 { get; set; }
        public virtual ICollection<Tb02003> Tb02003 { get; set; }
        public virtual ICollection<Tb02074> Tb02074 { get; set; }
        public virtual ICollection<Tb02087> Tb02087 { get; set; }
        public virtual ICollection<Tb02092> Tb02092 { get; set; }
    }
}