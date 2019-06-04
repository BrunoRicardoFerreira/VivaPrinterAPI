using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01043
    {
        public Tb01043()
        {
            Tb02081 = new HashSet<Tb02081>();
            Tb02081b = new HashSet<Tb02081b>();
            Tb02082 = new HashSet<Tb02082>();
            Tb02082b = new HashSet<Tb02082b>();
        }

        public DateTime? Tb01043Dtcad { get; set; }
        public string Tb01043Opcad { get; set; }
        public DateTime? Tb01043Dtalt { get; set; }
        public string Tb01043Opalt { get; set; }
        public string Tb01043Codigo { get; set; }
        public string Tb01043Nome { get; set; }
        public string Tb01043Situacao { get; set; }
        public string Tb01043Color { get; set; }

        public virtual ICollection<Tb02081> Tb02081 { get; set; }
        public virtual ICollection<Tb02081b> Tb02081b { get; set; }
        public virtual ICollection<Tb02082> Tb02082 { get; set; }
        public virtual ICollection<Tb02082b> Tb02082b { get; set; }
    }
}