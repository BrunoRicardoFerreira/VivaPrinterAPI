using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01003
    {
        public Tb01003()
        {
            Tb01010 = new HashSet<Tb01010>();
            Tb01058 = new HashSet<Tb01058>();
            Tb02173 = new HashSet<Tb02173>();
            Tb02174 = new HashSet<Tb02174>();
            Tb02215 = new HashSet<Tb02215>();
        }

        public DateTime? Tb01003Dtcad { get; set; }
        public string Tb01003Opcad { get; set; }
        public DateTime? Tb01003Dtalt { get; set; }
        public string Tb01003Opalt { get; set; }
        public string Tb01003Codigo { get; set; }
        public string Tb01003Nome { get; set; }
        public string Tb01003Situacao { get; set; }

        public virtual ICollection<Tb01010> Tb01010 { get; set; }
        public virtual ICollection<Tb01058> Tb01058 { get; set; }
        public virtual ICollection<Tb02173> Tb02173 { get; set; }
        public virtual ICollection<Tb02174> Tb02174 { get; set; }
        public virtual ICollection<Tb02215> Tb02215 { get; set; }
    }
}