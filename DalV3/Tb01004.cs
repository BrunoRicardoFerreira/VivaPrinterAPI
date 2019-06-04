using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class Tb01004
    {
        public Tb01004()
        {
            Tb01010 = new HashSet<Tb01010>();
            Tb01095 = new HashSet<Tb01095>();
        }

        public DateTime? Tb01004Dtcad { get; set; }
        public string Tb01004Opcad { get; set; }
        public DateTime? Tb01004Dtalt { get; set; }
        public string Tb01004Opalt { get; set; }
        public string Tb01004Codigo { get; set; }
        public string Tb01004Nome { get; set; }
        public string Tb01004Situacao { get; set; }

        public virtual ICollection<Tb01010> Tb01010 { get; set; }
        public virtual ICollection<Tb01095> Tb01095 { get; set; }
    }
}