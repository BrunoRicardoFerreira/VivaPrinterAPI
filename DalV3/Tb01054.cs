using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01054
    {
        public Tb01054()
        {
            Tb01010 = new HashSet<Tb01010>();
            Tb02003 = new HashSet<Tb02003>();
            Tb02074 = new HashSet<Tb02074>();
            Tb02092 = new HashSet<Tb02092>();
        }

        public DateTime? Tb01054Dtcad { get; set; }
        public string Tb01054Opcad { get; set; }
        public DateTime? Tb01054Dtalt { get; set; }
        public DateTime? Tb01054Opalt { get; set; }
        public string Tb01054Codigo { get; set; }
        public string Tb01054Nome { get; set; }
        public string Tb01054Situacao { get; set; }

        public virtual ICollection<Tb01010> Tb01010 { get; set; }
        public virtual ICollection<Tb02003> Tb02003 { get; set; }
        public virtual ICollection<Tb02074> Tb02074 { get; set; }
        public virtual ICollection<Tb02092> Tb02092 { get; set; }
    }
}